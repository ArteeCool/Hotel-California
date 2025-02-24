using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class User // Абстрактний клас
    {
        private string _name = "not_exist"; // Приватні змінні
        private int _age = 0;

        public void SetName(string name) { this._name = name; } // Далі йдуть setters та getters
        public string GetName() { return this._name; }

        public void SetAge(int age) { this._age = age; }
        public int GetAge() { return this._age; }


        public User() { } // Конструктор за замовчуванням 
        public  User(string name, int age) // Конструктор з параметрами
        {
            SetName(name);
            SetAge(age);
        }

        public override string ToString()
        {
            return $"Your name is {GetName}\nYour age is {GetAge()}";
        }

        public abstract void SaySomething(); // Абстрактний клас
    }
}
