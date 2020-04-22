using DAL.Domains;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace BAL.Services
{ 
    public interface IUserService
    {
        public Customer AddUser(Customer customerEntity);

        public Customer GetUserById(int id);

        public Customer UpdateUser(Customer userEntity);
        public Customer DeleteUser(Customer customerEntity);
        public Customer SignIn(Customer userEntity);
        public Customer EmailExists(Customer userEntity);
        public bool UpdateUserPassword(Customer userEntity);
        IList<SelectListItem> PrepareTitleList();

        IEnumerable<Customer> GetUsersByName(string searchString);
        IEnumerable<Customer> GetAllUsers();

    }
}