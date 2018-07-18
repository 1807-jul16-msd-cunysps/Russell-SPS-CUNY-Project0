﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp;
using System.Runtime.Serialization;

namespace PhoneApp
{
    public enum State
    {
        NY, FL, VA, MD, SF, OH
    }
    public enum Country
    {
        US = 1, UK = 44, India = 91, Pakistan = 92, Australia = 61
    }
    public class Person : ISerializable
    {
        public Person(string firstName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            address = new Address();
            phone = new Phone();
        }
        public long Pid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Address address { get; set; }
        public Phone phone { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)//Declares the information serialized
        {
            info.AddValue("First Name", firstName);
            info.AddValue("Last Name", lastName);
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            firstName = (string)info.GetValue("First Name", typeof(string));
            lastName = (string)info.GetValue("First Name", typeof(string));

        }

        /* public List<Person> Get()
         {
             Person p1 = new Person();
             p1.Pid = DateTime.Now.Ticks;
             p1.firstName = "Russell";
             p1.lastName = "Chin";
             p1.address.houseNum = "121";
             p1.address.Pid = p1.Pid;
             p1.address.street = "1st";
             p1.address.city = "New York";
             p1.address.State = State.NY;
             p1.address.Country = Country.US;
             p1.address.zipcode = "10017";
             p1.phone.Pid = p1.Pid;
             p1.phone.areaCode = "204";
             p1.phone.countrycode = Country.US;
             p1.phone.ext = "";
             p1.phone.number = "564456";


             Person p2 = new Person();
             p2.Pid = DateTime.Now.Ticks;
             p2.firstName = "Sally";
             p2.lastName = "Shield";
             p2.address.houseNum = "123";
             p2.address.Pid = p2.Pid;
             p2.address.street = "21st";
             p2.address.city = "New York";
             p2.address.State = State.NY;
             p2.address.Country = Country.US;
             p2.address.zipcode = "10018";
             p2.phone.Pid = p2.Pid;
             p2.phone.areaCode = "289";
             p2.phone.countrycode = Country.US;
             p2.phone.ext = "";
             p2.phone.number = "456622";

             List<Person> p = new List<Person>();
             p.Add(p1);
             p.Add(p2);
             return p;

            List<Person> getList()
             {
                 return p;
             }
         }

         public void Read()
         {
             Person p = new Person();
             var persons = p.Get();
             foreach (Person i in persons)
             {
                 Console.WriteLine(i.firstName + i.lastName);
             }
         }
         public void Adder(string firstName, string lastName)
         {
             Person per = new Person();
             List<Person> lister = per.Get();
             per.firstName = firstName;
             per.lastName = lastName;
             lister.Add(per);

         }*/
    }

    public class Address
    {
        public long Pid { get; set; }
        public string houseNum { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public string zipcode { get; set; }
    }

    public class Phone
    {
        public long Pid { get; set; }
        public Country countrycode { get; set; }
        public string areaCode { get; set; }
        public string number { get; set; }
        public string ext { get; set; }
    }
}

