using System;

class Program
{
    static bool IsMatch(string pattern, string text)
    {
        if (pattern.Length != text.Length)
            return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (pattern[i] == '?')
                continue;
            if (pattern[i] != text[i])
                return false;
        }
        return true;
    }



    static void Main()
    {
        int stop = 0;
        while (stop != 1)
        {
            try
            {
                Console.WriteLine("введите шаблон");
                string pattern = Console.ReadLine();
                Console.WriteLine("ведите текст");
                string text = Console.ReadLine();

                Console.WriteLine(IsMatch(pattern, text) ? "Совпадение" : "Нет совпадения");
                Console.WriteLine("если хотите продолжить нажмите 1 иначе другую цифру");
                stop = Convert.ToInt32(Console.ReadLine());
            }
            catch (InvalidCastException ice)       
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недопустимое исключение приведения. Ошибка: " + ice.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Исключение аргумента вне диапазона. Ошибка: " + aoore.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Исключение формата. Ошибка: " + fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e)  
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}