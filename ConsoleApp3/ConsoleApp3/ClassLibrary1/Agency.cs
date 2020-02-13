using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Agency: IWritableObject, IReadableObject
    {
        private string Name;
        //private static string Name2 = Name2;
        private string Phone { get; set; }
        private string Adress { get; set; }
        private static string a1 = "Agency.txt";
        public Agency(string Name, string Phone, string Adress,ref List<Agency> agency)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Adress = Adress;
            WriteLine(a1,ref agency);
            /*FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write("\n" + Name + "\n" + Phone + "\n" + Adress + "\n---------------\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется */
        }

        public Agency(ILoadManager man)
        {
            Name = man.ReadLine().Split(':')[1];
            Phone = man.ReadLine().Split(':')[1];

            Adress = man.ReadLine().Split(':')[1];


        }

        // public static string getName() { return Name2; }
        // public static string getPhone() { return Name; }
        //public static string getName() { return Name; }
        /* public static void OpenFile1(string a)
         {
             FileStream file = new FileStream(a, FileMode.Open); //открывает файл только на чтение
             StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком 
             StreamReader reader2 = new StreamReader(file);

             Console.WriteLine(reader.ReadToEnd());
             if (reader.ReadToEnd() == "")
             {
                 Console.WriteLine("Пусто");

             }
             else Console.WriteLine(reader2.ReadToEnd());
             reader.Close();
             reader2.Close();
         }*/

        public static void InputAgency(ref List<Agency> agency)
        {
            do
            {
                Console.WriteLine("Просмотреть список агенств - 1, добавить новое - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    view(ref agency);
                   //Files.OpenFile1(a1);
                   /* Console.WriteLine("Хотите подробную информацию? 1-да, 2-нет");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    if (a3 == 1)
                    {
                        Console.WriteLine("Введите Агенство");
                        string dop1 = Console.ReadLine();
                        //Owner.dop(ref owner, dop1);
                    }*/
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите Наименование:");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите номер телефона:");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите адресс агенства:");
                    string a3 = Console.ReadLine();
                    agency.Add(new Agency(a1,a2,a3,ref agency));
                    InputDop(ref  agency);
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    FileStream file1 = new FileStream(a1, FileMode.Create);
                    file1.Close();
                    /* Console.WriteLine("Введите Название агенства, которое вы хотите удалить:");
                     string DeleteAgency = Console.ReadLine();
                     FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt", FileMode.Create); //создаем файловый поток
                     StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                     foreach (Agency p in agency)
                     {
                         if (p.Name == DeleteAgency)
                         {
                             agency.Remove(p);
                             break;
                         }
                         //else { Console.WriteLine("Нет такого человека"); }  
                     }
                     foreach (Agency p in agency)
                     {
                         writer.Write("\n" + p.Name + "\n" + p.Phone + "\n" + p.Adress + "\n---------------"); //записываем в файл
                     }
                     writer.Close();*/
                }
                if (a == 4) break;
            } while (true);
        }

       
        public void WriteLine(string filename, ref List<Agency> agency)
        {
            FileStream file1 = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);

            foreach (Agency p in agency)
            {
                writer.Write("Название:" + p.Name + "\nТелефон:" + p.Phone + "\nАдресс:"+p.Adress+"");
            }
            writer.Close();
            file1.Close();
        }

        public static void InputDop(ref List<Agency> agency)
        {

            string a1 = "aaa";
            string a2 = " ";
            string a3 = " ";
            agency.Add(new Agency(a1, a2, a3, ref agency) { });

            foreach (Agency p in agency)
            {
                if (p.Name == "aaa")
                {
                    agency.Remove(p);
                    break;
                }
            }

        }

        public void Write(ISaveManager man)
        {
            man.WriteLine("Название:" + Name + "\nТелефон:" + Phone + "\nАдресс:" + Adress + "");
        }

        public static void view(ref List<Agency> agency)
        {
            foreach (Agency p in agency)
            {
                Console.WriteLine("Название:" + p.Name + "\nТелефон:" + p.Phone + "\nАдресс:" + p.Adress + "");
            }
        }

        public class Loader : IReadableObjectLoader
        {

            public Loader() { }
            public IReadableObject Load(ILoadManager man)
            {
                return new Agency(man);
            }

        }
    }
}
