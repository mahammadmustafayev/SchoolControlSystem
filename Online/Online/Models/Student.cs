using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Models
{
    internal class Student:Person
    {
        #region Properties
        private int _age;
        private int _iqRank;
        private int _languageRank;
        public int IQRank
        {
            get => _iqRank;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _iqRank = value;
                }
            }
        }
        public int LanguageRank
        {
            get => _languageRank;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _languageRank = value;
                }
            }
        }
        public override int Age
        {
            get => _age;
            set
            {
                if (value >= 6 && value <= 20)
                {
                    _age = value;
                }
                
            }
        }
        #endregion
        public Student(string name,string surname,int age,int iqRank,int language)
        {
            base.Name = name;
            base.Surname = surname;
            this.Age = age;
            this.IQRank= iqRank;
            this.LanguageRank= language;
        }
        public void ExamResult()
        {
            if (_age>=6 && _age<=20)
            {
                int resut = _iqRank + _languageRank;
                if (resut >= 120)
                {
                    Console.WriteLine($"Tebrikler {Name} {Surname} Siz Iq imtahanindan-{_iqRank}," +
                        $"Dil imtahanindan-{_languageRank} alaraq imtahanlardan kecdiniz");
                }
                else
                {
                    Console.WriteLine($"{Name} {Surname} siz Iq ve Dil imtahanlarindan kecid ucun lazim olan 120 bali toplaya bilmediniz");
                }
            }
            else
            {
                Console.WriteLine("Bu telebenin yasi mektebde oxumaq ucun yeterli deyil");
            }
        }
    }
}
