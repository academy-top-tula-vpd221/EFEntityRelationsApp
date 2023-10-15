using Azure;
using EFEntityRelationsApp;
using EFModrelCreateApp;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext context = new ApplicationContext())
//{
//    await context.Database.EnsureDeletedAsync();
//    await context.Database.EnsureCreatedAsync();

//    City washington = new() { Title = "Washington" };
//    City moscow = new() { Title = "Moscow" };

//    context.Cities.Add(washington);
//    context.Cities.Add(moscow);

//    Country usa = new Country() { Title = "Usa", Capital = washington };
//    Country russia = new Country() { Title = "Russia", Capital = moscow };

//    context.Countries.Add(usa);
//    context.Countries.Add(russia);

//    Company yandex = new Company() { Title = "Yandex", Country = russia };
//    Company ozon = new Company() { Title = "Ozon", Country = russia };
//    Company google = new Company() { Title = "Google", Country = usa };

//    context.Companies.Add(yandex);
//    context.Companies.Add(ozon);
//    context.Companies.Add(google);

//    Position manager = new() { Title = "Manager" };
//    Position developer = new() { Title = "Developer" };

//    context.Positions.Add(manager);
//    context.Positions.Add(developer);

//    Employee bob = new Employee() { Name = "Bob", Age = 28, Company = yandex, Position = manager };
//    Employee sam = new Employee() { Name = "Sam", Age = 31, Company = ozon, Position = manager };
//    Employee joe = new Employee() { Name = "Joe", Age = 24, Company = yandex, Position = developer };
//    Employee tom = new Employee() { Name = "Tom", Age = 33, Company = google, Position = developer };

//    context.Employees.Add(bob);
//    context.Employees.Add(sam);
//    context.Employees.Add(joe);
//    context.Employees.Add(tom);

//    //var companies = context.Companies.ToList();
//    //Employee tim = new Employee() { Name = "Tim", Age = 42, CompanyId = companies[0].Id };
//    //context.Employees.Add(tim);

//    await context.SaveChangesAsync();
//}

using (ApplicationContext context = new ApplicationContext())
{
    // EAGER LOADING

    //var employees = context.Employees
    //                       .Include(e => e.Company)
    //                            .ThenInclude(c => c!.Country)
    //                        .ToList();
    //foreach (var employee in employees)
    //    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Company: {employee?.Company?.Title}, Country: {employee?.Company?.Country?.Title}");
    //Console.WriteLine();

    //var employees = context.Employees
    //                       .Include(e => e.Company)
    //                            .ThenInclude(c => c.Country)
    //                                .ThenInclude(cntr => cntr.Capital)
    //                       .Include(e => e.Position)
    //                       .ToList();
    //foreach(var employee in employees)
    //{
    //    Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age} - {employee.Position.Title}");
    //    Console.WriteLine($"\tCompany: {employee.Company.Title}, Country: {employee.Company.Country.Title}, Capital: {employee.Company.Country.Capital.Title}");
    //}

    //var companies = context.Companies
    //                       .Include(c => c.Employees)
    //                       .ToList();

    //foreach (var company in companies)
    //{
    //    Console.WriteLine(company.Title);
    //    var employees = company?.Employees?.ToList();
    //    if(employees is not null)
    //        foreach (var employee in employees)
    //            Console.WriteLine($"\t {employee?.Name} {employee?.Age}");
    //    Console.WriteLine();
    //}
}

//using (ApplicationContext context = new ApplicationContext())
//{
//    var company = context.Companies.FirstOrDefault();
//    if (company is not null)
//        context.Companies.Remove(company);
//    context.SaveChanges();
//}

//using (ApplicationContext context = new ApplicationContext())
//{
//    var employees = context.Employees.ToList();
//    foreach (var employee in employees)
//        Console.WriteLine(employee);
//}