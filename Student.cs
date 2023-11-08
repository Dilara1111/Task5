using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Student
    {
        private int[] _grades;
        public int[] Grades
        {
            get 
            {               
                return _grades;
            }
            set 
            {
                int counter = 0;
                foreach (var item in value)
                {
                    if (item%2 == 0)
                    {
                        counter++;
                    }
                }
                _grades = new int[counter];
                for (int i = 0, j = 0; i < value.Length; i++)
                {     
                    if (value[i] % 2 == 0)
                    {
                        _grades[j++] = value[i];
                    }
                }
            }
           

        }

    }
}
