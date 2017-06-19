using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        Arbol miArbol;
        Nodo miNodo;

        public Form1()
        {
            InitializeComponent();
            miArbol = new Arbol();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miNodo = new Nodo(Convert.ToInt32(txtDato.Text));
            miArbol.agregar(miNodo);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.PreOrder();
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.InOrder();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miArbol.PostOrder();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            miNodo = miArbol.buscar(Convert.ToInt32(txtDato.Text));
            if (miNodo == null)
                txtMostrar.Text = "No encontrado";
            else
                txtMostrar.Text = miNodo.ToString();
        }
    }
}
