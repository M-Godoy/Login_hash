using Login_Hash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Login_hash
{
    public partial class Form1 : Form
    {
        Dictionary<string,string> usuarios = new Dictionary<string,string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
  
            string usuario = txtUsuarioLogin.Text;
            string senha = Crypto.sha256encrypt(txtSenhaLogin.Text);

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
            {
                txtUsuarioLogin.Text = String.Empty;
                txtSenhaLogin.Text = String.Empty;
                MessageBox.Show("Login realizado com sucesso !");
                
            }
            //Se não achar então
            else
            {
                MessageBox.Show("Usuário/Senha incorretos");
                
            }

        }
   
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AdicionarUsuario(txbUsuarioRegistro.Text, txbSenhaRegistro.Text, txbConfirmar.Text);
        }

        private void AdicionarUsuario(string _nomeusuario, string _senha, string _confirmarsenha)
        {
            string usuarioR = txbUsuarioRegistro.Text;
            string senhaR = txbSenhaRegistro.Text;
            string confirmar = txbConfirmar.Text;

            if (senhaR != confirmar)
            {
                MessageBox.Show("Senha não confere");
            }
            else if (senhaR.Length < 8)
            {
                MessageBox.Show("A senha deve conter no mínimo 8 caracteres");
            }
            else if (usuarioR == null)
            {
                MessageBox.Show("Você deve informar um usuário");
            }
            else
            {
                usuarios[_nomeusuario] = Crypto.sha256encrypt(_senha);
                txbUsuarioRegistro.Text = String.Empty;
                txbSenhaRegistro.Text = String.Empty;
                txbConfirmar.Text = String.Empty;
                MessageBox.Show("Registro realizado com sucesso!");
            }
        }

    }
}
