using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_29._10
{
    public class hospitall : Hospitaltyy
    {
        string[] Insurances = new string[4];
        string[] TypeOfIllness = new string[4];
        string AcceptMessage;
        string FailedMesssage;
        string both;
        string Insurance1;
        public hospitall()
        {
            Insurances = new[] { "легкое заболевание", "телесные повреждения", "утрата трудоспособности", "авария", "онкология" };
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
    }
}
