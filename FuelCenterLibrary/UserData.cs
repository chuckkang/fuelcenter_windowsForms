using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FuelCenterDB
{
    public class UserData
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Message { get; set; }
        private List<UserData> UserList; // List of All users.

        public UserData()
        {
            FirstName = "";
            LastName = "";
            FullName = "";
            UserId = 0;
            UserList = null;
        }
        public UserData(string first, string last) :base()

        {
            FirstName = first;
            LastName = last;
            FullName = first + " " + last;

        }
        public UserData(string first, string last, int userId) : this (first, last)
        {
            UserId = userId;
        }

        public List<UserData> ReturnUserDataList()
        {
            UserDataDB getUserList = new UserDataDB();
            UserList = getUserList.GetUsersDataList();
            return UserList;
        }
    }
}
