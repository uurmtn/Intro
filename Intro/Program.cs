// See https://aka.ms/new-console-template for more information
using Intro.Entities;
using Intro.Business;
using Intro.DataAccess.Concretes;

Console.WriteLine("Hello, World!");
bool isAuthenticated = true;

if (isAuthenticated)
{
    Console.WriteLine("Hoş geldiniz");
}
else
{
    Console.WriteLine("Sisteme Giriş Yapınız");
}

string[] loans = {"Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine("-----------------------------------------------------");

CourseManager courseManager = new (new EfCourseDal());

List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}

Console.WriteLine("-----------------------------------------------------");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1234567890";
customer1.FirstName = "Uğur";
customer1.LastName = "Metin";
customer1.CustomerNumber = "4747";

IndividualCustomer customer2 = new IndividualCustomer();    
customer2.Id = 2;
customer2.NationalIdentity = "00000000000";
customer2.FirstName = "Ali";
customer2.LastName = "Veli";
customer2.CustomerNumber = "123456";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 1;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "343434";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 1;
customer4.Name = "Abc";
customer4.CustomerNumber = "123456";
customer4.TaxNumber = "01234567891";

BaseCustomer[] customers = {customer1,customer2,customer3,customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

Console.WriteLine("-----------------------------------------------------");
