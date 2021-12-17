using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProfessionalLesson8Task1
{
    [Serializable]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        [NonSerialized]
        [XmlIgnore]
        public int something;

        //public User()
        //{
        //}

        public User(int iD, string name, string position, int something)
        {
            ID = iD;
            Name = name;
            Position = position;
            this.something = something;
        }
    }
}
