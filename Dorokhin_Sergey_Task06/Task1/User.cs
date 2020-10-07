using System;

namespace Task1
{
    public class User
    {
        protected const int YearCurrent = 2020;
        protected const int YearMin = 1900;
        protected const int MonthMax = 12;
        protected int _day;
        protected int _month;
        protected int _year;
        protected int _age;
        
        public User(string surname, string name, string patronymic, int day, int month, int year)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;

            if (year > YearMin && year <= YearCurrent)
            {
                _year = year;
            }
            else
            {
                throw new Exception($"Год рождения не может быть меньше {YearMin} или больше {YearCurrent}!");
            }

            if (month > 0 && month <= MonthMax)
            {
                _month = month;
            }
            else
            {
                throw new Exception($"Месяц рождения не может быть меньше 1 или больше {MonthMax}!");
            }

            int DayMaxInCurrentYearMonth = DateTime.DaysInMonth(_year, _month);

            if (day > 0 && day <= DayMaxInCurrentYearMonth)
            {
                _day = day;
            }
            else
            {
                throw new Exception($"При заданных годе и месяце день рождения" +
                    $" не может быть меньше 1 или больше {DayMaxInCurrentYearMonth}!");
            }

            _age = YearCurrent - _year;
        }

        public string Surname { get; set; }
        
        public string Name { get; set; }
        
        public string Patronymic { get; set; }

        public virtual int Year
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
            }
        }

        public virtual int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value > 0 && value <= MonthMax)
                {
                    _month = value;
                }
                else
                {
                    throw new Exception($"Месяц рождения не может быть меньше 1 или больше {MonthMax}!");
                }
            }
        }

        public virtual int Day
        {
            get
            {
                return _day;
            }
            set
            {
                int DayMaxInCurrentYearMonth = DateTime.DaysInMonth(_year, _month);
                
                if (value > 0 && value <= DayMaxInCurrentYearMonth)
                {
                    _day = value;
                }
                else
                {
                    throw new Exception($"При заданных годе и месяце день рождения" +
                        $" не может быть меньше 1 или больше {DayMaxInCurrentYearMonth}!");
                }
            }
        }

        public virtual int Age => _age;
    }
}
