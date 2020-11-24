using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common;
using System.Data;

namespace DAL
{
    public class UsersSql : IAccess<User>
    {
        private readonly string _connectionString;
        
        public UsersSql(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        private DataTable ConvertRewardsListToIdsTable(List<Reward> rewards)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("id", typeof(int));

            foreach (var reward in rewards)
            {
                dataTable.Rows.Add(reward.Id);
            }

            return dataTable;
        }

        private void FillUserRewards(List<User> users)
        {
            string sqlExpression = "GetAllRewardsCurrentUser";
            
            foreach (var user in users)
            {
                using(var connection = new SqlConnection(_connectionString))
                using(var command = new SqlCommand())
                {
                    command.CommandText = sqlExpression;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@UserId", user.Id);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var reward = new Reward(reader.GetInt32(0),
                                                    reader.GetString(1),
                                                    reader.GetString(2));

                            user.Rewards.Add(reward);
                        }
                    }

                    connection.Close();
                }
            }
        }
        
        public void Add(User user)
        {
            string sqlExpression = "AddUser";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var    firstNameParam = new SqlParameter("@firstName", user.FirstName);
                var     lastNameParam = new SqlParameter("@lastName",  user.LastName);
                var dateBirthdayParam = new SqlParameter("@birthday",  user.DateBirthday);
                var      rewardsParam = new SqlParameter("@rewardIds", ConvertRewardsListToIdsTable(user.Rewards));

                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(dateBirthdayParam);
                command.Parameters.Add(rewardsParam);

                command.ExecuteNonQuery();
            }
        }

        public void Update(User user)
        {
            string sqlExpression = "UpdateUser";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var       userIdParam = new SqlParameter("@userId",    user.Id);
                var    firstNameParam = new SqlParameter("@firstName", user.FirstName);
                var     lastNameParam = new SqlParameter("@lastName",  user.LastName);
                var dateBirthdayParam = new SqlParameter("@birthday",  user.DateBirthday);
                var    rewardIdsParam = new SqlParameter("@rewardIds", ConvertRewardsListToIdsTable(user.Rewards));

                command.Parameters.Add(userIdParam);
                command.Parameters.Add(firstNameParam);
                command.Parameters.Add(lastNameParam);
                command.Parameters.Add(dateBirthdayParam);
                command.Parameters.Add(rewardIdsParam);

                command.ExecuteNonQuery();
            }
        }

        public void Remove(User user)
        {
            string sqlExpression = "RemoveUser";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var userIdParam = new SqlParameter("@userId", user.Id);

                command.Parameters.Add(userIdParam);
                command.ExecuteNonQuery();
            }
        }

        public List<User> GetList()
        {
            string sqlExpression = "GetUsersList";
            var users = new List<User>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand())
            {
                command.CommandText = sqlExpression;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User(reader.GetInt32(0),
                                            reader.GetString(1),
                                            reader.GetString(2),
                                            reader.GetDateTime(3),
                                            new List<Reward>());

                        users.Add(user);
                    }
                }

                connection.Close();
            }
            FillUserRewards(users);

            return users;
        }
    }
}
