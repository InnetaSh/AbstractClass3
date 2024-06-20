using AbstractClass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте класс Library, который будет содержать список предметов (List<LibraryItem>) и методы для управления библиотекой:

//AddItem(LibraryItem item) - добавление предмета в библиотеку.
//RemoveItem(LibraryItem item) - удаление предмета из библиотеки.
//DisplayItems() - вывод информации обо всех предметах в библиотеке с использованием метода GetInfo().


namespace AbstractClass3
{
    internal class Library
    {
        public List<LibraryItem> LibraryItems { get; set; }

        public Library()
        {
            LibraryItems = new List<LibraryItem>();
        }
        public void AddItem(LibraryItem item)
        {
            bool flag = false;
            foreach (var itemL in LibraryItems)
            {
                if (itemL.Title == item.Title)
                {
                    Console.WriteLine($"Ресурс с названием \'{item.Title}\' уже был добавлен в библиотеку ранее.");
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                LibraryItems.Add(item);
                Console.WriteLine($"Ресурс с названием \'{item.Title}\' добавлен в библиотеку.");
            }
        }
        public void RemoveItem(LibraryItem item)
        {
            bool flag = false;
            foreach (var itemL in LibraryItems)
            {
                if (itemL.Title == item.Title)
                {
                    LibraryItems.Remove(item);
                    Console.WriteLine($"Ресурс с названием \'{item.Title}\' удален из библиотеки.");
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine($"Ресурс с названием \'{item.Title}\' не найден в библиотеке.");
        }
        
        public void DisplayItems()
        {
            if (LibraryItems.Count == 0)
                Console.WriteLine("Библиотека пуста.");
            foreach (var item in LibraryItems)
            {
                var str = item.GetInfo();
                Console.WriteLine(str);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
