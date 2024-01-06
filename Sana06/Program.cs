using Library;

Person[] person = new Person[2];

person[0] = new Student(1, "ІПЗ-23-4", "ІПЗ", "ЖДТУ", 200, 12, "Ярунська ЗОШ", "Назарій", "Гаврилюк", new DateTime(2006, 09, 27));

Console.WriteLine(person[0].ShowInfo());