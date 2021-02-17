using RazorPages_TestProject_HelemaalOpnieuwMaken.Models;
using System;
using System.Linq;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Data
{
    public class DbInitializer
    {
        public static void Initialize(RepairOrderDbContextCollection context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.RepairOrders.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer{ID=1, Name="Carson Alexander", Emailadress="CarsonAlexander@gmail.com", PhoneNumber= 0612345671},
                new Customer{ID=2, Name="Meredith Alonso", Emailadress="MeredithAlonso@gmail.com", PhoneNumber= 0612345672},
                new Customer{ID=3, Name="Arturo Anand", Emailadress="ArturoAnand@gmail.com", PhoneNumber= 0612345673},
                new Customer{ID=4, Name="Gytis Barzdukas", Emailadress="GytisBarzdukas@gmail.com", PhoneNumber= 0612345674},
                new Customer{ID=5, Name="Yan Li", Emailadress="YanLi@gmail.com", PhoneNumber= 0612345675},

            };

            context.Customers.AddRange(customers);
            context.SaveChanges();

            var employees = new Employee[]
            {
                new Employee{EmployeeID=1, Name="Gekke Henkie", Emailadress="GekkeHenkie@gmail.com", PhoneNumber= 0601234561, Address="Sesamstraat 14", Postalcode="1234AB"},
                new Employee{EmployeeID=2, Name="Jaap Jaapie", Emailadress="JaapJaapie@gmail.com", PhoneNumber= 0601234562, Address="Appelsap 13", Postalcode="5678AB"},
                new Employee{EmployeeID=3, Name="John Johnsen", Emailadress="John Johnsen@gmail.com", PhoneNumber= 0601234563, Address="Hogeboomstraat 2", Postalcode="1234CD"},
                new Employee{EmployeeID=4, Name="Milan Milanie", Emailadress="Milan Milanie@gmail.com", PhoneNumber= 0601234564, Address="Coolsingel 154", Postalcode="5678CD"},
                new Employee{EmployeeID=5, Name="Coole Henkie", Emailadress="CooleHenkie@gmail.com", PhoneNumber= 0601234565, Address="Vogelstraat 5", Postalcode="1234EF"},

            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

            var parts = new Part[]
            {
                new Part{PartID= 1, PartName="Razor Super RGB", PartType=PartType.Motherboard, PartPrice= 200},
                new Part{PartID= 2, PartName="Corsair Gaming Case", PartType=PartType.Case, PartPrice= 150},
                new Part{PartID= 3, PartName="Toshiba Desktop PC", PartType=PartType.Desktop_PC, PartPrice= 600},
                new Part{PartID= 4, PartName="Mad Catz Gaming Mouse", PartType=PartType.Mouse, PartPrice= 120},
                new Part{PartID= 5, PartName="GTX Super Duper 2050", PartType=PartType.Graphics_card, PartPrice= 500},
            };

            context.Parts.AddRange(parts);
            context.SaveChanges();


            var repairOrders = new RepairOrder[]
            {
                new RepairOrder{RepairOrderID=1, CustomerID=1, EmployeeID=1, Status=Status.Under_repair
                , HoursWorked=2, BeginDate=DateTime.Now, EndDate=DateTime.Now.AddDays(6)},
                new RepairOrder{RepairOrderID=2, CustomerID=2, EmployeeID=2, Status=Status.Waiting_for_parts
                , HoursWorked=0, BeginDate=DateTime.Now.AddDays(2), EndDate=DateTime.Now.AddDays(6)},
                new RepairOrder{RepairOrderID=3, CustomerID=3, EmployeeID=3, Status=Status.On_hold
                , HoursWorked=0, BeginDate=DateTime.Now.AddDays(3), EndDate=DateTime.Now.AddDays(8)},
                new RepairOrder{RepairOrderID=4, CustomerID=4, EmployeeID=4, Status=Status.Done
                , HoursWorked=5, BeginDate=DateTime.Now, EndDate=DateTime.Now.AddDays(1)},
                new RepairOrder{RepairOrderID=5, CustomerID=5, EmployeeID=5, Status=Status.Under_repair
                , HoursWorked=5, BeginDate=DateTime.Now, EndDate=DateTime.Now.AddDays(3)},
            };

            context.RepairOrders.AddRange(repairOrders);
            context.SaveChanges();

        }
    }
}