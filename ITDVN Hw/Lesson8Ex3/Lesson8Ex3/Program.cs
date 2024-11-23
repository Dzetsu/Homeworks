using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            accauntant.Checker();
        }
    }

    class Accauntant
    {
        private bool AskForBonus(Post worker, int hours)
        {
            switch (worker)
            {
                case Post.Sweaper:
                    if (hours > (byte)Post.Sweaper)
                        return true;
                    else return false;
                case Post.Meneager:
                    if (hours > (byte)Post.Meneager)
                        return true;
                    else return false;
                case Post.Administrator:
                    if (hours > (byte)Post.Administrator)
                        return true;
                    else return false;
                case Post.Director:
                    if (hours > (byte)Post.Director)
                        return true;
                    else return false;
                case Post.Owner:
                    if (hours > (byte)Post.Owner)
                        return true;
                    else return false;
                default:
                    Console.WriteLine("Нет такой должности.");
                    return false;
            } 
        }
        public void Checker()
        {
            for (int i = 75; i < 155; i += 10)
            {
                Console.WriteLine("Уборщик имеет зарплату: " + AskForBonus(Post.Sweaper, i));
                Console.WriteLine("Менеджер имеет зарплату: " + AskForBonus(Post.Meneager, i));
                Console.WriteLine("Администратор имеет зарплату: " + AskForBonus(Post.Administrator, i));
                Console.WriteLine("Директор имеет зарплату: " + AskForBonus(Post.Director, i));
                Console.WriteLine("Владелец имеет зарплату: " + AskForBonus(Post.Owner, i));
                Console.WriteLine(new string('-', 30));
            }
        }

    }

    enum Post
    {
        Sweaper = 80,
        Meneager = 100,
        Administrator = 120,
        Director = 140,
        Owner = 0
    }
}
