using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientDetailManagement.Models;
using System.IO;

namespace ClientDetailManagement.BLL
{
    public class UserBll
    {
        public bool SaveUser(UserModel user)
        {
            try
            {
                var path = (@"C:\ClientDetail.txt");
                using (TextWriter tw = new StreamWriter(path))
                {

                    tw.WriteLine(user.Surname + "," + ' ' + user.FirstName + "," + ' ' + user.IdentityType + ","
                                + ' ' + user.IdentityNumber + "," + ' ' + user.DateOfBirth);
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public UserModel GetUserToUpdate()
        {
            try
            {
                var user = new UserModel();
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\ClientDetail.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    user.Surname = words[0];
                    user.FirstName = words[1];
                    user.IdentityType = words[2];
                    user.IdentityNumber = words[3];
                    user.DateOfBirth = Convert.ToDateTime(words[4]);
                }
                file.Close();
                return user;
            }
            catch (Exception)
            {

                return new UserModel();
            }
        }

        public bool UpdateUser(UserModel user)
        {
            try
            {
                var contents = user.Surname + "," + ' ' + user.FirstName + "," + ' ' + user.IdentityType + ","
                                + ' ' + user.IdentityNumber + "," + ' ' + user.DateOfBirth;
                System.IO.File.WriteAllText(@"C:\ClientDetail.txt", contents);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}