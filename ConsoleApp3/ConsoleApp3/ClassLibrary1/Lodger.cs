using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Lodger:IWritableObject, IReadableObject
    {
        private string Name;
        private string Phone;
        private static string a1 = "Lodger.txt";

        public Lodger(string Name, string Phone, ref List<Lodger> lodger)
        {
            this.Name = Name;
            this.Phone = Phone;
            WriteLine(a1,ref lodger);
            /*FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Lodger.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write("\n" + Name + "\n" + Phone + "\n---------------\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется */
        }

        public Lodger(ILoadManager man)
        {
            Name = man.ReadLine().Split(':')[1];
            Phone = man.ReadLine().Split(':')[1];
            


        }

        public static void InputLodger(ref List<Lodger> lodger)
        {
            do
            {
                Console.WriteLine("Просмотреть список квартиросъемщиков - 1, добавить нового - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Files.OpenFile1(a1);
                   /* Console.WriteLine("Хотите подробную информацию? 1-да, 2-нет");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    if (a3 == 1)
                    {
                        Console.WriteLine("Введите клиента");
                        string dop1 = Console.ReadLine();
                       // Owner.dop(ref owner, dop1);
                    }*/
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите имя клиента");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите номер клиента");
                    string a2 = Console.ReadLine();
                    lodger.Add(new Lodger(a1,a2,ref lodger) { });
                    InputDop(ref lodger);
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    FileStream file1 = new FileStream(a1, FileMode.Create); //создаем файловый поток
                    file1.Close();
                    /*Console.WriteLine("Введите имя клиента, которого вы хотите удалить:");
                    string DeleteAgency = Console.ReadLine();
                    FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Lodger.txt", FileMode.Create); //создаем файловый поток
                    StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                    foreach (Lodger p in lodger)
                    {
                        if (p.Name == DeleteAgency)
                        {
                            lodger.Remove(p);
                            break;
                        }
                        //else { Console.WriteLine("Нет такого человека"); }  
                    }
                    foreach (Lodger p in lodger)
                    {
                        writer.Write("\n" + p.Name + "\n" + p.Phone + "\n---------------"); //записываем в файл
                    }
                    writer.Close();*/
                }
                if (a == 4) break;
            } while (true);
        }

        public void WriteLine(string filename, ref List<Object1> obgect1)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string filename, ref List<Lodger> lodger)
        {
            FileStream file1 = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);

            foreach (Lodger p in lodger)
            {
                writer.Write("Имя:" + p.Name + "\nТелефон:" + p.Phone + "");
            }
            writer.Close();
            file1.Close();
        }

        public static void InputDop(ref List<Lodger> lodger)
        {

            string a1 = "aaa";
            string a2 = " ";


            lodger.Add(new Lodger(a1, a2, ref lodger) { });

            foreach (Lodger p in lodger)
            {
                if (p.Name == "aaa")
                {
                    lodger.Remove(p);
                    break;
                }
            }

        }

        public void Write(ISaveManager man)
        {
            man.WriteLine("Имя:" + Name + "\nТелефон:" + Phone + "");
        }

        public static void view(ref List<Lodger> lodger)
        {
            foreach (Lodger p in lodger)
            {
                Console.Write("Имя:" + p.Name + "\nТелефон:" + p.Phone + "");
            }
        }

        public class Loader : IReadableObjectLoader
        {

            public Loader() { }
            public IReadableObject Load(ILoadManager man)
            {
                return new Lodger(man);
            }

        }
    }
}
