using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymNa_29._10
{
    enum Bank
    {
        Текущий,
        Cберегательный
    }
    class Bankk
    {
        private int numb;
        private int numb2;
        private int balance;
        private Bank name;

        public void Name()
        {
            Console.WriteLine("С каким счетом хотите работать: " + '\n' + "сберегательный или текущий ");
            string name1 = Console.ReadLine();
            if (name1 == "сберегательный")
            {
                Console.WriteLine("Вы выбрали " + Bank.Cберегательный + " счёт");
            }
            else if (name1 == "текущий")
            {
                Console.WriteLine("Вы выбрали " + Bank.Текущий + " счёт");
            }
            else
            {
                Console.WriteLine("Данные введены неверно");
            }
        }
        public void Numb()
        {
            Console.WriteLine("Введите номер счета : ");
            numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер вашего счета : " + numb);
        }
        public void Numb2()
        {
            Random random = new Random();
            numb2 = random.Next();
            Console.WriteLine("Номер вашего счета: " + numb2);
        }
        public void Balance()
        {
            Console.WriteLine("Выберите дальнейшее действие: " + '\n' + "узнать баланс или пополнить баланс");
            string what = Console.ReadLine();
            if (what == "узнать баланс")
            {
                int balance1 = 20000;
                Console.WriteLine("Ваш баланс : " + balance1);
            }

            if (what == "пополнить баланс")
            {
                Console.Write("Введите сумму ,которую хотели бы внести на счет: ");
                int sum = int.Parse(Console.ReadLine());
                int balance2 = 20000 + sum;
                Console.WriteLine("Вы внесли " + sum + " на счет. Ваш баланс сейчас составляет: " + balance2);
            }
        }
        public void Th()
        {
            Console.WriteLine("Какую сумму хотите снять?: ");
            int s = int.Parse(Console.ReadLine());
            int balanc = 20000;
            if (balanc < s)
            {
                Console.WriteLine("Недостаточно средств на счете");
                Balance();

            }
            else
            {
                Console.WriteLine("После снятия средств на балансе осталось : " + (balanc - s));
            }
        }
    }
    class House
    {
        private int height;
        private int floors;
        private int flats;
        private int entrances;
        private int number;
        public House(int height, int floors, int flats, int entrances)
        {
            this.height = height;
            this.floors = floors;
            this.flats = flats;
            this.entrances = entrances;
        }
        public void Number()
        {
            Random rnd = new Random();
            number = rnd.Next();
            Console.WriteLine("Уникальный номер дома:" + number);
        }
        public void HeF()
        {
            Console.WriteLine("Высота одного этажа равна: " + height / floors);
        }
        public void Fl()
        {
            Console.WriteLine("Количество квартир в подъезде: " + flats / entrances);
        }
        public void fl()
        {
            Console.WriteLine("Количество квартир на этаже: " + flats / floors);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            Bankk bank = new Bankk();
            bank.Name();
            bank.Numb();
            bank.Balance();

            Console.WriteLine("Упражнение 7.2");
            Bankk bank1 = new Bankk();
            bank1.Name();
            bank1.Numb2();
            bank1.Balance();

            Console.WriteLine("Упражнение 7.3");
            Bankk bank2 = new Bankk();
            bank2.Name();
            bank2.Numb2();
            bank2.Th();

            Console.WriteLine("ДЗ 7.1");
            Console.Write("Введите высоту дома: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите количество этажей во всем доме: ");
            int floors = int.Parse(Console.ReadLine());
            Console.Write("Введите количество квартир во всем доме: ");
            int flats = int.Parse(Console.ReadLine());
            Console.Write("Введите количество подъездов во всем доме: ");
            int entrances = int.Parse(Console.ReadLine());
            House build = new House(height, floors, flats, entrances);
            build.Number();
            build.HeF();
            build.Fl();
            build.fl();
        }
    }
}
