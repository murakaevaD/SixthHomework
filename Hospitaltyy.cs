using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class Hospitaltyy
    {
        public void Information()
        {
            Console.WriteLine("Вас интересует какая-либо информация о больнице?");
            Console.WriteLine("1: Да");
            Console.WriteLine("2: Нет");
            int userChoose;
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            while (userChoose == 1)
            {
                Console.WriteLine("Вы можете узнать:");
                Console.WriteLine("1.Список документов, необходимых для приема");
                Console.WriteLine("2.Расписание");
                Console.WriteLine("3.Услуги для пациентов");
                if (!int.TryParse(Console.ReadLine(), out userChoose))
                {
                    Console.WriteLine("Вы ввели неправильно");
                }
                if (userChoose == 1)
                {
                    Console.WriteLine("Список документов:");
                    Console.WriteLine("На приеме необходимо иметь: 1.Паспорт\n2.Полис\n3.Карта заболеваний");
                }
                else if (userChoose == 2)
                {
                    Console.WriteLine("Расписание:");
                    Console.WriteLine("Больница работает ежедневно круглосуточно без выходных и перерывов");
                }
                else if (userChoose == 3)
                {
                    Console.WriteLine("Услуги для пациентов:");
                    Console.WriteLine("1.Первичный прием,консультация\n2.Сдача анализов\n3.Лечение");
                }
            }
            Console.WriteLine("нет так нет");
        }
    }
}
