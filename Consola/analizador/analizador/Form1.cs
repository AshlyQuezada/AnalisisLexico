using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizador
{
    public partial class Form1 : Form
    {
        Lexico Analiza_Lexico = new Lexico();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analiza_Lexico.Inicia();
            Analiza_Lexico.Analiza(textBox1.Text);
            TOKEN_LEXEMA.Rows.Clear();
            if (Analiza_Lexico.NoTokens > 0)
                TOKEN_LEXEMA.Rows.Add(Analiza_Lexico.NoTokens);
            for (int i = 0; i < Analiza_Lexico.NoTokens; i++)
            {
                TOKEN_LEXEMA.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i];
                TOKEN_LEXEMA.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpiar el Datagrid
            TOKEN_LEXEMA.Rows.Clear();
            //Limpiar el Textbox
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
