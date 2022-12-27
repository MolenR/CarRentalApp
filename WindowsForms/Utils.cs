using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsForms
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            // Cast Application from the base Form
            var OpenForms = Application.OpenForms.Cast<Form>();
            
            // Declare boolean to check if From is already open
            bool isOpen = OpenForms.Any(qDB => qDB.Name == name);

            //Return 
            return isOpen;
        }

        public static string HashPassword(string password)
        {
            // Make new Instance from Microsoft.Security // SHA256 HASH
            SHA256 hash = SHA256.Create();

            //Created StringBuilder to collect bytes and create string
            StringBuilder stringBuilder = new StringBuilder();

            //Convert the input string to Array // HASHED
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Loop through each byte of HASHED values
            //Format to HEX string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
