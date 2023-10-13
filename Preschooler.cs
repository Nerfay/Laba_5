using System;


namespace Laba_5_V_1
{
    public class Preschooler : Learner
    {
        private readonly int MAX_SPEED_READING = 100;

        private bool _isEndingKindergarten;
        private int _speedReadingInMinute;
        private bool _isKnowMathSkill;
        public Preschooler(string name, DateTime dateOfBirth, string placeResidence, string telephoneNumberParent,bool isEndingKindergarten,int speedReading , bool isKnowMathSkill) : base(name, dateOfBirth, placeResidence, telephoneNumberParent)
        {
            IsEndingKindergarten = isEndingKindergarten;
            SpeedReadingInMinute = speedReading;
            IsKnowMathSkill = isKnowMathSkill;
        }
        /// <summary>
        /// Свойство закончил ли детский сад дошкольник
        /// </summary>
        private bool IsEndingKindergarten
        {
            get => _isEndingKindergarten;
            set => _isEndingKindergarten = value;
        }
        /// <summary>
        /// Свойство знает ли математические скиллы дошкольник
        /// </summary>
        private bool IsKnowMathSkill
        {
            get => _isKnowMathSkill;
            set => _isKnowMathSkill = value;
        }
        /// <summary>
        /// Свойство скорость чтения в минуту, возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимального (MAX_SPEED_READING)  
        /// </summary>
        private int SpeedReadingInMinute
        {
            get => _speedReadingInMinute;
            set
            {
                if (value >= 0 && value < MAX_SPEED_READING)
                {
                    _speedReadingInMinute = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Поле SpeedReading не может быть больше чем MAX_AGE или отрицательной   Age={value}");
                }
            }


        }
        public override string ToString()
        {
            return base.ToString()+$"\nPreschooler:\nGraduated from kindergarten:{IsEndingKindergarten}\nSpeed reading in minute:{SpeedReadingInMinute}\nHave basic math skills:{IsKnowMathSkill}";
        }
    }
}
