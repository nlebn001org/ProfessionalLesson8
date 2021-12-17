using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProfessionalLesson8Task2
{
    [Serializable]
    [XmlRoot("UserRoot")]
    public class User
    {
        [XmlAttribute("SerialID")]
        public int ID { get; set; }
        [XmlAttribute("UserName")]
        public string Name { get; set; }
        [XmlElement("UserPosition")]
        public string Position { get; set; }
        [XmlElement("UserSalary")]
        public int Salary { get; set; }

        public User()
        {
        }

        public User(int iD, string name, string position, int salary)
        {
            ID = iD;
            Name = name;
            Position = position;
            Salary = salary;
        }
    }
}
