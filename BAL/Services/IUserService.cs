using DAL.Domains;
using System;

namespace BAL.Services
{ 
    public interface IUserService
    {
        public Customer AddUser(Customer customerEntity);

        public Customer GetUserById(int id);

        public Customer UpdateUser(Customer userEntity);
        public Customer DeleteUser(int id);
        public Customer SignIn(Customer userEntity);



    }
}