using System;
using System.Collections.Generic;

namespace TestTask
{
    class Program
    {
        static bool Ok;
        static void Main(string[] args)
        {

            List<string> objects = new List<string> { "Амулет", "33 Монет", "Книгу" };
            Main1(objects);

        }
        static void Main1(List<string> objects)
        {
            Console.Clear();
            Ok = true;
            Console.Write("Осмотр помещения." + '\n' + "Осмотреть стол?" + '\n');
            Check(objects);
        }
        static void Check(List<string> objects)
        {
            string Line;
            Line = Console.ReadLine();
            if ((Line == "Да") || (Line == "Осмотреть стол"))
            {
                Ok = false;
                Conditions(objects);
            }
            else if (Line == "Нет")
            {
                Ok = false;
                Console.Write("Что ж, ваше дело." + '\n' + "До свидания!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
            {
                while (Ok)
                {
                    Console.Write("Попробуйте еще раз." + '\n');
                    Check(objects);
                }
            }
        }
       static void Conditions(List<string> objects)
        {
            if (objects.Count > 0)
            {
                bool ok = true;
                Console.Clear();
                Console.Write("Выберите вариант" + '\n');

                foreach (string word in objects)
                {

                    Console.Write("Подобрать " + word + '\n');
                }
                Console.Write("Отмена" + '\n');

                Conditions1(ok, objects);
            }
            else
            {
                Console.Write("Все предметы в инвентаре" + '\n' + "До свидания!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();

            }

        }
         static void Conditions1(bool ok, List<string> objects)
        {
            string toDo = Console.ReadLine();
            foreach (string word in objects)
            {
                if (toDo == "Отмена")
                {
                    ok = false;
                    Main1(objects);
                }
                else if (toDo == "Подобрать " + word)
                {
                    ok = false;
                    objects.Remove(word);
                    Conditions(objects);
                }
            }
            while (ok)
            {
                Console.Write("Попробуйте еще раз." + '\n');
                Conditions1(ok, objects);
            }
        }

    }
}
