using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly Contract Number ;

        public string GetInfo() 
        { 
            

            return $"{Name} {Surname}. Телефонный номер: {Birthday:d}. " + $"Пол: {gender}. Возраст: {Age}."; 
        }
    }
}
