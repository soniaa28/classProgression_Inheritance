using System.Numerics;

namespace classProgressionInheritance
{
    public class Program
    {
        static void AddToCollection(List<Progression> p)
        {
            Console.WriteLine("Яку прогресію бажаєте додати до колекції ? Натисніть '1' - для арифметичної або '2' для геометричної");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Щоб додати нову арифметичну прогресію введіть її перший член ,знаменник та кількість членів через пробіл");
                    string[] prog = Console.ReadLine().Split(" ");
                    ArithmeticProgression newA = new(double.Parse(prog[0]), double.Parse(prog[1]), int.Parse(prog[2]));
                    p.Add(newA);
                    break;
                case "2":
                    Console.WriteLine("Щоб додати нову геометричну прогресію введіть її перший член ,знаменник та кількість членів через пробіл");
                    string[] prog1 = Console.ReadLine().Split(" ");
                    GeomProgression newG = new(double.Parse(prog1[0]), double.Parse(prog1[1]), int.Parse(prog1[2]));
                    p.Add(newG);
                    break;

            }
            Console.WriteLine("Прогресія успішно додана до колекції.");
        }

        static void PrintCollection(List<Progression> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine(string.Format("Прогресія №{0} : {1} ", i + 1, p[i].ToString()));
            }
        }
        static string getTypeP(Progression p)
        {
            if(p is ArithmeticProgression)
            {
                return "Арифметична";
            }
            else
            {
                return "Геометрична";
            }
        }

        static void FindMaxProgression(List<Progression> p)
        {
            double max_sum = 0;
            int index = 0;
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].getSumOfAll() > max_sum)
                {
                    max_sum = p[i].getSumOfAll();
                    index = i;
                }
            }
           
            Console.WriteLine(String.Format("{0} прогресія №{1} має найбільшу суму елементів - {2}а саме = {3}", getTypeP(p[index]), index + 1, p[index], p[index].getSumOfAll()));
        }
        static void SetNCollection(List<Progression> p, int _n)
        {
            for (int i = 0; i < p.Count; i++)
            {
                p[i].N = _n;
            }
            }

        static void CreateCollectionFromQ(List<Progression> p)
        {
            List<double> newL = new List<double>();
            for(int i = 0; i < p.Count; i++)
            {
                if (p[i] is ArithmeticProgression)
                {
                    continue;
                }
                else
                {
                    newL.Add(p[i].Inc);
                }
            }
            Console.Write("Нова колекція зі знаменників геометричних прогресій : ");
            for (int i = 0; i < newL.Count; i++)
            {
                Console.Write(string.Format("{0} ", newL[i]));
            }
        }

        
     
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ArithmeticProgression a1 = new ArithmeticProgression(1, 2, 5);
            ArithmeticProgression a2 = new ArithmeticProgression(0, 3, 7);
            ArithmeticProgression a3 = new ArithmeticProgression(1, 5, 3);
           
            //Console.WriteLine(String.Format("отримана прогресія : {0}", a1 + a2)); //testing operator +

            GeomProgression g1 = new GeomProgression(1, 3, 5);
            GeomProgression g2 = new GeomProgression(1, 2, 10);
            GeomProgression g3 = new GeomProgression(1, 4, 7);
            //Console.WriteLine(String.Format("отримана прогресія : {0}", g1 + g2)); //testing operator +


            List<Progression> collection = new List<Progression>() { a1, a2, a3, g1, g2, g3 };
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(string.Format("Прогресія № {0} : {1} ", i + 1, collection[i].ToString()));
            }

            void Menu()
            {
                bool _continue = true;
                while (_continue)
                {
                    Console.WriteLine("\nОберіть один з варіантів,натиснувши відповідну цифру на клавіатурі :");
                    Console.WriteLine("1.Додати нову прогресію.");
                    Console.WriteLine("2.Надрукувати всі прогресії.");
                    Console.WriteLine("3.Знайти найбільшу прогресію(за сумою чисел).");
                    Console.WriteLine("4.Задати кількість членів усім прогресіям з колекції.");
                    Console.WriteLine("5.Створити колекцію зі знаменників геометричної прогресії.");
                    Console.WriteLine("6.Порівняти дві прогресії з колекції за сумою всіх їхніх членів.");//override operator >/<
                    Console.WriteLine("7.Посортувати та надрукувати прогресії  за кількістю  їхніх членів."); //IComparer
                    Console.WriteLine("8.Посортувати та надрукувати прогресії за величиною їхнього інкременту.");//IComparer
                    Console.WriteLine("9.Форматований вивід.");//IFormattable
                    Console.WriteLine("10.Вийти.Та перейти до завдання №4");

                    string menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            AddToCollection(collection);
                            break;
                        case "2":
                            PrintCollection(collection);
                            break;
                        case "3":
                            FindMaxProgression(collection);
                            break;
                        case "4":
                            Console.WriteLine("Введіть бажане число : ");
                            int _n = int.Parse(Console.ReadLine());
                            SetNCollection(collection,_n);
                            break;
                        case "5":
                            CreateCollectionFromQ(collection);
                            break;
                        case "6":
                            Console.WriteLine("Введіть індекси прогресій, які ви хочете порівняти за сумою");
                            string[] choices = Console.ReadLine().Split(" ");
                            Console.WriteLine(String.Format("Прогресія з індексом {0} більша за прогресію {1} : {2}", choices[0], choices[1], collection[int.Parse(choices[0])-1] > collection[int.Parse(choices[1])-1] ));
                            break;
                        case "7":
                            ProgressionComparingbyN sortN = new ProgressionComparingbyN();
                            collection.Sort(sortN);
                            for (int i = 0; i < collection.Count; i++)
                            {
                                Console.WriteLine("BYM1 format : {0,30:BYM1} ", collection[i]);
                            }
                            break;

                        case "8":
                            ProgressionComparingbyIncrement sortInc = new ProgressionComparingbyIncrement();
                            collection.Sort(sortInc);
                            for (int i = 0; i < collection.Count; i++)
                            {
                                Console.WriteLine("BYM1 format : {0,30:BYM1} ", collection[i]);
                            }
                            break;

                        case "9":
                            Console.WriteLine("Введіть індекс прогресії, яку бажаєте надрукувати у форматі");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine("BYM1 format : {0,30:BYM1}", collection[index - 1]);
                            break;
                        case "10":
                        default:
                            _continue = false;
                            break;

                    }
                }
            }

            Menu();

             

            GeomProgression gProgression = new GeomProgression(1, 2, 10);
            GlobalProgression globalProgression = new GlobalProgression(1,1,100);

            Console.WriteLine("Task 4 \n");

            gProgression.ProgressionEvent += globalProgression.HandleEvent;
            Console.WriteLine("Прогресія до перетворень : " + gProgression);
            gProgression.Inc = 6;
            Console.WriteLine("Прогресія після перетворень : " + gProgression);

            Console.WriteLine(" \n");
            ArithmeticProgression aProgression = new ArithmeticProgression(1, 5, 10);
            Console.WriteLine("Прогресія до перетворень : " + aProgression);
            aProgression.SumEvent += globalProgression.HandleSumEvent;
            Console.WriteLine(aProgression.getSumOfAll());
            Console.WriteLine("Прогресія після перетворень : " + aProgression);

        }
    }
}
