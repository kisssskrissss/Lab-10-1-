using System;

namespace Lab_101
{
    class Program
    {
        static void Main(string[] args)
        {
            Rad rad;
            do
            {
                Console.WriteLine("Введите данные");
                int grad = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                rad = new Rad(grad, min, sec);
            }
            while (rad.isCorrect == false);
            double totalRad = rad.ToRad();
            Console.WriteLine(totalRad);
            Console.ReadKey();


        }

    }
    class Rad
    {
        int grad;
        int min;
        int sec;
        public bool isCorrect = true;
        public int Grad
        {
            get
            { return grad; }
            set
            {
                if (value > 360 && value < 0)
                    isCorrect = false;
                else
                    grad = value % 360;
            }
        }
        public int Min
        {
            get
            { return min; }
            set
            {
                if (value > 60 && value < 0)
                    isCorrect = false;
                else
                    min = value % 60;
            }
        }
        public int Sec
        {
            get
            { return sec; }
            set
            {
                if (value > 60 && value < 0)
                    isCorrect = false;
                else
                    sec = value % 60;
            }
        }
        public Rad(int grad, int min, int sec)
        {
            this.Grad = grad;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRad()
        {
            return grad + (min + (sec / 60)) / 60;
        }
    }
}
