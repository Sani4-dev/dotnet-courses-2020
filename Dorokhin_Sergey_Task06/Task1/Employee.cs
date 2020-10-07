using System;

namespace Task1
{
    public class Employee : User
    {
        protected const int AgeEmployeeMin = 18;
        protected int _workExperience;
        
        public Employee(string surname, string name, string patronymic, int day, int month, int year, string position,
            int workExperience)
            : base(surname, name, patronymic, day, month, year)
        {
            Position = position;

            if (_age <= AgeEmployeeMin)
            {
                throw new Exception($"При указанных данных о рождении возраст сотрудника равен {_age}. " +
                    $"Возраст сотрудника не может быть меньше {AgeEmployeeMin} лет!");
            }

            if (workExperience >= 0 && workExperience < _age - AgeEmployeeMin)
            {
                _workExperience = workExperience;
            }
            else
            {
                throw new Exception($"Значение \"workExperience\" не может быть отрицательным или больше, " +
                    $"чем {_age - AgeEmployeeMin} при указанных данных о рождении!");
            }
        }

        public override int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > YearMin && value <= YearCurrent)
                {
                    _year = value;
                }
                else
                {
                    throw new Exception($"Год рождения не может быть меньше {YearMin} или больше {YearCurrent}!");
                }

                if (_age <= AgeEmployeeMin)
                {
                    throw new Exception($"При указанных данных о рождении возраст сотрудника равен {_age}. " +
                        $"Возраст сотрудника не может быть меньше {AgeEmployeeMin} лет!");
                }
            }
        }

        public string Position { get; set; }

        public int WorkExperience
        {
            get
            {
                return _workExperience;
            }
            set
            {
                if (value >= 0 && value < _age - AgeEmployeeMin)
                {
                    _workExperience = value;
                }
                else
                {
                    throw new Exception($"Значение \"WorkExperience\" не может быть отрицательным или больше, " +
                        $"чем {_age - AgeEmployeeMin} при указанных данных о рождении!");
                }
            }
        }
    }
}
