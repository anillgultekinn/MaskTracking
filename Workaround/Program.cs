using Business.Concrete;
using Entities.Concrete;

SayHello("Anıl");
SayHello("Gültekin");
SayHello("Engin");
SayHello();

int total = Topla(6, 58);

//Diziler / Arrays

string student1 = "Anıl";
string student2 = "Engin";
string student3 = "Dusan Tadic";

Console.WriteLine(student1);
Console.WriteLine(student2);
Console.WriteLine(student3);

string[] students = new string[3];
students[0] = "Anıl";
students[1] = "Engin";
students[2] = "Dusan Tadic";

students = new string[4];
students[3] = "Ferdi";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

Person person1 = new Person();
person1.FirstName = "Anıl";
person1.LastName = "Gültekin";
person1.YearOfBirth = 1997;
person1.NationalIdentity = 12345678910;

Person person2 = new Person();
person2.FirstName = "Engin";

foreach (string city in cities1)
{
    Console.WriteLine(city);
}

List<string> newCities1 = new List<string> { "Ankara 1", "Istanbul 1", "İzmir 1" };
newCities1.Add("Adana 1");
foreach (var city in newCities1)
{
    Console.WriteLine(city);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void Variables()
{
    string message = "Merhaba";
    double amount = 100000; //db den gelir
    int number = 100;
    bool inLogged = false;

    string name = "Anıl";
    string firstName = "Gültekin";
    int dateOfYear = 1997;
    long nationalIdentity = 12345678910;

    Console.WriteLine(amount * 1.18);
    Console.WriteLine(amount * 1.18);
}

static void SayHello(string name = "isimsiz")
{
    Console.WriteLine($"Merhaba {name}");
}

static int Topla(int number = 5, int number2 = 10)
{
    int total = number + number2;
    Console.WriteLine($"Toplam: {total.ToString()}");
    return total;
}