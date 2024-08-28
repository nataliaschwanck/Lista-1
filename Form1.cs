using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Natália e Robert, 2-51, Visualizador de Imagens
namespace Atv_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeDosPersonagens = Directory.GetFiles(@"C:\Users\LAB TECH 14\Documents\Alex Spritze\Atv_1\Personagens");
            foreach (string img in nomeDosPersonagens)
            {
                string[] separador = img.Split('\\');
                string[] nomePersonagem = separador[7].Split('.');

                if (comboBox2.Text == nomePersonagem[0])
                {
                    pictureBox2.ImageLocation = @"C:\\Users\\LAB TECH 14\\Documents\\Alex Spritze\\Atv_1\\Personagens\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                    
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if(comboBox1.Text == "Humano")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Respiração do Sol");
                comboBox2.Items.Add("Respiração da Pedra");
                comboBox2.Items.Add("Respiração do Amor");
                comboBox2.Items.Add("Respiração da Névoa");
                comboBox2.Items.Add("Respiração da Serpente");
                comboBox2.Items.Add("Respiração das Chamas");
                comboBox2.Items.Add("Respiração do Vento");
                comboBox2.Items.Add("Respiração do Inseto");
                comboBox2.Items.Add("Respiração da Água");
                comboBox2.Items.Add("Respiração do Som");
            }
            else if (comboBox1.Text == "Oni")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lâminas da Lua Crescente");
                comboBox2.Items.Add("Manipulação do Gelo");
                comboBox2.Items.Add("Jutsushiki Tenkai");
                comboBox2.Items.Add("Controle de Emoções");
                comboBox2.Items.Add("Criação de Vasos");
                comboBox2.Items.Add("Foices Negras");
                comboBox2.Items.Add("Faixas Cortantes");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
