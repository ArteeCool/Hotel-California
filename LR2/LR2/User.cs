﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public abstract class User
    {
        private string _name;
        private int _age;

        public User(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

    }
}
