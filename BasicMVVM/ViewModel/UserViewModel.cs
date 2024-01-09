using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using BasicMVVM.Model;

namespace BasicMVVM.ViewModel
{
    class UserViewModel
    {
        private List<User> _UsersList;

        public UserViewModel()
        {
            _UsersList = new List<User>
            {
               new User { UserId = 1, FirstName = "אביגיל", LastName = "כהן", City = "תל אביב", State = "TA", Country = "ישראל", Email = "avigail@example.com" },
new User { UserId = 2, FirstName = "משה", LastName = "לוי", City = "ירושלים", State = "JM", Country = "ישראל", Email = "moshe@example.com" },
new User { UserId = 3, FirstName = "שרה", LastName = "גולן", City = "חיפה", State = "HA", Country = "ישראל", Email = "sarah@example.com" },
new User { UserId = 4, FirstName = "יעקב", LastName = "פרץ", City = "באר שבע", State = "BS", Country = "ישראל", Email = "yaakov@example.com" },
new User { UserId = 5, FirstName = "רחל", LastName = "מאיר", City = "אשדוד", State = "ASD", Country = "ישראל", Email = "rachel@example.com" },
new User { UserId = 6, FirstName = "דוד", LastName = "גור", City = "נתניה", State = "NT", Country = "ישראל", Email = "david@example.com" },
new User { UserId = 7, FirstName = "מרים", LastName = "זכאי", City = "עפולה", State = "AF", Country = "ישראל", Email = "miriam@example.com" },
new User { UserId = 8, FirstName = "עידו", LastName = "אביטל", City = "אילת", State = "IL", Country = "ישראל", Email = "ido@example.com" },
new User { UserId = 9, FirstName = "תמר", LastName = "פלאי", City = "טבריה", State = "TB", Country = "ישראל", Email = "tamar@example.com" },
new User { UserId = 10, FirstName = "יפה", LastName = "כהן", City = "קריית שמונה", State = "KS", Country = "ישראל", Email = "yafe@example.com" },

            };
        }

        public List<User> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }
        
    }
}
