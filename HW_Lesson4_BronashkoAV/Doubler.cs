using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson4_BronashkoAV
{
    class Doubler
    {
        private int current=1; //Текущее значение
        private int finish; //число, которого нужно достичь
        private int step = 0; //число шагов

        public void Plus()
        {
            current++;
            step++;
        }
        public void Multi()
        {
            current *= 2;
            step++;
        }
        public void Reset()
        {
            current = 1;
            step = 0;
        }

        public int Current
        {
            get { return current; }
        }
        public int Finish
        {
            get { return finish; }
            set { finish = value; }
        }
        public int Step
        {
            get { return step; }
        }
        public int BestQuantityStep()
        {
            int bestStep=0;
            int temp=finish;
            while (temp != 1)
            {
                temp = (temp % 2 == 0) ? temp / 2 : temp - 1;
                bestStep++;
            }
            return bestStep;
        }
    }
}
