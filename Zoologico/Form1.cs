using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
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
            String nombre = textBox1.Text;

            String especie;
            double peso =Double.Parse(textBox2.Text);
            int jaula = Convert.ToInt32(numericUpDown1.Value);
            String plumaje = textBox3.Text;
            
            
            if (comboBox1.SelectedIndex == 0)
            {
                especie = "Mamifero";
                Cls_mamifero mamifero = new Cls_mamifero(especie, nombre, peso, jaula);
                label7.Text = mamifero.QueClaseDeAnimalEres();
            }else if (comboBox1.SelectedIndex == 1)
            {
                especie = "Ave";
                double alturamaxima = Double.Parse(textBox4.Text);
                cls_Ave ave = new cls_Ave(especie, nombre, peso, jaula, alturamaxima, plumaje);
                label7.Text = ave.QueClaseDeAnimalEres();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Boolean volar = radioButton1.Checked;
                especie = "Insecto";
                
                cls_Insecto insecto = new cls_Insecto(especie, nombre, peso, jaula, volar);
                label7.Text = insecto.QueClaseDeAnimalEres();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = " ";
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label9.Visible = false;
                textBox3.Visible = false;
                label10.Visible = false;
                textBox4.Visible = false;
                label8.Visible = false;
                groupBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label9.Visible = true;
                textBox3.Visible = true;
                label10.Visible = true;
                textBox4.Visible = true;
                label8.Visible = false;
                groupBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label9.Visible = false;
                textBox3.Visible = false;
                label10.Visible = false;
                textBox4.Visible = false;
                label8.Visible = true;
                groupBox1.Visible = true;
            }


        }
    }
}
