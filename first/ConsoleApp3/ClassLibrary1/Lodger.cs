using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Lodger
    {
        private string Name;
        private string Phone;
        private static string a1 = "C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Lodger.txt";

        public Lodger(string Name, string Phone)
        {
            this.Name = Name;
            this.Phone = Phone;
            
            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Lodger.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write("\n" + Name + "\n" + Phone + "\n---------------\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }

        public static void InputLodger(ref List<Lodger> lodger, ref List<Owner> owner)
        {
            do
            {
                Console.WriteLine("Просмотреть список квартиросъемщиков - 1, добавить нового - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Files.OpenFile1(a1);
                    Console.WriteLine("Хотите подробную информацию? 1-да, 2-нет");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    if (a3 == 1)
                    {
                        Console.WriteLine("Введите клиента");
                        string dop1 = Console.ReadLine();
                        Owner.dop(ref owner, dop1);
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите имя клиента");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите номер клиента");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите имя клиента");
                    string a1 = Console.ReadLine();
                    lodger.Add(new Lodger(Console.ReadLine(), Console.ReadLine()) { });
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    Console.WriteLine("Введите имя клиента, которого вы хотите удалить:");
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
                    writer.Close();
                }
                if (a == 4) break;
            } while (true);
        }
    }
}
