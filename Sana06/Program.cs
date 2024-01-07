using Library;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Person[] person = new Person[5];

person[0] = new Person("Назарій", "Гаврилюк", new DateTime(2006, 09, 27));
person[1] = new Applicant(200, 12, "Ярунська ЗОШ", "Назарій", "Гаврилюк", new DateTime(2006, 09, 27));
person[2] = new Student(1, "ІПЗ-23-4", "ІПЗ", "ЖДТУ", 200, 12, "Ярунська ЗОШ", "Назарій", "Гаврилюк", new DateTime(2006, 09, 27));
person[3] = new Teacher("Декан", "ІПЗ", "ЖДТУ", "Назарій", "Гаврилюк", new DateTime(2006, 09, 27));
person[4] = new LibraryUser("345F523GH", new DateTime(2022, 10, 11), 20000, "Назарій", "Гаврилюк", new DateTime(2006, 09, 27));

for (int i = 0; i < person.Length; i++)
    Console.WriteLine(person[i].ShowInfo());