/*Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру.
Например, если пользователь ввёл five, приложение должно вывести на экран 5.
*/
using static System.Console;

class Program
{
    static void Main()
    {
        Dictionary<string, int> WordsToNumbers = new Dictionary<string, int>
        {
            { "ноль", 0 },
            { "один", 1 },
            { "два", 2 },
            { "три", 3 },
            { "четыре", 4 },
            { "пять", 5 },
            { "шесть", 6 },
            { "семь", 7 },
            { "восемь", 8 },
            { "девять", 9 }
        };

        bool menu = true;
        while (menu)
        {
            Write("Введите число словами от 0 до 9 (для выхода введите '777'): ");
            string userInput = ReadLine().ToLower();

            if (userInput == "777")
            {
                WriteLine("Выход из программы.");
                menu = false;
            }
            else if (WordsToNumbers.ContainsKey(userInput))
            {
                int number = WordsToNumbers[userInput];
                WriteLine($"Соответствующая цифра: {number}");
            }
            else
            {
                WriteLine("Некорректный ввод. Пожалуйста, введите число от 0 до 9 словами или введите '777' для выхода.");
            }
        }
    }
}
    
