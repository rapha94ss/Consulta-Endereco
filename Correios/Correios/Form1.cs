using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";
            lblResposta.Text = "Buscando dados...";
            try
            {
                var correio = new Correio.AtendeClienteClient();
                var resposta = correio.consultaCEP(txtCep.Text);
                lblResposta.Text = "Endereço: " + resposta.end;
                lblResposta.Text += "\nCidade: " + resposta.cidade;
                lblResposta.Text += "\nBairro: " + resposta.bairro;
                lblResposta.Text += "\nEstado: " + resposta.uf;
            }
            catch(Exception ex)
            {
                lblResposta.Text = "Erro ao efetuar consulta\n";
                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
