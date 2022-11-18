using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class doctorr: vrachi
    {
        string[,] Doctors = new string[5, 4];
        string DoctorName;
        string DoctorSpeciality;
        string DoctorDay;
        long DoctorPhone;
        string DoctorID;
        public doctorr()
        {
            Doctors = new[,]
            {
                {"Люкшин А.Ю.","ветрянка","09122222229","00001","восресенье"},
                {"Миронов Ф.В.","простуда обыкновенная","09121122339","00002","понедельник"},
                {"Фейзуллина Л.О","инфаркт","09364455123","00003","среда"},
                {"Минзянов Р.Л.","коронавирус","09394589631","00004","пятница"},
                {"Листопадова А.В.","воспаление легких","09360000001","00005","суббота"}
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
}
