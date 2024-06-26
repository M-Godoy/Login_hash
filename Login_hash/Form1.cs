﻿using Login_Hash;
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
        //cria um dicionário vazio que é usado para mapear 'string' como a chave e assossiar um valor 'string' a ela, e atribui esse dicionário à variável usuarios;
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
            string senha = Crypto.sha256encrypt(txtSenhaLogin.Text); //criptografa a senha fornecida

            //verifica se o dicionário usuarios contém a chave 'usuario' e, se contiver, se o valor associado a essa chave é igual à senha fornecida;
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
            {
                txtUsuarioLogin.Text = String.Empty;
                txtSenhaLogin.Text = String.Empty;
                MessageBox.Show("Login realizado com sucesso !");
                label1.Text = Crypto.sha256encrypt(txtSenhaLogin.Text);
            }
            else
            {
                MessageBox.Show("Usuário/Senha incorretos");
                
            }

            
        }
   
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AdicionarUsuario(txbUsuarioRegistro.Text, txbSenhaRegistro.Text, txbConfirmar.Text);
            
        }
        //método privado que não retorna nenhum valor e espera três strings como parâmetros;
        private void AdicionarUsuario(string _nomeusuario, string _senha, string _confirmarsenha)
        {
            string usuarioR = txbUsuarioRegistro.Text;
            string senhaR = txbSenhaRegistro.Text;
            string confirmar = txbConfirmar.Text;

            if (senhaR != confirmar)
            {
                MessageBox.Show("Senha não confere.");
            }
            else if (senhaR.Length<10)//verifica a quantidade de caracteres dessa string;
            {
                MessageBox.Show("A senha tem que ter no mínimo 10 caracteres.");
            }
            else if (!senhaR.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("A senha deve conter números.");
            }
            else if (!senhaR.Any(c => char.IsUpper(c)))
            {
                MessageBox.Show("A senha deve conter Letras maiúsculas.");
            }
            else if (!senhaR.Any(c => char.IsLower(c)))
            {
                MessageBox.Show("A senha deve conter letras minusculas.");
            }
            else if (!senhaR.Any(c => char.IsSymbol(c)))
            {
                MessageBox.Show("A senha deve conter caracteres especiais.");
            }
            else if (usuarioR.Length <1)//verifica a quantidade de caracteres dessa string;
            {
                MessageBox.Show("Você deve informar um usuário.");
            }
            else
            {
                //está adicionando um novo usuário ao dicionário, onde o 'nome do usuário' é a chave e a 'senha', criptografada com SHA-256, é o valor associado a chave;
                usuarios[_nomeusuario] = Crypto.sha256encrypt(_senha);
                txbUsuarioRegistro.Text = String.Empty;
                txbSenhaRegistro.Text = String.Empty;
                txbConfirmar.Text = String.Empty;
                MessageBox.Show("Registro realizado com sucesso!");
                label2.Text = Crypto.sha256encrypt(txbSenhaRegistro.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //    static bool VerificarSenha(string senha)
        //    {
        //        // Critérios para uma senha forte
        //        int comprimentoMinimo = 10;
        //        bool temMaiuscula = senha.Any(char.IsUpper);
        //        bool temMinuscula = senha.Any(char.IsLower);
        //        bool temNumero = senha.Any(char.IsDigit);
        //        bool temCaracterEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

        //        // Verificar o comprimento
        //        if (senha.Length < comprimentoMinimo)
        //        {
        //            return false;
        //        }

        //        // Verificar outros critérios
        //        return temMaiuscula && temMinuscula && temNumero && temCaracterEspecial;
        //    }
    }
}
