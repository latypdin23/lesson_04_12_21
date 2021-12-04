using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_04_12_21
{
    class ClassCounter  //Это класс - в котором производится счет.
    {
        public delegate void MethodContainer();

        //Событие OnCount c типом делегата MethodContainer.
        public event MethodContainer onCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    onCount();
                }
            }
        }
    }
}
