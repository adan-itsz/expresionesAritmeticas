using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expresionesAritmeticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        String expresionAritmetica;
        String solucionPosfijo;
        double solucion;
        Posfijo pos = new Posfijo();
        solucion resolverOperacion = new solucion();

        private void btnresolver_Click(object sender, EventArgs e)
        {
            expresionAritmetica = txtAritmetica.Text;
            solucionPosfijo = pos.postfijo(expresionAritmetica);
            txtPosfija.Text= solucionPosfijo;
            solucion = resolverOperacion.resultadoExpresion(solucionPosfijo);
            txtSolucion.Text = Convert.ToString(solucion);
        }
    }
}
