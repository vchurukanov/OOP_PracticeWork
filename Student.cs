namespace PracticeWork1.Task1
{
    class Student
    {
        // Закриті поля
        private string name;
        private int age;
        private int course;
        private double rating;

        // Властивості
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public int Course
        {
            get => course;
            set => course = value;
        }
        public double Rating
        {
            get => rating;
            set => rating = value;
        }

        // Конструктор з параметрами
        public Student(string name, int age, int course, double rating)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.rating = rating;
        }

        // Метод редагування даних
        public void EditStudent(string name, int age, double rating)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
        }

        // Визначення ролі
        public string GetRole(int course)
        {
            return course <= 4 ? "бакалавр" : "магістр";
        }

        // Виведення повідомлення залежно від рейтингу
        public void StudentRating()
        {
            if (rating >= 82)
                Console.WriteLine("Привіт відмінникам");
            else if (rating <= 60)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
    }
}