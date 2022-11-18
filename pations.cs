using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class pations
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
        int Price = 200;

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
        public int Pricсee()
        {
            return Price;
        }
        public void setCuringDay(int cost, string InsuranceResualt)
        {
            if (InsuranceResualt == "Страховка не подходит")
            {
                this.cost = Pricсee() * cost;
            }
            else
            {
                this.cost = (Pricсee() * cost * 50) / 100;
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
}
