namespace Module3
{
    internal class Questionnaire
    {
        private string name;

        internal string Name
        {
            private get { return name; }
            set { name = value; }
        }

        private byte age;

        internal string Age
        {
            private get { return age.ToString(); }
            set
            {
                byte tempAge;
                Byte.TryParse(value, out tempAge);

                while ( tempAge <= 14 || tempAge >= 150)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНекорректный возраст!\nВведите ваш возраст еще раз...");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Byte.TryParse(Console.ReadLine(), out tempAge);
                }

                age = tempAge;
            }
        }

        private DateTime birthday;

        internal string Birthday
        {
            private get { return birthday.ToString();}
            set
            {
                DateTime tempBirthday;
                DateTime.TryParse(value, out tempBirthday);

                while ( tempBirthday <= DateTime.MinValue || tempBirthday >= DateTime.Now)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНекорректная дата рождения!\nВведите дату рождения еще раз...");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    DateTime.TryParse(Console.ReadLine(), out tempBirthday);
                }

                birthday = tempBirthday;

            }
        }

        internal void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.WriteLine($"");
            Console.WriteLine($"Your name is {Name}");
            Console.WriteLine($"Your age is {Age}");
            Console.WriteLine($"You was born on {Birthday}");

        }
    }
}
