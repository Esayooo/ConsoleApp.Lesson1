using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать приложение, которое выведет на экран Ваше имя и фамилию. (Жду что у вас будет приложение, которое я сам запущу и где у меня попросят ввести ФИО, после я нажму Enter и мне выдастся сообщение – «Приветствую тебя - ФИО»)
            Console.WriteLine("Hello.What's your name?");


            string surname = Console.ReadLine();

            string name=  Console.ReadLine();

            Console.WriteLine("Your name is:"+surname+name);

            
            Console.ReadKey();

            //Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму. (Так же как и в предыдущем примере, только с цифрами. Мы проходили как можно из строки перевести в число.)
            Console.WriteLine("Enter numers:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int sum = 0;
            foreach (string n in numbers)
            {
                if (int.TryParse(n, out int parsedNumber))
                {
                    sum += parsedNumber;
                }
            }
            Console.WriteLine($" summa :{sum}");

        }
    }
}
