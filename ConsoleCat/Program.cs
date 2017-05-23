using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день. Какого возраста кошку вы хотите? Укажите возраст в годах.");
            string age = Console.ReadLine();
            Cat cat = new Cat(age, 5);
            CatColor col = new CatColor("Белый","Зелёный");
            cat.Color = col;
            Console.Clear();
            while (true)
            {
                try
                {
                    if (cat.Name == null)
                    {
                        Console.WriteLine("Имя кошки:Не задано\nВозраст:{0}\nЦвет:{1}", cat.Age, cat.CurrentColor());
                    }
                    else
                    {
                        Console.WriteLine("Имя кошки:{0}\nВозраст:{1}\nЦвет:{2}", cat.Name, cat.Age, cat.CurrentColor());
                    }
                    Console.WriteLine("Что будем  делать?\n 1)Назвать 2)Покрасить  3)Покормить  4)Пнуть  5)Выйти");
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("Новое имя: ");
                            string name = Console.ReadLine();
                            cat.Name = name;
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Цвет: 1)Белый 2)Рыжий 3)Чёрный");
                            int color = int.Parse(Console.ReadLine());
                            switch (color)
                            {
                                case 1:
                                    cat.Color.HeathyColor = "Белый";
                                    Console.Clear();
                                    break;
                                case 2:
                                    cat.Color.HeathyColor = "Рыжий";
                                    Console.Clear();
                                    break;
                                case 3:
                                    cat.Color.HeathyColor = "Чёрный";
                                    Console.Clear();
                                    break;
                            }
                            break;
                        case 3:
                            cat.Feed();
                            Console.Clear();
                            break;
                        case 4:
                            cat.Punish();
                            Console.Clear();
                            break;
                        case 5:
                            return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: у кошки уже есть имя");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}
