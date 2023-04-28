using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Models
{
    internal class Employee:Person
    {
        #region props
        private int _workingHour;
        private double _salaryOfHour;
        private double _averageWorkHour;
        public double SalaryOfHour
        {
            get
            {
                return _salaryOfHour;
            }
            set
            {
                if (value > 0)
                {
                    _salaryOfHour = value;
                }
            }
        }
        public int WorkingHour
        {
            get
            {
                return _workingHour;
            }
            set
            {
                if (value > 0 && value <= 240)
                {
                    _workingHour = value;
                }
            }
        }
        public double AverageWorkhour 
        { 
            get 
            {
                return _averageWorkHour;
            } 
            set 
            {
                if (value>0 && value<=8)
                {
                    _averageWorkHour= value;
                }
                else
                {
                    Console.WriteLine("Iscinin ortlama is saati 8-den asaqi ola bilmez");
                }
            } 
        }
        private int _age;
        public override int Age { get => _age; 
            set 
            {
                if (value>0&& value>=18)
                {
                    _age = value;
                }
                
            } 
        }
        #endregion
        #region Contructor
        public Employee(double salaryOfHour, int workingHour, string name, string surname, int age,double averageWorkHour)
        {
            this.SalaryOfHour = salaryOfHour;
            this.WorkingHour = workingHour;
            base.Name = name;
            base.Surname = surname;
            this.Age = age;
            this.AverageWorkhour = averageWorkHour;
        }
        #endregion
        #region Methods
        public void CalculateSalary()
        {
            if (_age >= 18 && _age > 0)
            {
                if (_averageWorkHour>0 && _averageWorkHour<=8 )
                {
                    double salary = _salaryOfHour * _workingHour;
                    if (salary>250)
                    {
                        Console.WriteLine($"{Name} {Surname} ayliq {_workingHour} saat is vaxtina gore ayliq maasi {salary} manatdir");
                    }
                    else
                    {
                        Console.WriteLine("Iscinin maasi 250 manatdan asaqi ola bilmez");
                    }
                }
                else
                {
                    Console.WriteLine("Iscinin ortlama bir gunluk is saati 8-den cox ola bilmez");
                }
            }
            else
            {
                Console.WriteLine("Sizin isleme huqunuz yoxdur");
            }
        } 
        #endregion
    }
}
