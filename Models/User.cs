using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Web;
using System.Web.Helpers;

namespace hnnssy.Models
{
    public class User
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        public bool IsValid(string username, string password)
        {
            using (
                var cn =
                    new SqlConnection(
                        @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\personal\hnnssy\hnnssy\App_Data\Users.mdf;Integrated Security=True")
                )
            {
                string _sql = @"SELECT [Username] FROM [dbo].[System_Users] " +
                              @"WHERE [Username] = @u AND [Password] = @p";

                var cmd = new SqlCommand(_sql, cn);

                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                    .Value = SHA1.Create(password);
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }

            }
        }
    }
}