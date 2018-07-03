using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson4_BronashkoAV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Doubler
            Console.WriteLine("Игра удвоитель!");
            Doubler game = new Doubler();
            Random rnd = new Random();
            game.Finish = rnd.Next(1, 101);
            while (game.Current < game.Finish)
            {
                Console.WriteLine($"Ваше число {game.Current}. Вам нужно достигнуть числа {game.Finish}");
                Console.WriteLine("1)Прибавить 1");
                Console.WriteLine("2)Умножить на 2");
                Console.WriteLine("3)Начать заново");
                Console.Write("Вводте: ");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        game.Plus();
                        break;
                    case "2":
                        game.Multi();
                        break;
                    case "3":
                        game.Reset();
                        break;
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
            if (game.Current > game.Finish) Console.WriteLine("YOU LOSE!");
            if (game.Current == game.Finish)
            {
                Console.WriteLine("Вы выиграли!");
                Console.WriteLine($"Вам удалось сделать это за {game.Step} шагов.");
                Console.WriteLine($"Лучший результат {game.BestQuantityStep()} шагов.");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
