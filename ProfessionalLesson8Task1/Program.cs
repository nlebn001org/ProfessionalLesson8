using DataSerializerLib;
using System;

namespace ProfessionalLesson8Task1
{
    //    Создайте пользовательский тип(например, класс) и выполните сериализацию объекта этого
    //типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети.

    class Program
    {
        static void Main(string[] args)
        {
            User userSer = new User(1, "Bob", "Pos", 1324);
            DataSerializer.SoapSerialize(userSer, "userSer.xml");
            User userDeser = (User)DataSerializer.SoapDeserialize("userSer.xml");
            Console.WriteLine($"{userDeser.ID} - {userDeser.Name} - {userDeser.Position} - {userDeser.something}");
        }
    }
}
