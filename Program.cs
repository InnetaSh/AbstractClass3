//Напишите программу, которая:

//Создаёт несколько экземпляров Book, Magazine и DVD.
//Добавляет их в библиотеку.
//Выводит информацию обо всех предметах в библиотеке.

using AbstractClass3;

Book book1 = new Book("песнь льда и пламени.Игра престолов.", "Джордж Мартин", 864);
Book book5 = new Book("песнь льда и пламени.Танец с драконами.", "Джордж Мартин", 845);

Book book7 = new Book("Ведьмак.", "Анджей Сапковский", 1344);

Magazine magazine1 = new Magazine("Forbes Ukraine", "Берти Чарльз Форбс", 2);
Magazine magazine2 = new Magazine("Vogue Ukraine", "Анна Винтур", 3);

DVD dvd = new DVD("Single Deutschland Du Hast", "Rammstein", 25);

Library library1 = new Library();
library1.AddItem(book1);
library1.AddItem(book5);
library1.AddItem(book7);
library1.AddItem(magazine1);
library1.AddItem(magazine2);
library1.AddItem(dvd);
Console.WriteLine();

library1.DisplayItems();
Console.WriteLine();

library1.AddItem(book7);
library1.DisplayItems();

Console.WriteLine();

library1.RemoveItem(book1);
library1.RemoveItem(book5);
library1.RemoveItem(book5);

Console.WriteLine();

library1.DisplayItems();