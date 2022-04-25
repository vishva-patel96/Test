﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class question_21
    {
        public string Name { get; set; }
        public string tName { get; set; }
        public Guid ID { get; set; }
    }

    public class GenericList<T> where T : question_21
    {
        List<question_21> customers = new List<question_21>()
        {
            new Customer() { ID = Guid.NewGuid(), Name = "Joe", tName = "Smith" },
            new Customer() { ID = Guid.NewGuid(), Name = "Joe", tName = "Smith" },

        };

    }
}
