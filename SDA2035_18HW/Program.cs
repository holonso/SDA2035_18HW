using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_18HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод
            Console.WriteLine("Введите строку, состоящую из скобок { } ( ) [ ]");
            string braces = Console.ReadLine();
            // стек для закрывающих
            Stack<char> closingBracesStack = new Stack<char>();
            // переменная для сравнений
            char lastBrace;
            // булевая для регистрации ошибок
            bool accordanceCheck = true;

            foreach (char symbol in braces)
            {
                switch (symbol)
                {
                    // помещаем закрывающие в стэк для каждой открывающей
                    case '{':
                        closingBracesStack.Push('}');
                        break;
                    case '(':
                        closingBracesStack.Push(')');
                        break;
                    case '[':
                        closingBracesStack.Push(']');
                        break;

                    // сверяем закрывающие с вершиной стека
                    case '}':
                        if (closingBracesStack.Count != 0)
                        {
                            lastBrace = closingBracesStack.Pop();
                            if (symbol != lastBrace)
                            {
                                Console.WriteLine("ОШИБКА: Закрывающая скобка - {0} - не соответствует скобке - {1} - из вершины стека", symbol, lastBrace);
                                accordanceCheck = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ОШИБКА: В стеке пусто - закрывающая скобка - {0} - не имеет перед собой открывающей", symbol);
                            accordanceCheck = false;
                            Console.ReadKey();
                            return;
                        }
                        break;
                    case ')':
                        if (closingBracesStack.Count != 0)
                        {
                            lastBrace = closingBracesStack.Pop();
                            if (symbol != lastBrace)
                            {
                                Console.WriteLine("ОШИБКА: Закрывающая скобка - {0} - не соответствует скобке - {1} - из вершины стека", symbol, lastBrace);
                                accordanceCheck = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ОШИБКА: В стеке пусто - закрывающая скобка - {0} - не имеет перед собой открывающей", symbol);
                            accordanceCheck = false;
                            Console.ReadKey();
                            return;
                        }
                        break;
                    case ']':
                        if (closingBracesStack.Count != 0)
                        {
                            lastBrace = closingBracesStack.Pop();
                            if (symbol != lastBrace)
                            {
                                Console.WriteLine("ОШИБКА: Закрывающая скобка - {0} - не соответствует скобке - {1} - из вершины стека", symbol, lastBrace);
                                accordanceCheck = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ОШИБКА: В стеке пусто - закрывающая скобка - {0} - не имеет перед собой открывающей", symbol);
                            accordanceCheck = false;
                            Console.ReadKey();
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (closingBracesStack.Count != 0)
            {
                Console.WriteLine("Стек не пуст - Скобки расставлены неверно");
            }
            else
            {
                if (accordanceCheck)
                {
                    Console.WriteLine("Скобки расставлены верно.");
                }
                else
                {
                    Console.WriteLine("Скобки расставлены неверно.");
                }
            }
            Console.ReadKey();
        }
    }
}
