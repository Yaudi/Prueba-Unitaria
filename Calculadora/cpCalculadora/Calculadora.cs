using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cnCalculadora;
namespace cpCalculadora
{
    public partial class Calculadora : Form
    {
        Logica log;
        String valor;
        String tem;
        int operacion;
        public Calculadora()
        {
            log = new Logica();
            valor = "";
            tem = "";
            operacion = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void B2_Click(object sender, EventArgs e)
        {
             
            valor+=B2.Text.ToString();
            tbresultado.Text = valor;
        
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            tbresultado.Text="";
            tem = valor;
            valor = "";
            tbresultado.Text = valor;
            operacion = 1;
           
            

          // tbresultado.Text="" + (log.sumarNumeros(int.Parse(B1.Text.ToString));
            //tbresultado.Text = "" + log.sumarNumeros(1,5);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            valor+=B1.Text.ToString();
            
            tbresultado.Text = valor;

        }

        private void tbresultado_TextChanged(object sender, EventArgs e)
        {

           // tbresultado.Text = 
        }

        private void bigual_Click(object sender, EventArgs e)
        {

            switch (operacion) { 
            
                case 1:
                   
                   tbresultado.Text = "" + (log.sumarNumeros(int.Parse(valor), int.Parse(tem)));
                   break;

                case 2:

                   tbresultado.Text = "" + (log.MultiplicarNumeros(int.Parse(valor), int.Parse(tem)));
                   break;

                case 3:
                   tbresultado.Text = "" + (log.restarNumeros(int.Parse(tem), int.Parse(valor)));
                   break;


                case 4:
                   tbresultado.Text = "" + (log.DivisionNumeros(int.Parse(tem), int.Parse(valor)));
                   break;

            }

         
        }

        private void bmulti_Click(object sender, EventArgs e)
        {
            tbresultado.Text = "";
            tem = valor;
            valor = "";

            operacion = 2;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            valor += B3.Text.ToString();

            tbresultado.Text = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor += B0.Text.ToString();

            tbresultado.Text = valor;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Bresta_Click(object sender, EventArgs e)
        {
            tbresultado.Text = "";
            tem = valor;
            valor = "";
           
            operacion = 3;

        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            tbresultado.Text = "";
            tem = valor;
            valor = "";
            operacion = 4;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            valor += B4.Text.ToString();

            tbresultado.Text = valor;

        }

        private void B5_Click(object sender, EventArgs e)
        {
            valor += B5.Text.ToString();

            tbresultado.Text = valor;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            valor += B6.Text.ToString();

            tbresultado.Text = valor;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            valor += B7.Text.ToString();

            tbresultado.Text = valor;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            valor += B8.Text.ToString();

            tbresultado.Text = valor;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            valor += B9.Text.ToString();

            tbresultado.Text = valor;
        }

       
       

        }

    }

