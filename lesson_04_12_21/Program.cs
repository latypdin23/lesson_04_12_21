using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_04_12_21
{
    class Program
    {
        //Возвращает значение операнда, увеличенное на 13 процентов
        public static double SomeOperation(double aValue)
        {
            return aValue * 1.13;
        }
        public static void ex1()
        {
            Vector V1 = new Vector(3, 4, 5);
            Vector V2 = new Vector(-3, -4, 5);
            V1.printV("Координаты первого вектора: ");
            V2.printV("Координаты второго вектора: ");
            Vector V3 = V1 + V2;    // ПЕРЕГРУЗКА!
            V3.printV("Координаты суммы векторов: ");
            V3 = V1 - V2;           // ПЕРЕГРУЗКА!
            V3.printV("Координаты разности векторов: ");
            Console.ReadLine();
        }
        public static void ex2()
        {
            //Создание коллекции
            DoubleCollection someCollection = new DoubleCollection();

            //Добавление в неё элементов
            someCollection.Add(124.4);
            someCollection.Add(120.8);
            someCollection.Add(118.1);
            someCollection.Add(128.9);
            someCollection.Add(111.3);

            //Создание делегата на основе метода SomeOperation и присваивание его коллекции
            someCollection.Operation = new DoubleOperation(SomeOperation);

            //Выполнение операции
            someCollection.DoOperation();

            //Вывод результата в консоль
            for (int i = 0; i < someCollection.Count; i++)
            {
                Console.WriteLine(someCollection[i]);
            }
        }
        public static void ex3()
        {
            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();

            //Подписались на событие
            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;

            //Запустили счетчик
            Counter.Count();
        }
        static void Main(string[] args)
        {
            ex3();
        }
    }
}
