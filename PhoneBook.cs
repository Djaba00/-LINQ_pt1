using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class PhoneBook
    {
        public static void ShowPhoneBook(List<Contact> phoneBook)
        {
            var sortedPB = phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName);

            while(true)
            {
                Console.Write("Введите номер страницы: ");
                var keyChar = Console.ReadKey().KeyChar;

                bool parsed = Int32.TryParse(keyChar.ToString(), out int pageNumb);

                Console.Clear();

                if(!parsed && keyChar == 'q')
                {
                    Console.WriteLine("Завершение сеанса...");
                    break;
                }
                if(!parsed || pageNumb < 1 || pageNumb > sortedPB.Count() / 2)
                {
                    Console.WriteLine("Ошибка ввода, страницы с таким номером не существует");
                    Console.WriteLine();
                    Console.WriteLine("Для выхода из телефонной книги нажмите 'q'");
                    Console.WriteLine();
                }
                else
                {
                    var page = sortedPB.Skip(pageNumb * 2 - 2).Take(2);

                    foreach(var contact in page)
                        Console.WriteLine($"{contact.Name} {contact.LastName} - {contact.PhoneNumber}, {contact.Email}");

                    Console.WriteLine();
                    Console.WriteLine("Для выхода из телефонной книги нажмите 'q'");
                    Console.WriteLine();
                }
            }
        }
    }
}