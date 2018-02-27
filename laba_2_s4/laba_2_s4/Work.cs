using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace laba_2_s4
{
    public class Work
    {
        public string company;
        public string position;
        public int experience;
        public List<string> type_of_work;

        public Work()
        {
            company = "unknown";
            position = "unknown";
            experience = 0;

        }
        public Work(string company, string position, int experience, List<string> type_w)
        {
            this.company = company;
            this.position = position;
            this.experience = experience;
            this.type_of_work = type_w;
        }
        public override string ToString()
        {
            string type = "";
            int count = 0;
            foreach (string s in type_of_work)
            {
                type += s;
                if (count != 0)
                {
                    type += ", ";
                }
                count++;
            }
            return "Company: " + company + "; Position: " + position + "; Experience: " + experience + "; Type: " + type;
        }
    }
}
