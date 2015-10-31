using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cnCalculadora;//tengo que mandar a traer la clase

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Logica log;
        String valor;
        String valor2;
        int operacion;

        public Form1()
        {
            InitializeComponent();
            log = new Logica();
            valor ="";
            valor2 ="";
            operacion =0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbResultado_TextChanged(object sender, EventArgs e)//metodo de la ventana donde aparecen los resultados 
        {
  
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            valor += b1.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
           
        }

        private void bu2_Click(object sender, EventArgs e)
        {
            valor += bu2.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;

        }

        private void b3_Click(object sender, EventArgs e)
        {
            valor += b3.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
           
        }

        private void b4_Click(object sender, EventArgs e)
        {
            valor += b4.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            valor += b5.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            valor += b6.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            valor += b7.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            valor += b8.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            valor += b9.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            valor += b10.Text.ToString();//concatena los numeros que han digitado
            tbResultado.Text = valor;
        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor2 = valor;
            valor = "";
            operacion = 1;

        }

        private void bResta_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor2 = valor;
            valor = "";
            operacion = 2;
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor2 = valor;
            valor = "";
            operacion = 3;
        }

        private void bDividir_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor2 = valor;
            valor = "";
            operacion = 4;
        }

        private void bIgual_Click(object sender, EventArgs e)
        {

            switch (operacion) { 
            
                case 1:

                    tbResultado.Text = "" + (log.sumarNumeros(int.Parse(valor), int.Parse(valor2)));
                    break;
                case 2:

                    tbResultado.Text = "" + (log.restarNumeros(int.Parse(valor2), int.Parse(valor)));
                    break;
                case 3:

                    tbResultado.Text = "" + (log.multiplicarNumeros(int.Parse(valor), int.Parse(valor2)));
                    break;
                case 4:

                    tbResultado.Text = "" + (log.dividirNumeros(int.Parse(valor), int.Parse(valor2)));
                    break;
            }
            
        }


        

    }
}
