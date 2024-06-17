using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вы разрабатываете систему управления библиотекой. В этой системе есть разные виды материалов, которые могут быть добавлены в библиотеку: книги, журналы и DVD. Все они имеют общие свойства и методы, но также имеют и уникальные для каждого типа характеристики и поведения.

//Требования:
//Создайте абстрактный класс LibraryItem, который будет содержать общие свойства и методы для всех типов материалов. В этот класс должны входить:

//Свойства Title(название) и Author(автор).
//Абстрактный метод GetInfo(), который будет возвращать информацию о предмете библиотеки.

namespace AbstractClass3
{
    internal abstract class LibraryItem
    {
        public string Title { get; private set; } //название ресурса.
        public string Author { get; private set; } //автор ресурса.
     
        public LibraryItem(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public abstract string GetInfo();  //абстрактный метод, который будет возвращать информацию о предмете библиотеки.
    }
}
