using System;


namespace Laba_5_V_1
{
    public class Student:Learner
    {
        private readonly int MAX_NUMBER_COURSE = 5;

        private bool _isFullTimeEducation;
        private int _currentNumberCourse;
        private string _nameSpeciality;
        public Student(string name, DateTime dateOfBirth, string placeResidence, string telephoneNumberParent, bool isFullTimeEducation,int currentNumberCourse , string nameSpeciality) : base(name, dateOfBirth, placeResidence, telephoneNumberParent)
        {
            IsFullTimeEducation = isFullTimeEducation;
            СurrentNumberCourse = currentNumberCourse;
            NameSpeciality = nameSpeciality;
        }
        /// <summary>
        /// Свойство на очной ли форме обучения студент
        /// </summary>
        private bool IsFullTimeEducation
        {
            get => _isFullTimeEducation;
            set => _isFullTimeEducation = value;
        }
        /// <summary>
        ///Свойство текущий номер курса  , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимальногго(MAX_NUMBER_COURSE) 
        /// </summary>
        private int СurrentNumberCourse
        {
            get => _currentNumberCourse;
            set
            {
                if (value >= 0 && value <= MAX_NUMBER_COURSE)
                {
                    _currentNumberCourse = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Поле СurrentNumberCourse не может быть больше чем MAX_NUMBER_COURSE или отрицательной   СurrentNumberCourse={value}");
                }
            }

        }
        /// <summary>
        /// Сойство название специальности , возвращает ArgumentNullException, если пытаемся присвоить пустую строку или строку из одного символа
        /// </summary>
        private string NameSpeciality
        {
            get => _nameSpeciality;
            set
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
                {
                    _nameSpeciality = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException($"Поле NameSpeciality равно нулю или пустой строке  NameSpeciality={value}");
                }
            }
        }
        public override string ToString()
        {
            string formEducation = IsFullTimeEducation ? "full" : "part";
            formEducation += "-time education";
            return base.ToString() + $"\nStudent:\n Form Education:{formEducation}\nCurrent number course :{СurrentNumberCourse}\n Name speciality:{NameSpeciality}";
        }
    }
}
