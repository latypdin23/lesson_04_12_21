using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_04_12_21
{
    class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        public void Message()
        {
            //Не забудьте using System 
            //для вывода в консольном приложении
            Console.WriteLine("Пора действовать, ведь уже 71!");
        }
    }
}
