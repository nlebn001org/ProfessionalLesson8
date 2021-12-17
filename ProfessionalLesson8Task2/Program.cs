
using DataSerializerLib;
using System;

namespace ProfessionalLesson8Task2
{

    //    Задание 2
    //Создайте класс, поддерживающий сериализацию.Выполните сериализацию объекта этого
    //класса в формате XML.Сначала используйте формат по умолчанию, а затем измените его
    //таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML.

    class Program
    {
        static void Main(string[] args)
        {
            string path = "task2User.xml";
            User user1 = new User(1, "Bob", "Programmer", 4000);
            DataSerializer.XMLSerialize(typeof(User), user1, path);
            User user2 = DataSerializer.XMLDeserialize(typeof(User), path) as User;
        }
    }
}
