using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_Lesson4_BronashkoAV
{
    class Second
    {
        int[] a;
        public Second(int n)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-10001, 10001);
            }

        }
        public Second(int n, int start, int step)
        {
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = start + step * i;
            }
        }
        public Second(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    a[i] = int.Parse(ss[i]);
                }
                sr.Close();
            }
        }
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int el in a)
                {
                    sum += el;
                }
                return sum;
            }
        }
        public int Lenght
        {
            get
            {
                return a.Length;
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                a[i] = -a[i];
                Console.WriteLine(a[i]);
            }
        }
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                a[i] *= x;
                Console.WriteLine(a[i]);
            }
        }
        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (int i in a)
            {
                sw.WriteLine(i);
            }
            sw.Close();
        }
    }
}
