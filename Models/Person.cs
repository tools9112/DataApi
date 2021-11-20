using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataApi.Models
{
    public class Person
    {
        public Person()
        {
                
        }

        public int id { get; set; } = 0;
        public string firstName { get; set; } = "";

        public string lastName { get; set; } = "";


    }
}