using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_House_Rezervasyon_ve_Yönetim_Sistemi
{
    internal class User
    {
    
        private string username;
        private string password;
        private string email;

        public bool login(string email, string password)
        {
            if(email == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void register(string email, string password)
        {
            this.email = email;
            this.password = password;
            MessageBox.Show(email + password);
        }

    }
}
