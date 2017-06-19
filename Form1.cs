using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Proceso proceso;
        FIFO miFIFO;
        int ciclosVacio = 0;
        int procesosPendientes = 0;
        int ciclosPendientes = 0;

        public Form1()
        {
            InitializeComponent();
            miFIFO = new FIFO();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            simular(Convert.ToInt32(txtCiclos.Text));
            pendientes();
            txtMostrar.Text = ciclosVacio.ToString() + " Ciclos vacio, " + procesosPendientes.ToString() + " Procesos pendientes, " + ciclosPendientes.ToString() + " ciclos pendientes";
        }

        public void pendientes()
        {
            while (miFIFO.peek() != null)
            {
                procesosPendientes++;
                ciclosPendientes += miFIFO.dequeue().ciclos;
            }
        }

        public void simular(int ciclos)
        {
            for (int i = 0; i < ciclos; i++)
            {
                if (rand.Next(4) == 3)
                {
                    proceso = new Proceso(rand.Next(4, 15));
                    miFIFO.enqueue(proceso);
                }
                if (miFIFO.peek() != null)
                {
                    miFIFO.peek().ciclos--;
                    if (miFIFO.peek().ciclos == 0)
                    {
                        miFIFO.dequeue();
                    }
                }
                else
                    ciclosVacio++;
            }
        }

    }
}
