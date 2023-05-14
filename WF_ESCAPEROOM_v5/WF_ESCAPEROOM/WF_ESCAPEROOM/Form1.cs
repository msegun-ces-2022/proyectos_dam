using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Desarrollado por manuel Alberto Segun Lopez como proyecto de primero de ciclo DAM en CES JUAN PABLO II DE CADIZ EN EL AÑO 2022
 
 */
namespace WF_ESCAPEROOM
{
    public partial class Form1 : Form
    {
        int resultado = 1296435410;
        int comprobar = 0;
        public Form1()
        {
            InitializeComponent();
           
            BackgroundImage = Properties.Resources.sara_frid_mod6;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //SoundPlayer simpleSound = new SoundPlayer(@"E:\dam ciclo\Programacion\Proyectos programacion\3 Trimestre\escape room\WF_ESCAPEROOM\WF_ESCAPEROOM\Resources\thePunisherTheme.wav");
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.thePunisherTheme);
            //simpleSound.Play();//para reproducir una sola vez
            simpleSound.PlayLooping();//para repetir de manera auto
            pictureBox3.Image = Properties.Resources.tvcercamodmm;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            pictureBox13.Visible = false;
            pictureBox15.Visible = false;
            pictureBox17.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            pictureBox3.Tag = "cerrado";
            pictureBox7.Tag = "cerrado";
            pictureBox9.Tag = "cerrado";
            pictureBox11.Tag = "cerrado";
            pictureBox13.Tag = "cerrado";
            pictureBox15.Tag = "cerrado";
            pictureBox17.Tag = "cerrado";
            Icon a;
            a = Properties.Resources.kisspng_granada;
            pictureBox2.Cursor = new Cursor(a.Handle);
            pictureBox4.Cursor = new Cursor(a.Handle);
            pictureBox6.Cursor = new Cursor(a.Handle);
            pictureBox8.Cursor = new Cursor(a.Handle);
            pictureBox10.Cursor = new Cursor(a.Handle);
            pictureBox12.Cursor = new Cursor(a.Handle);
            pictureBox14.Cursor = new Cursor(a.Handle);
            pictureBox16.Cursor = new Cursor(a.Handle);
            button11.Tag = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            if (pictureBox3.Tag.ToString() == "cerrado")
            {
                pictureBox3.Visible = true;
                pictureBox3.Tag = "abierto";
                pictureBox4.Visible = false;
             
            }
            else
            {
                if (pictureBox3.Tag.ToString() == "abierto")
                {
                    pictureBox3.Visible = false;
                    pictureBox3.Tag = "cerrado";
                    pictureBox4.Visible = true;
                }
            }
        
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //telefonillo chico
            
            pictureBox4.Visible = false;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            pictureBox5.Visible = true;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //telefonillo
            //if(button12.)
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //salir
            textBox1.Clear();
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            button11.Tag = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            //enter

            if (button11.Tag.ToString() == "enter")
            {
                //se evita el cuelgue

            }
            else
            {
                button11.Tag = "enter";
                comprobar = int.Parse(textBox1.Text);
                if (comprobar == resultado)
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "Correcto";
                    //SoundPlayer simpleSound1 = new SoundPlayer(@"E:\dam ciclo\Programacion\Proyectos programacion\3 Trimestre\escape room\WF_ESCAPEROOM\WF_ESCAPEROOM\Resources\hydraulic-door-sound.wav");
                    SoundPlayer simpleSound1 = new SoundPlayer(Properties.Resources.hydraulic_door_sound);
                    simpleSound1.Play();
                    MessageBox.Show("Enhorabuena, has completado el juego", "ESCAPE ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + "incorrecto";
                    //button11.Tag = "";
                }

            }
            

        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button11.Tag = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag.ToString() == "cerrado")
            {
                pictureBox7.Visible = true;
                pictureBox7.Tag = "abierto";
                pictureBox4.Visible = false;

            }
            else
            {
                if (pictureBox7.Tag.ToString() == "abierto")
                {
                    pictureBox7.Visible = false;
                    pictureBox7.Tag = "cerrado";
                    pictureBox4.Visible = true;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //cuadro PEQUE
            if (pictureBox9.Tag.ToString() == "cerrado")
            {
                pictureBox9.Visible = true;
                pictureBox9.Tag = "abierto";
                pictureBox4.Visible = false;
                

            }
            else
            {
                if (pictureBox9.Tag.ToString() == "abierto")
                {
                    pictureBox9.Visible = false;
                    pictureBox9.Tag = "cerrado";
                    pictureBox4.Visible = true;
                    
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //CUADRO AMPLIADO
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //CHALECO PEQUEÑO
            if (pictureBox11.Tag.ToString() == "cerrado")
            {
                pictureBox11.Visible = true;
                pictureBox11.Tag = "abierto";
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;


            }
            else
            {
                if (pictureBox11.Tag.ToString() == "abierto")
                {
                    pictureBox11.Visible = false;
                    pictureBox11.Tag = "cerrado";
                    pictureBox4.Visible = true;
                    pictureBox8.Visible = true;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //CHALECO GRANDE
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //CASCO PEQUE
            if (pictureBox13.Tag.ToString() == "cerrado")
            {
                pictureBox13.Visible = true;
                pictureBox13.Tag = "abierto";
                pictureBox10.Visible = false;
                


            }
            else
            {
                if (pictureBox13.Tag.ToString() == "abierto")
                {
                    pictureBox13.Visible = false;
                    pictureBox13.Tag = "cerrado";
                    pictureBox10.Visible = true;
                    
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //CASCO GRANDE
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //TIOVIVO PEQUE
            if (pictureBox15.Tag.ToString() == "cerrado")
            {
                pictureBox15.Visible = true;
                pictureBox15.Tag = "abierto";
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
                pictureBox8.Visible = false;



            }
            else
            {
                if (pictureBox15.Tag.ToString() == "abierto")
                {
                    pictureBox15.Visible = false;
                    pictureBox15.Tag = "cerrado";
                    pictureBox10.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox8.Visible = true;

                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //TIOVIVOGRANDE
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //GUITAR PEQUE
            if (pictureBox17.Tag.ToString() == "cerrado")
            {
                pictureBox17.Visible = true;
                pictureBox17.Tag = "abierto";
                pictureBox10.Visible = false;



            }
            else
            {
                if (pictureBox17.Tag.ToString() == "abierto")
                {
                    pictureBox17.Visible = false;
                    pictureBox17.Tag = "cerrado";
                    pictureBox10.Visible = true;

                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //GUITAR GRANDE
        }
    }
}
