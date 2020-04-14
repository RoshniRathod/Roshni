using DAL.Data;
using DAL.Domains;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace BAL.Services
{
    public class UserService : IUserService
    {
        private MediStockContext context;

        public UserService(MediStockContext context)
        {
            this.context = context;
        }

        Customer customer = new Customer();
        public Customer AddUser(Customer customerEntity)
        {
            if (context.Customers.Any(x => x.Email == customerEntity.Email))
            {
                return null;
            }
            else
            {
                context.Customers.Add(customerEntity);
                context.SaveChanges();
                Customer result = context.Customers.Where(s => s.Email == customerEntity.Email).FirstOrDefault();
                return result;
            }
        }

        public Customer GetUserById(int id)
        {
            customer = context.Customers.Where(a => a.Id == id).FirstOrDefault();
            return customer;
            throw new NotImplementedException();
        }

        public Customer UpdateUser(Customer userEntity)
        {
            Customer dataToEdit = context.Customers.SingleOrDefault(c => c.Id == userEntity.Id);
            dataToEdit.FirstName = userEntity.FirstName;
            dataToEdit.LastName = userEntity.LastName;
            dataToEdit.Email = userEntity.Email;
            dataToEdit.Phone = userEntity.Phone;
            dataToEdit.City = userEntity.City;
            dataToEdit.State = userEntity.State;
            dataToEdit.Address = userEntity.Address;
            dataToEdit.Zipcode = userEntity.Zipcode;
            dataToEdit.IsActive = userEntity.IsActive;
            dataToEdit.IsDeleted = userEntity.IsDeleted;
            dataToEdit.CreatedOn = DateTime.Now;
            dataToEdit.UpdatedOn = DateTime.Now;
            context.SaveChanges();

            // Verify weather user inserted(actually updated) or not.
            Customer presentUser = context.Customers.SingleOrDefault(c => c.Email == userEntity.Email);
            if (presentUser != null)
            {
                return presentUser;
            }
            else
            {
                return null;
            }
            throw new NotImplementedException();
        }

        public Customer DeleteUser(int id)
        {

            var param1 = new SqlParameter();
            param1.ParameterName = "Id";
            param1.SqlDbType = SqlDbType.Int;
            param1.SqlValue = id;

            context.Database.ExecuteSqlCommand("DeleteUser @Id", param1);
            // Check user is deleted or not
            var checkUserExistsOrNot = context.Customers.FirstOrDefault(s => s.Id == id);

            if (checkUserExistsOrNot != null)
            {
                return customer;
            }
            else
            {
                return null;
            }

            throw new NotImplementedException();
        }

        #region User Authentication

        // Sign In to authenticate the user
        public Customer SignIn(Customer userEntity)
        {
            var userData = context.Customers.Where(a => a.Email == userEntity.Email && a.Password == userEntity.Password).FirstOrDefault();
            return userData;
        }

        #endregion
    }
}