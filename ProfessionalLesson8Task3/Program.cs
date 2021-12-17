using DataSerializerLib;
using ProfessionalLesson8Task2;
using System;
using System.IO;

namespace ProfessionalLesson8Task3
{
    //    Задание 3
    //Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего
    //примера.Отобразите состояние объекта на экране

    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\CSharp\ProfessionalLesson8\ProfessionalLesson8Task2\bin\Debug\netcoreapp3.1\task2User.xml");
            User deser = null;
            if (file.Exists)
                deser = (User)DataSerializer.XMLDeserialize(typeof(User), file.FullName);

            Console.WriteLine($"{deser.ID} - {deser.Name} - {deser.Position} - {deser.Salary}");

        }
    }
}
