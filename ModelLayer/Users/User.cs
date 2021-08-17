using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
  public abstract class User
    {
        int age;
        string name;
        string phone;
        Adress adress;

        public User(string name)
        {
            this.name = name;
        }

        public int Age
        {
            get { return age; }
        }
        public Adress _Adress
        {
            get { return adress; }
        }
        public string Phone
        {
            get { return phone; }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
