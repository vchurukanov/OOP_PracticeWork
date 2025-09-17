using System;

namespace PracticeWork1.Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Student stud = new Student("Вася", 19, 2, 60);

			string stRole = stud.GetRole(stud.Course);
			Console.WriteLine($"Цей студент {stRole}");

			stud.StudentRating();

			stud.EditStudent("Петро", 28, 90);

			Console.WriteLine("Оновлені дані про студента");
			Console.WriteLine("Ім'я: " + stud.Name);
			Console.WriteLine("Вік: " + stud.Age);
			Console.WriteLine("Курс: " + stud.Course);
			Console.WriteLine("Рейтинг: " + stud.Rating);
		}
	}
}
