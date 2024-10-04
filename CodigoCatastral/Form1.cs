using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoCatastral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoCatastral = textBox1.Text;  // Obtener el código catastral del TextBox
            string tipoImpuesto = DeterminarTipoImpuesto(codigoCatastral);
            
            // Mostrar el resultado en el Label
            label2.Text = "Código Catastral: {codigoCatastral}\nTipo de Impuesto: {tipoImpuesto}";
        }
        private string DeterminarTipoImpuesto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                return "Código catastral no válido";
            }

            switch (codigo[0])
            {
                case '1':
                    return "Alto";
                case '2':
                    return "Medio";
                case '3':
                    return "Bajo";
                default:
                    return "Categoría desconocida";
            }
        }
    }
}
