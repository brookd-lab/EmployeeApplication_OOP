using EmployeeComponent;
using EmployeeComponent.Data;
using EmployeeComponent.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Threading;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            //    var serviceProvider = new ServiceCollection()
            //        .AddLogging()
            //          .AddDbContext<ApplicationDbContext>(
            //options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"))
            //        .AddScoped<IEmployeeRepository, EmployeeRepository>()
            //        .BuildServiceProvider();

            //    //do the actual work here
            //    var repository = serviceProvider.GetService<IEmployeeRepository>();

            Employees employees = new Employees();
         
            ViewAll view = new ViewAll(employees);

            Console.WriteLine(DisplayText.DisplayMenuOptions());

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                view.RunViewAll();

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(DisplayText.DisplayMenuOptions());

                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.A:
                        CreateView createView = EmployeeFactory.EmployeeCreateViewObject(employees);
                        createView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        ReadView readView = EmployeeFactory.EmployeeReadViewObject(employees);
                        readView.RunReadView();
                        break;
                    case ConsoleKey.U:
                        UpdateView updateView = EmployeeFactory.EmployeeUpdateViewObject(employees);
                        updateView.RunUpdateView();
                        break;
                    case ConsoleKey.D:
                        DeleteView deleteView = EmployeeFactory.EmployeeDeleteViewObject(employees);
                        deleteView.RunDeleteView();
                        break;

                    default:
                        exit = true;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
