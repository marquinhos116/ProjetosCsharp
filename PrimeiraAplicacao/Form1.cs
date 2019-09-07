using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int valor_inicial = 1000;
            // int valor_adicional = 2000;
            //valor_inicial = valor_adicional;
            string nome = "Marcos";
            string apelido = " Silva";
            int idade = 25;

            caixa_texto.Text = "Meu Nome é " + nome + " " + apelido + " E Tenho " + idade.ToString() + " anos";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
