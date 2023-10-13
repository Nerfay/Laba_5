using System;

namespace Laba_5_V_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Preschooler preschooler1 = new Preschooler(name: "Kola", dateOfBirth: new DateTime(2020, 3, 4), placeResidence: "Usa", telephoneNumberParent: "+380123456789", isEndingKindergarten: true, speedReading: 32, isKnowMathSkill: false);
            Schoolboy schoolboy1 = new Schoolboy(name: "Afia", dateOfBirth: new DateTime(2009, 3, 13), placeResidence: "Urugvai", telephoneNumberParent: "+380123456789",countOlympiads:0,averageMark:3.3,currentNumberClass:5);
            Student student1 = new Student(name: "Venera", dateOfBirth: new DateTime(2004, 4, 7), placeResidence: "UK", telephoneNumberParent: "+380123456789",isFullTimeEducation:false,currentNumberCourse:5,nameSpeciality:"AT");

            Learners learners = new Learners(preschooler1, schoolboy1);
            Console.WriteLine("\nArray:\n"+learners);
            learners.Add(student1);
            Console.WriteLine("\nArray:\n" + learners);
            learners.RemoveByIndex(1);
            Console.WriteLine("\nArray:\n" + learners);
            learners.UpdateByIndex(student1,0);
            Console.WriteLine("\nArray:\n" + learners);

        }
    }
}
