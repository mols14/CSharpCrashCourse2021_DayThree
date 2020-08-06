using System;
using System.Collections.Generic;
using CrashCourse2020ExercisesDayThree.Src.DB;
using CrashCourse2020ExercisesDayThree.Src.Models;

namespace CrashCourse2020ExercisesDayThree.Src.Services
{
    public class CustomerService
    {
        CustomerTable db; 
        public CustomerService()
        {
            this.db = new CustomerTable();
        }

        //Create and return a Customer Object with all incoming properties (no ID)
        internal Customer Create(string firstName, string lastName, DateTime birthDate)
        {
            throw new NotImplementedException();
        }

        //db has an Add function to add a new customer!! :D
        //We can reuse the Create function above..
        internal Customer CreateAndAdd(string firstName, string lastName, DateTime birthDate)
        {
            throw new NotImplementedException();
        }

        //Simple enough, Get the customers from the "Database" (db)
        internal List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        //Maybe Check out how to find in a LIST in c# Maybe there is a Find function?
        public Customer FindCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
        
        /*So many things can go wrong here...
          You need lots of exceptions handling in case of failure and
          a switch statement that decides what property of customer to use
          depending on the searchField. (ex. case searchfield = "id" we should look in customer.Id 
          Maybe add searchField.ToLower() to avoid upper/lowercase letters)
          Another thing is you should use FindAll here to get all that matches searchfield/searchvalue
          You could also make another search Method that only return One Customer
           and uses Find to get that customer and maybe even test it.
        */
        public List<Customer> SearchCustomer(string searchField, string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
