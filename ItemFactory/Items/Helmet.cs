﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFactoryLibrary.Items
{
    public class Helmet : Item
    {
        public int DefenseValue { get; set; }
        public Helmet() 
        {
            Name = "Helmet of the Ancients";
            Id = 14;

            Random r = new();
            DefenseValue = r.Next(1, 12);
            Console.WriteLine("The <Helmet of the Ancients> has been created.");
        }
        public override void UseItem()
        {
            Console.WriteLine($"As you wear the Helmet, the enormous Ruby starts glowing protecting you for <{DefenseValue} HP>.");
        }

    }
}
