using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entites;

namespace UsersAndRewards.DAL
{
    public class RewardsSql : IAccess<Reward>
    {
        private string _connectionString;

        public RewardsSql(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Reward reward)
        {
            string sqlExpression = "AddReward";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var titleParam = new SqlParameter("@title", reward.Title);

                command.Parameters.Add(titleParam);

                var descriptionParam = new SqlParameter("@description", reward.Description);

                command.Parameters.Add(descriptionParam);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Reward reward)
        {
            string sqlExpression = "UpdateReward";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var idParam = new SqlParameter("@RewardId", reward.Id);

                command.Parameters.Add(idParam);

                var titleParam = new SqlParameter("@title", reward.Title);

                command.Parameters.Add(titleParam);

                var descriptionParam = new SqlParameter("@description", reward.Description);

                command.Parameters.Add(descriptionParam);

                command.ExecuteNonQuery();
            }
        }

        public void Remove(Reward reward)
        {
            string sqlExpression = "RemoveReward";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var rewardIdParam = new SqlParameter("@rewardId", reward.Id);

                command.Parameters.Add(rewardIdParam);
                command.ExecuteNonQuery();
            }
        }

        public List<Reward> GetList()
        {
            string sqlExpression = "GetRewardsList";
            var resultList = new List<Reward>();

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resultList.Add(new Reward(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }

            return resultList;
        }
    }
}
