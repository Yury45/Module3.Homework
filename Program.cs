namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questionnaire questionnaire = new Questionnaire();

            Ask("Как вас зовут?");
            questionnaire.Name = GetAnswer();
            Ask("Сколько вам лет?");
            questionnaire.Age = GetAnswer();
            Ask("Напишите дату вашего рождения:");
            questionnaire.Birthday = GetAnswer();

            questionnaire.Print();
            Console.ReadKey();
        }

        static void Ask(string question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question);
        }

        static string GetAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return Console.ReadLine();
        }
    }
}