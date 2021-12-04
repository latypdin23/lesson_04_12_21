using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_04_12_21
{
    class Vector
    {
        // Координаты точки в трехмерном пространстве
        public int x, y, z;
        // конструктор
        public Vector(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        // Перегружаем бинарную операцию + (сложение векторов)
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector v = new Vector();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        // Перегружаем бинарную операцию - (разность векторов)
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector v = new Vector();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        public void printV(string s)
        {
            Console.WriteLine(s + x + " " + y + " " + z);
        }
    }
}
