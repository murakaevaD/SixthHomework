using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class hospital
    {
        string[] Insurances = new string[4];
        string[] TypeOfIllness = new string[4];
        string AcceptMessage;
        string FailedMesssage;
        string both;
        string Insurance1;

        int Price;
        public hospital()
        {
            Insurances = new[] { "Легкое заболевание", "Телесные повреждения", "Утрата трудоспособности", "Авария", "Онкология" };
            Price = 200;
            TypeOfIllness = new[] { "ветрянка", "простуда обыкновенная", "инфаркт", "коронавирус", "воспаление легких" };
            AcceptMessage = "Пациент принят";
            FailedMesssage = "Пациент не принят,обратитесь в другую больницу";

            both = FailedMesssage;
        }

        public void setSearchIll(string Ill)
        {

            for (int i = 0; i < 4; i++)
                if (Ill == TypeOfIllness[i])
                {
                    both = AcceptMessage;

                    break;

                }
        }

        public string getSearchIll()
        {
            return both;
        }

        public void setSearchInsurance(string Insurance2)
        {
            string Insurance = "Страховка подходит";
            Insurance1 = "Страховка не подходит";

            for (int i = 0; i < 4; i++)
            {
                if (Insurance2 == Insurances[i])
                {
                    Insurance1 = Insurance;
                    continue;
                }
            }
        }
        public string getSearchInsurance()
        {
            return Insurance1;
        }
        public int Pricсee()
        {
            return Price;
        }
    }
        public class doctor : hospital
    {
        string[,] Doctors = new string[5, 4];
        string DoctorName;
        string DoctorSpeciality;
        string DoctorDay;
        long DoctorPhone;
        string DoctorID;
        public doctor()
        {
            Doctors = new[,] 
            {
                {"Люкшин А.Ю.","инфекционист","09122222229","00001","восресенье"},
                {"Миронов Ф.В.","терапевт","09121122339","00002","понедельник"},
                {"Фейзуллина Л.О","невролог","09364455123","00003","среда"},
                {"Минзянов Р.Л.","вирусолог","09394589631","00004","пятница"},
                {"Листопадова А.В.","лор","09360000001","00005","суббота"}
            };

        }
        public void setDoctorSpeciality(string Illness)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Illness == Doctors[j, 1])
                {
                    DoctorName = Doctors[j, 0];
                    DoctorSpeciality = Doctors[j, 1];
                    DoctorPhone = long.Parse(Doctors[j, 2]);
                    DoctorID = Doctors[j, 3];
                    DoctorDay = Doctors[j, 4];
                    break;
                }
                else
                    continue;
            }
        }
        public string getDoctorName()
        {
            return DoctorName;
        }
        public string getDoctorSpeciality()
        {
            return DoctorSpeciality;
        }
        public long getDoctorPhone()
        {
            return DoctorPhone;
        }
        public string getDoctorID()
        {
            return DoctorID;
        }
        public string getDoctorRecept()
        {
            return DoctorDay;
        }

    }
    public class pationt : doctor
    {
        Random PationtID1;

        string HistoryOfDisease;
        string RecentDisease;
        string TypeOfInsurance;
        string Name;
        long PhoneNumber;
        int PationtID;
        int cost;
        int Age;

        string generation1;

        public void setGeneration(bool Generation)
        {
            if (Generation == true)
                generation1 = "Жен";
            else
                generation1 = "Муж";
        }

        public string getGeneration()
        {
            return generation1;
        }

        public void setHistoryOfDisease(string HistoryOfDisease)
        {

            this.HistoryOfDisease = HistoryOfDisease;
        }

        public string getHistoryOfDisease()
        {
            return HistoryOfDisease;
        }

        public void setRecentDisease(string RecentDisease)
        {
            this.RecentDisease = RecentDisease;
        }

        public string getRecentDisease()
        {
            return RecentDisease;
        }

        public void setTypeOfInsurenc(string insurenc)
        {
            TypeOfInsurance = insurenc;
        }

        public string getTypeOfInsurenc()
        {
            return TypeOfInsurance;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return Name;
        }

        public void setPhoneNumber(long PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public long getPhoneNumber()
        {
            return PhoneNumber;
        }

        public void setPationtID()
        {
            PationtID1 = new Random();
            PationtID = PationtID1.Next(10000, 20000);

        }
        public int getPationtID()
        {
            return PationtID;
        }
        public void setCuringDay(int cost, string InsuranceResualt)
        {
            if (InsuranceResualt == "Страховка не подходит")
            {
                this.cost = Pricсee() * cost;
            }
            else
            {
                this.cost = (Pricсee() * cost * 50 / 100);
            }
        }

        public int getCuringDay()
        {
            return cost;
        }
        public void setAge(int Age)
        {
            this.Age = Age;
        }

        public int getAge()
        {
            return Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string Diease;
            string RecentDiease;
            string Insurance;
            string Name;
            long PhoneNumber;
            int Generation;
            int cost;
            int Age;
            int pationts;
            int i;

            Console.WriteLine("Добро пожаловать в больницу №56");

            Console.Write("Сколько пациентов хотите записать на прием : ");
            pationts = int.Parse(Console.ReadLine());
            string[] Insurances = new string[pationts];
            pationt[] Pationt = new pationt[pationts];
            hospital[] Hospital = new hospital[pationts];
            doctor[] Doctor = new doctor[pationts];
            for (i = 0; i < pationts; i++)
            {
                if (i > pationts - 1)
                    break;

                Pationt[i] = new pationt();
                Hospital[i] = new hospital();
                Doctor[i] = new doctor();

                Console.WriteLine("Пациент номер " + (i + 1));

                Console.WriteLine("--------");
                Console.Write("Введите имя : ");
                Name = Console.ReadLine();
                Pationt[i].setName(Name);

                Console.Write("Введите пол : ");
                Console.Write("       1.Муж   ");
                Console.WriteLine("2.Жен");
                Generation = int.Parse(Console.ReadLine());
                if (Generation == 1)
                    Pationt[i].setGeneration(false);
                else
                    Pationt[i].setGeneration(true);

                Console.Write("Введите возраст : ");
                Age = int.Parse(Console.ReadLine());
                Pationt[i].setAge(Age);

                Console.Write("Введите номер телефона : ");
                PhoneNumber = long.Parse(Console.ReadLine());
                Pationt[i].setPhoneNumber(PhoneNumber);

                Console.Write("Введите историю заболеваний : ");
                Diease = Console.ReadLine();
                Pationt[i].setHistoryOfDisease(Diease);

                Console.Write("Что беспокоит на данный момент : ");
                RecentDiease = Console.ReadLine();
                Pationt[i].setRecentDisease(RecentDiease);

                Doctor[i].setDoctorSpeciality(RecentDiease);

                Hospital[i].setSearchIll(RecentDiease);
                Console.WriteLine(Hospital[i].getSearchIll());

                if (Hospital[i].getSearchIll() == "Пациент принят")
                {

                    Console.Write("Введите тип страховки : ");
                    Insurance = Console.ReadLine();
                    Pationt[i].setTypeOfInsurenc(Insurance);

                    Hospital[i].setSearchInsurance(Insurance);
                    Console.WriteLine(Hospital[i].getSearchInsurance());

                    Insurances[i] = Hospital[i].getSearchInsurance();

                    Console.WriteLine("-------");
                    Pationt[i].setPationtID();
                    Console.WriteLine("1.ID пациента : " + Pationt[i].getPationtID());
                    Console.WriteLine("2.Имя: " + Pationt[i].getName());
                    Console.WriteLine("3.Возраст: " + Pationt[i].getAge());
                    Console.WriteLine("4.Номер телефона: " + Pationt[i].getPhoneNumber());
                    Console.WriteLine("5.История болезней: " + Pationt[i].getHistoryOfDisease());
                    Console.WriteLine("6.Заболевание на данный момент:" + Pationt[i].getRecentDisease());
                    Console.WriteLine("7.Вид страховки: " + Pationt[i].getTypeOfInsurenc());
                    Console.WriteLine("--------");
                    Console.WriteLine("Информация о вашем докторе: ");
                    Console.WriteLine("1.ФИО: " + Doctor[i].getDoctorName());
                    Console.WriteLine("2.Специализация: " + Doctor[i].getDoctorSpeciality());
                    Console.WriteLine("3.Номер телефона: " + Doctor[i].getDoctorPhone());
                    Console.WriteLine("4.ID доктора: " + Doctor[i].getDoctorID());
                    Console.WriteLine("5.День приема:" + Doctor[i].getDoctorRecept());
                    Console.WriteLine("--------");
                    cost = 200;
                    Pationt[i].setCuringDay(cost, Insurances[i]);
                    Console.WriteLine("Стоимость лечения: " + Pationt[i].getCuringDay() + " рублей");

                    if (pationts == 1)
                        break;
                    if (pationts > 1)
                        continue;

                }
            }
            Console.WriteLine("Спасибо за обращение,до свидания!");
        }
    }
}
