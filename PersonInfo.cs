using System;
using System.Text.RegularExpressions;

namespace Laba_5_V_1
{
    public class PersonInfo
    {
        private readonly int MAX_AGE = 123;
        private string _name;
        private int _age;
        private readonly DateTime _dateOfBirth;
        private string _placeResidence;
        private string _telephoneNumberParent;

        public PersonInfo(string name, DateTime dateOfBirth,string placeResidence, string telephoneNumberParent)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PlaceResidence = placeResidence;
            TelephoneNumberParent = telephoneNumberParent;
        }
        /// <summary>
        /// Свойство имя персоны, возвращает ArgumentNullException, если пытаемся присвоить пустую строку или строку с одним символом
        /// </summary>
        private string Name
        {
            get => _name;
            
            set
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
                {
                    _name = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException($"Поле Name равно нулю или пустой строке или длина поля Name равна 1 Name={value}");
                }
            }
        }
        /// <summary>
        ///СВойство возраст персоны, возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения
        /// </summary>
        private int Age
        {
            get => _age;
            set { 
                if(value>=0 && value < MAX_AGE)
                {
                    _age = value;
                }else
                {
                    throw new ArgumentOutOfRangeException($"Поле Age не может быть  больше чем MAX_AGE или отрицательной  Age={value}");
                }
            } 
                

        }
        /// <summary>
        /// свойство даты рождения, возвращает ArgumentException, если пытаемся присвоить некоректную дату 
        /// </summary>
        private DateTime DateOfBirth
        {
            get => _dateOfBirth;
            init
            {
                DateTime dateTimeNow = DateTime.Now;
                if (value < dateTimeNow)
                {
                    _dateOfBirth = value;
                    int age = dateTimeNow.Year - value.Year;
                    if (value > dateTimeNow.AddYears(-age)) age--;
                    Age = age;
                }
                else
                {
                    throw new ArgumentException($" Неверная дата DateOfBirth:'{value}' ");

                }

            }

        }
        /// <summary>
        /// Сойство место проживания, возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        private string PlaceResidence
        {
            get => _placeResidence;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _placeResidence = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException($"Поле PlaceResidence равно нулю или пустой строке PlaceResidence={value}");
                }
            }
        }
        /// <summary>
        /// Свойство телефон родителя, возвращает ArgumentNullException, если пытаемся присвоить пустую строку, возвращает ArgumentException, если некоректный формат телефона
        /// </summary>
        private string TelephoneNumberParent
        {
            get => _telephoneNumberParent;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string pattern = @"^\+380[0-9]{6,12}$";
                    Regex regex = new Regex(pattern);
                    if (regex.IsMatch(value.Trim()))
                    {
                        _telephoneNumberParent = value;
                    }
                    else
                    {
                        throw new ArgumentException($"Поле TelephoneNumberParent не соответствует формату строки '+380XXXXXXXXX' TelephoneNumberParent={value}");
                    }
                }
                else
                {
                    throw new ArgumentNullException($"Поле TelephoneNumberParent равно нулю или пустой строке TelephoneNumberParent={value}");
                }
            }
        }
        public override string ToString()
        {
            return $"Person info : \nName:{Name}\nAge:{Age}\nDate of birth:{DateOfBirth.ToLongDateString()}\nPlace of residence:{PlaceResidence}\nPhone number one of perent:{TelephoneNumberParent}";
        }
    }
}
