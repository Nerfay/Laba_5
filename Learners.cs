using System;
using System.Text;

namespace Laba_5_V_1
{
    public class Learners
    {
        private Learner[] _learners;
        /// <summary>
        /// если параметром приходит ноль инициализируем с нулевой длиной массив _learners
        /// </summary>
        /// <param name="learners">елементы вставляемые в массив, нащадки класса Learner</param>
        public Learners(params Learner[] learners)
        {
            if (learners is not null)
            {
                _learners = learners;
            }
            else
            {
                _learners = new Learner[0];
            }
        }
        /// <summary>
        /// добавление елемента в конец массива
        /// </summary>
        /// <param name="learner">обьект для добавления в массив</param>
        public void Add(Learner learner)
        {
            Array.Resize(ref _learners, _learners.Length + 1);
            _learners[_learners.Length - 1] = learner;
        }
        /// <summary>
        /// удаления елемента массива по индексу
        /// </summary>
        /// <param name="indexRemove">индекс удаляемого обьекта</param>
        public void RemoveByIndex(int indexRemove)
        {
            if ( indexRemove >= 0 && indexRemove < _learners.Length )
            {
                Learner[] newLearners = new Learner[_learners.Length - 1];
                for (int i = 0, j = 0; i < _learners.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newLearners[j] = _learners[i];
                        j++;
                    }
                }
                _learners = newLearners;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Индекс удаляемого елемента выходит за пределы массива или равен отрицательному значению ");
            }

        }
        /// <summary>
        /// обновление елемента по индексу по инд
        /// </summary>
        /// <param name="learner"> новый елемент</param>
        /// <param name="indexUpdate">индекс куда обновляемого елемента</param>
        public void UpdateByIndex(Learner learner, uint indexUpdate)
        {
            if ( indexUpdate >= 0 && indexUpdate < _learners.Length)
            {
                _learners[indexUpdate] = learner;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Индекс удаляемого елемента выходит за пределы массива или равен отрицательному значению ");
            }

        }

        public override string ToString()
        {
            String  result = "";
            foreach (Learner learner in _learners)
            {
                result+=learner + "\n\n";
            }
            return result;
        }
    }
}

