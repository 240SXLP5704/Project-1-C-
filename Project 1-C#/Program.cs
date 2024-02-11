// See https://aka.ms/new-console-template for more information
using Project_1_C_.Business;
using Project_1_C_.Entities;
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Selam, ben geldim!");
string message1 = "krediler";
int term = 12;
double amount = 100000.5;

// variables -> camelCase 
bool isAuthanticated = false;
//bool isAuthanticated = false;
Console.WriteLine(message1);

//condition
if (isAuthanticated == true)
{
    Console.WriteLine("Hoş Geldiniz!");
}
else
{
    Console.WriteLine("Sisteme Giriniz!");
}
string kredi1 = "Kredi 1";
string kredi2 = "Kredi 2";
string kredi3 = "Kredi 3";
string kredi4 = "Kredi 4";
string kredi5 = "Kredi 5";
//Böyle tek tek uğraşmak yerine benzer verileri -
//- ereğlerin içerisinde tut
Console.WriteLine(kredi1);
Console.WriteLine(kredi2);    
Console.WriteLine(kredi3);
Console.WriteLine(kredi4);
Console.WriteLine(kredi5);
// Nasıl mı? Böyle:
string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5"};//db'den gelecek
//string[] loans2 = new string[5];
//loans2[1] = "Kredi 2";


     //start   //condition       //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine(" ");

//OOP(?)
Courses course1 = new Courses();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ". NET 8 vs...";
course1.Price = 10;

Console.WriteLine(" ");

Courses course2 = new Courses();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 17...";
course2.Price = 20;

Console.WriteLine(" ");

Courses course3 = new Courses();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12...";
course3.Price = 30;

Console.WriteLine(" ");
Courses[] courses = {course1, course2, course3};

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new CourseManager();
Courses[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine(" ");
Console.WriteLine("Kod Bitti.");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.ID = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Aslıhan";
customer1.LastName = "AKIL";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.ID = 2;
customer2.NationalIdentity = "78945612310";
customer2.FirstName = "Erkan";
customer2.LastName = "KOCA";
customer2.CustomerNumber = "456123";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.ID = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "789123";
customer3.TaxNumber = "159753456";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.ID = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "123789";
customer4.TaxNumber = "654357951";

// values types = int, bool, double
int number1 = 10;//20 oldu artık
int number2 = 20;
number1 = number2;//burada atama yapıldı
number2 = 50;//atamadan sonra değerin değişmesi
             //bir şey ifade etmez
//sistem atamadan sonra değişen değeri okumaz
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);//Adana
Console.WriteLine(cities2[1]);//İstanbul
Console.WriteLine(cities2[2]);//İzmir

//reference types = array, class, interface
//bunlar referans tipidir.
                            //101      //102      //103      //104
BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    if (customer is IndividualCustomer)
    {   //hala bu bilgiler içerisinde dahildir
        //((IndividualCustomer)customer).FirstName
    }
    //Console.WriteLine(customer.ID);
    Console.WriteLine(customer.CustomerNumber);
}