using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
       public List<string> Extratos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            double Valor = Math.Abs(double.Parse(txt_ValorDigitado.Text));
            double saldo = Math.Abs(double.Parse(lbl_Valor.Text));
            double soma;
            double saque;
            if (lbl_funcao.Text == "SAQUE")
            {
                saque = saldo - Valor;
                lbl_Valor.Text = $"{saque}";
                Extratos.Add($"Saque no valor de R${Valor} ");
                
                if(Valor > saldo) 
                {
                    MessageBox.Show("Você não possui saldo para Saque");
                }
            }
            else 
            {
                soma = saldo + Valor;
                lbl_Valor.Text = $"{soma}";
                Extratos.Add($"Deposito no valor de R${Valor}");
            }
            



        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            btn_Depositar.BackColor = Color.Gainsboro;
            btn_Depositar.ForeColor = Color.Black;
            btn_Sacar.BackColor = Color.LightBlue;
            btn_Sacar.ForeColor = Color.Black;
            lbl_funcao.Text = "SAQUE";
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            btn_Depositar.BackColor = Color.LightBlue;
            btn_Depositar.ForeColor = Color.Black;
            btn_Sacar.BackColor = Color.Gainsboro;
            btn_Sacar.ForeColor = Color.Black;
            lbl_funcao.Text = "DEPÓSITO";
            
        }

        private void Btn_Extrato_Click(object sender, EventArgs e)
        {
            Form2 tela_Extrato = new Form2();
            tela_Extrato.extratos = Extratos;
            tela_Extrato.Show();


        }
    }
}
