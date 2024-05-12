using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Upis_ljudi
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                !emailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Molimo unesite ispravne podatke.");
                return;
            }

            int yearOfBirth;
            if (!int.TryParse(yearOfBirthTextBox.Text, out yearOfBirth) ||
                yearOfBirth <= 0 ||
                yearOfBirth > DateTime.Now.Year)
            {
                MessageBox.Show("Molimo unesite ispravnu godinu rođenja.");
                return;
            }

            
            User newUser = new User
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                YearOfBirth = yearOfBirth,
                Email = emailTextBox.Text
            };

           
            users.Add(newUser);

            
            ClearFields();

            MessageBox.Show("Korisnik uspješno dodan!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (users.Count == 0)
            {
                MessageBox.Show("Nema podataka za spremanje.");
                return;
            }

            
            using (StreamWriter sw = new StreamWriter("users.csv"))
            {
                
                sw.WriteLine("Ime,Prezime,Godina rođenja,E-mail");

                
                foreach (User user in users)
                {
                    sw.WriteLine($"{user.FirstName},{user.LastName},{user.YearOfBirth},{user.Email}");
                }
            }

            MessageBox.Show("Podaci uspješno spremljeni u users.csv datoteku!");

        }

        private void ClearFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            yearOfBirthTextBox.Clear();
            emailTextBox.Clear();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string Email { get; set; }
    }
}
