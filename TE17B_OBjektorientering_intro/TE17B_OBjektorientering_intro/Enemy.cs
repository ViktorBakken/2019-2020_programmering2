﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_OBjektorientering_intro
{
    class Enemy
    {
        private int hp = 100;

        public Enemy()
        {
            Random generator = new Random();
            hp = generator.Next(50, 100);
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public void PrintHp()
        {
            Console.WriteLine(hp) ;
        }

    }
}
