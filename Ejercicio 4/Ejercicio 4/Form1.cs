using Ejercicio_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        private AccessControl accessControl;
        public Form1()
        {
            InitializeComponent();
            accessControl = new AccessControl();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int user;
            int password;

            // Validar que los campos de usuario y contraseña sean enteros
            if (int.TryParse(tbUser.Text, out user) && int.TryParse(tbPassword.Text, out password))
            {
                if (accessControl.ValidateLogin(user, password))
                {
                    MessageBox.Show("Acceso concedido", "Login");
                }
                else if (!accessControl.HasAttemptsLeft())
                {
                    MessageBox.Show("Acceso denegado. Has alcanzado el número máximo de intentos.", "Login");
                    btnLogin.Enabled = false;  // Desactivar el botón después de 3 intentos fallidos
                }
                else
                {
                    int remainingAttempts = accessControl.GetRemainingAttempts();
                    MessageBox.Show($"Acceso denegado. Te quedan {remainingAttempts} intento(s).", "Login");
                }
            }
            else
            {
                MessageBox.Show("El usuario y la contraseña deben ser números enteros.", "Error");
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
