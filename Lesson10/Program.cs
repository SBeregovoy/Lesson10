using System;

namespace Lesson10
{
    class Program
    {
        public const string ProgramName = "Календарь";

        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя

            Step1((GenderEnum)0, "Иванова Ольга");
            //Step2(true, "Петров Иван");

            StepWeek1((DayOfWeekEnum)6);

            PrintAllDays();
            PrintAllGenders();
        }

        static void Step1(GenderEnum gender, string name)
        {
            if (gender == GenderEnum.Man)
            {
                Console.WriteLine($"Уважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }

            Console.WriteLine("Приветствуем на нашем сайте!");
        }

        static void StepWeek1(DayOfWeekEnum dayOfWeek)
        {
            if(dayOfWeek == DayOfWeekEnum.Saturday || dayOfWeek == DayOfWeekEnum.Sunday) 
            {
                Console.WriteLine($"{DayToRussian(dayOfWeek)} - выходной день");
            }
            else
            {
                Console.WriteLine($"{DayToRussian(dayOfWeek)} - рабочий день");
            }
        }

        static string DayToRussian(DayOfWeekEnum dayOfWeek) 
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeekEnum.Monday:
                    output = "понедельник";
                    break;
                case DayOfWeekEnum.Tuesday:
                    output = "вторник";
                    break;
                case DayOfWeekEnum.Wednesday:
                    output = "среда";
                    break;
                case DayOfWeekEnum.Thursday:
                    output = "четверг";
                    break;
                case DayOfWeekEnum.Friday:
                    output = "пятница";
                    break;
                case DayOfWeekEnum.Saturday:
                    output = "суббота";
                    break;
                case DayOfWeekEnum.Sunday:
                    output = "воскресенье";
                    break;
            }
            return output;
        }

        static void PrintAllDays()
        {
            foreach (var item in Enum.GetValues(typeof(DayOfWeekEnum)))
            {
                Console.WriteLine(item);
            }
        }

        static void PrintAllGenders()
        {
            foreach (var item in Enum.GetValues(typeof(GenderEnum)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
