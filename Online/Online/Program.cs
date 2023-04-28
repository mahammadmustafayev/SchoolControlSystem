using Online.Models;

namespace Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new(
                 name:"Mehemmed",
                 surname:"Mustafayev",
                 age:17,
                 workingHour:120,
                 salaryOfHour:5,
                 averageWorkHour:8
                );
            employee.CalculateSalary();
            Console.WriteLine(new string('-',30));
            Student student = new(
                 name:"Ali",
                 surname:"Aliyev",
                 age:3,
                 iqRank:50,
                 language:45
                );
            student.ExamResult();
        }
    }
}