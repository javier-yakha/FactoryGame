﻿using ItemFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary.Items
{
    public class Hammer : Item
    {
        public int AttackValue { get; set; }
        public Hammer()
        {
            Name = "Thunder Hammer";
            Id = 11;
            AttackValue = 49;
            Console.WriteLine("The Thunder Hammer has been created.");
        }
        public override void useItem()
        {
            Console.WriteLine($"You strike the ground with great force and a lighting strikes {AttackValue} points to the enemy in front of you.");
        }
    }
}
