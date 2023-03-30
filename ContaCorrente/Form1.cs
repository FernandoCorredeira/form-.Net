using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {   
        Conta correntistaA = new Conta
            {
                Numero = 1000,
                Titular = "FernandoA",
                Saldo = 1000.0
            };
            Conta correntistaB = new Conta
            {
                Numero = 1000,
                Titular = "FernandoB",
                Saldo = 1000.0
            };
        public Form1()
        {
         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta correntistaA = new Conta
            {
                Numero = 5856853,
                Titular = "Fernando A",
                Saldo = 1000.0
            };
            Conta correntistaB = new Conta
            {
                Numero = 5856574,
                Titular = "Fernando B",
                Saldo = 1000.0
            };
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();
            lblNomeCorrentistaA.Text = correntistaA.Titular;
            lblNomeCorrentistaB.Text = correntistaB.Titular;
            lblContaCorrentistaA.Text = correntistaA.Numero.ToString();
            lblContaCorrentistaB.Text = correntistaB.Numero.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
        }

        private void btnSaldoCorrentistaB_Click(object sender, EventArgs e)
        {
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();
        }

        private void btnAddCorrentistaA_Click(object sender, EventArgs e)
        {
            correntistaA.Depositar(100);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();


        }

        private void btnAddCorrentistaB_Click(object sender, EventArgs e)
        {
            correntistaB.Depositar(100);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();

        }

        private void btnSubCorrentistaA_Click(object sender, EventArgs e)
        {
            correntistaA.Sacar(100);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();

        }

        private void btnSubCorrentistaB_Click(object sender, EventArgs e)
        {
            correntistaB.Sacar(100);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            correntistaA.Transferir(100, correntistaB);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            correntistaB.Transferir(100, correntistaA);
            lblSaldoCorrentistaA.Text = correntistaA.Saldo.ToString();
            lblSaldoCorrentistaB.Text = correntistaB.Saldo.ToString();

        }
    }
}
