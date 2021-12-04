using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_04_12_21
{
    delegate double DoubleOperation(double anAgr);
    class DoubleCollection
    {
        //Добавляет элемент в коллекцию
        public void Add(double anItem)
        {
            collection.Add(anItem);
        }

        //Удаляет элемент из коллекции (по индексу)
        public void RemoveAt(int anIndex)
        {
            collection.RemoveAt(anIndex);
        }

        //Вызывает метод, на который ссылается делегат для всех элементов коллекции
        public void DoOperation()
        {
            //Если делегат задан
            if (operation != null)
            {
                //Перебрать все элементы коллекции
                for (int i = 0; i < collection.Count; i++)
                {
                    //Выполнить операцию над текущим элементом
                    collection[i] = operation(collection[i]);
                }
            }
        }

        //Устанавливает или возвращает значение делегата operation 
        public DoubleOperation Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        //Индексатор (возвращает или устанавливает значение элемента по индексу)
        public double this[int anIndex]
        {
            get { return collection[anIndex]; }
            set { collection[anIndex] = value; }
        }

        //Возвращает количество элементов
        public int Count
        {
            get
            {
                return collection.Count;
            }
        }

        //Хранилище элементов
        private List<double> collection = new List<double>();
        //Делегат, для хранения ссылки на метод, который укажет пользователь класса
        private DoubleOperation operation = null;
    }
}
