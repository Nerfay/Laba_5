using System;


namespace Laba_5_V_1
{
    public class Schoolboy:Learner
    {
        private readonly int MAX_COUNT_OLYMPIAD = 100;
        private readonly double MAX_AVERAGE_MARK = 12.0;
        private readonly int MAX_NUMBER_CLASS = 11;

        private int _countOlympiads;
        private double _averageMark;
        private int _currentNumberClass;

        public Schoolboy(string name, DateTime dateOfBirth, string placeResidence, string telephoneNumberParent, int countOlympiads, double averageMark,int currentNumberClass) : base(name, dateOfBirth, placeResidence, telephoneNumberParent)
        {
            CountOlympiads = countOlympiads;
            AverageMark = averageMark;
            CurrentNumberClass = currentNumberClass;
        }
        /// <summary>
        ///Свойство количестов посещенных олимпиад , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимальногго(MAX_COUNT_OLYMPIAD) 
        /// </summary>
        private int CountOlympiads
        {
            get => _countOlympiads;
            set
            {
                if (value >= 0 && value < MAX_COUNT_OLYMPIAD)
                {
                    _countOlympiads = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Поле CountOlympiads не может быть больше чем MAX_COUNT_OLYMPIAD или отрицательной   CountOlympiads={value}");
                }
            }


        }
        /// <summary>
        ///Свойство средний бал  , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимальногго(MAX_AVERAGE_MARK) 
        /// </summary>
        private double AverageMark
        {
            get => _averageMark;
            set
            {
                if (value >= 0 && value <= MAX_AVERAGE_MARK)
                {
                    _averageMark = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Поле AverageMark не может быть больше чем MAX_AVERAGE_MARK или отрицательной   AverageMark={value}");
                }
            }


        }
        /// <summary>
        ///Свойство текущий номер класса  , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимальногго(MAX_NUMBER_CLASS) 
        /// </summary>
        private int CurrentNumberClass
        {
            get => _currentNumberClass;
            set
            {
                if (value >= 0 && value <= MAX_NUMBER_CLASS)
                {
                    _currentNumberClass = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Поле CurrentNumberClass не может быть больше чем MAX_NUMBER_CLASS или отрицательной   CurrentNumberClass={value}");
                }
            }

        }
        public override string ToString()
        {
            return base.ToString() + $"\nSchoolboy:\nCount of olympiads attended:{CountOlympiads}\nAverage mark :{AverageMark}\nCurrent number class :{CurrentNumberClass}";
        }
    }
}
