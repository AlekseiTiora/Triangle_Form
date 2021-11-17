using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Form
{
    class Triangle
    {
        public double a; //первая сторона
        public double b; //вторая сторона
        public double c; //третья сторона
        public double h;//высота 
        public double p; //периметр

        public Triangle(double A, double B, double C) //Конструктор
        {
            a = A; // создаем с заданным длинами сторон согласно заданию
            b = B;
            c = C;
        }

        public Triangle(double A, double H) //Конструктор
        {
            a = A; // создаем с заданным длинами сторон согласно заданию
            h = H;
        }


        public string outputA() // выводим сторону a, данный метод возращает сторокове значени
        {
            return Convert.ToString(a); // а - ссылка на внутренне поле объекта класса
        }
        public string outputB() 
        {
            return Convert.ToString(b); //выводим сторону b
        }
        public string outputH() //выводим высоту h
        {
            return Convert.ToString(h);
        }

        public string outputC() //выводим сторону c
        {
            return Convert.ToString(c); 
        }
        public double Perimeter() // суммы всех сторон типа double
        {
            double p = 0;
            p = a + b + c; // вычисление...
            return p; //возраст
        }
        public double Visota()
        {
            double h = 0;
            double s = 0;
            h = (2 * s) / a;
            return h;
        }
        
        public double Surface() // аналогично периметру..
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

         public double Surface_ploshad()
        {
            double s = 0;
            s = (a + h / 2);
            return s;
        }

        public double Perimetr_ravnobedrennogo()
        {
            double p = 0;
            p = 2 * (a + b);
            return p;
        }

        public double Sredn()
        {
            double z = 0;
            z = a / 2;
            return z;
        }

        public double GetSetA // свойство позволяющее установить либо изменить значние стороны a
        {
            get // устанавливаем
            { return a; }
            set // меняем
            { a = value; }
        }

        public double GetSetB // свойство позволяющее установить либо изменить значние стороны b
        {
            get // устанавливаем
            { return b; }
            set // меняем
            { b = value; }
        }

        public double GetSetC // свойство позволяющее установить либо изменить значние стороны c
        {
            get // устанавливаем
            { return c; }
            set // меняем
            { c = value; }
        }

        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b) || a + b + c == 0)//сумма 2 сторон должна быть больше третьей
                    return false;
                else return true;
            }
        }

        public string TriangleType //свойство позволяющее установить, существует ли труеугольник с задаными сторонами
        {
            get
            {
                if (a == b && a == c && b == c)//
                    return "равносторонний";
                else if (a == b || a == c || b == c)
                    return "это равнобедренный";

                else return "это разносторонний";
            }
        }



    }
}
