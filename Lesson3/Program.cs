using System;
using static Lesson3.WorkWithString;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. В класс банковский счет, созданный в упражнениях, добавить метод,
            //который переводит деньги с одного счета на другой.
            //У метода два параметра:
            //ссылка на объект класса банковский счет откуда снимаются деньги,
            //второй параметр – сумма.
            Console.WriteLine("№1");
            BankAccount acc1 = new(1000);
            acc1.PrintInfo();
            BankAccount acc2 = new();
            acc2.PrintInfo();
            acc2.RequestMoney(acc2, 1000);
            acc2.RequestMoney(acc1, 2000);
            acc2.RequestMoney(acc1, -50);
            acc2.RequestMoney(acc1, 500);
            acc1.PrintInfo();
            acc2.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("№2");
            //2. Реализовать метод,
            //который в качестве входного параметра принимает строку string,
            //возвращает строку типа string, буквы в которой идут в обратном порядке.
            //Протестировать метод.
            Console.WriteLine(ReverseString(GetStringFromUser("Напишите что-нибудь интересное...")));
            Console.WriteLine();

            Console.WriteLine("№3");
            //3. * Работа со строками. Дан текстовый файл,
            //содержащий ФИО и e-mail адрес.
            //Разделителем между ФИО и адресом электронной почты является символ &:
            //Кучма Андрей Витальевич & Kuchma@mail.ru
            //Мизинцев Павел Николаевич & Pasha@mail.ru
            //Сформировать новый файл, содержащий список адресов электронной почты.
            //Предусмотреть метод, выделяющий из строки адрес почты.
            //Методу в качестве параметра передается символьная строка s,
            //e-mail возвращается в той же строке s:
            //public void SearchMail (ref string s).
            var arr = GetEmails("NamesAndEmails.txt");
            var fileName = GetStringFromUser("Введите название файла без расширения.");
            WriteLinesToFile(fileName, arr);

        }
    }
}
