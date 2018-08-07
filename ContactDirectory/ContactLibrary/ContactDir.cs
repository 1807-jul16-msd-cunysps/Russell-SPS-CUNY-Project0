﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLibrary
{
    public class Person
    {
        public Person()
        {
            address = new Address();
            phone = new Phone();
        }

        public int Pid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Address address { get; set; }
        public Phone phone { get; set; }
    }

    public class Address
    {
        public int Pid { get; set; }
        public string houseNum { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string zipcode { get; set; }

        public override string ToString()
        {
            return houseNum + " " + street + " " + city + " " + zipcode;
        }
    }

    public class Phone
    {
        public int Pid { get; set; }
        public string countrycode { get; set; }
        public string areaCode { get; set; }
        public string number { get; set; }
        public string ext { get; set; }
        public override string ToString()
        {
            return areaCode + " " + number + " " + ext;
        }
    }
    public class Message
    {
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}