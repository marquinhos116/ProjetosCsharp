using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CicloRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd_executar_Click(object sender, EventArgs e)
        {
            int valor = 1;
            while (valor <= 151)
            {
                lista.Items.Add(valor);
                valor += 2;
                

            }
        }
    }
}
