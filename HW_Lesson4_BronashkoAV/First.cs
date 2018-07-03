using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson4_BronashkoAV
{
    public class First
    {

        int[] a = new int[20];
        public First()
        {
            Random rnd = new Random();
            for (int i=0;i<a.Length; i++)
            {
                a[i] = rnd.Next(-10001, 10001);
            }
        }
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        public void find()
        {
            int sum = 0;
            for (int k = 1; k < a.Length; k++)
            {
                if (a[k-1] % 3 == 0 || a[k] % 3 == 0) sum++;
            }
            Console.WriteLine(sum);
        }

    }
}
