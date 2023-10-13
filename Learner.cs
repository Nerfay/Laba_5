using System;


namespace Laba_5_V_1
{
    public class Learner
    {
        private PersonInfo _personInfo;

        public Learner(string name, DateTime dateOfBirth, string placeResidence, string telephoneNumberParent)
        {
            PersonInfo = new PersonInfo(name, dateOfBirth, placeResidence, telephoneNumberParent);
        }
        /// <summary>
        /// Свойство персональной информации учащегося
        /// </summary>
        private PersonInfo PersonInfo
        {
            get => _personInfo;
            set => _personInfo = value;
        }

        public override string ToString()
        {
            return PersonInfo.ToString();
        }
    }
}
