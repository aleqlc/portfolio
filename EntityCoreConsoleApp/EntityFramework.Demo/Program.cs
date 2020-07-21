using System;

namespace EntityFramework.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext("Data Source=DESKTOP-A5HOU30;Initial Catalog=TimeManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            var provider = new EmployeeProvider(context);
            var employee = provider.Get(1);
            Console.WriteLine($"Welcome {employee.FirstName} {employee.LastName}");

            //수정
            var repo = new EmployeeRepo(context);
            var employee1 = provider.Get(2);
            employee1.FirstName = "NewFirst";
            repo.Update(employee1);

            //삭제
            /*var repo = new EmployeeRepo(context);
            var employee1 = provider.Get(2);
            repo.Delete(employee1);*/
        }
    }
}
