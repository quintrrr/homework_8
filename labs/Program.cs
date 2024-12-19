using System;
using homework_8.Classes;

class Program
{
    public static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
    {
        // В классе банковский счет, созданном в предыдущих упражнениях, удалить
        // методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить
        // конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор
        // для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа
        // банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер
        // счета.
        Console.WriteLine("Упражнение 9.1");
        BankAccount1 account1 = new BankAccount1(100000, AccountType.Current);
        BankAccount1 account2 = new BankAccount1(200000, AccountType.Current);
        account1.TransferFrom(account2, 100);
        Console.WriteLine($"Баланс счета {account1.AccountNumber}: {account1.Balance}");
        Console.WriteLine($"Баланс счета {account2.AccountNumber}: {account2.Balance}");
    }

    static void Task2()
    {
        // Создать новый класс BankTransaction, который будет хранить информацию
        // о всех банковских операциях. При изменении баланса счета создается новый объект класса
        // BankTransaction, который содержит текущую дату и время, добавленную или снятую со
        // счета сумму. Поля класса должны быть только для чтения (readonly). Конструктору класса
        // передается один параметр – сумма. В классе банковский счет добавить закрытое поле типа
        // System.Collections.Queue, которое будет хранить объекты класса BankTransaction для
        // данного банковского счета; изменить методы снятия со счета и добавления на счет так,
        // чтобы в них создавался объект класса BankTransaction и каждый объект добавлялся в
        // переменную типа System.Collections.Queue.
        Console.WriteLine("Упражнение 9.2");
    }

    static void Task3()
    {
        // В классе банковский счет создать метод Dispose, который данные о
        // проводках из очереди запишет в файл. Не забудьте внутри метода Dispose вызвать метод
        // GC.SuppressFinalize, который сообщает системе, что она не должна вызывать метод
        // завершения для указанного объекта.
        Console.WriteLine("Упражнение 9.3");
        BankAccount3 account1 = new BankAccount3(100000, AccountType.Current);
        BankAccount3 account2 = new BankAccount3(200000, AccountType.Current);
        account1.TransferFrom(account2, 100);
        account1.TransferFrom(account2, 200);
        account1.TransferFrom(account2, 300);
    }

    static void Task4()
    {
        // В класс Song (из домашнего задания 8.2) добавить следующие
        // конструкторы:
        // 1) параметры конструктора – название и автор песни, указатель на предыдущую песню
        // инициализировать null.
        // 2) параметры конструктора – название, автор песни, предыдущая песня. В методе Main
        // создать объект mySong. Возникнет ли ошибка при инициализации объекта mySong
        // следующим образом: Song mySong = new Song(); ?
        // Исправьте ошибку, создав необходимый конструктор.
        Console.WriteLine("Домашнее задание 9.1");
        Song mySong = new Song(); 
        
    }
}