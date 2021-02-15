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
using System.ComponentModel;
namespace DI_Tema4_Ejer8
{
    public partial class Form1 : Form
    {
        private List<Imagen> imagenes = new List<Imagen>();
        int pos = 0;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Visor de imagenes";
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.abrir, "Esto... abre la imagen");
            tt.SetToolTip(this.avance, "Si eres arabe esto significa lo contrario");
            tt.SetToolTip(this.retroceso, "Si eres arabe esto significa lo contrario");
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todo (*.*)|*.*|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
           
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(ofd.FileName);
                imagenes.Clear();

                if (f.Exists)
                {
                    imagenes.Add(new Imagen(new Bitmap(f.FullName),f.Length,f.Name));
                    DirectoryInfo di = new DirectoryInfo(f.DirectoryName);
                    foreach(FileInfo fi in di.EnumerateFiles())
                    {
                        if(fi.Extension == ".jpg" || fi.Extension == ".jpeg" || fi.Extension == ".png")
                        {
                            if(fi.FullName != f.FullName)
                                imagenes.Add(new Imagen(new Bitmap(fi.FullName), fi.Length, fi.Name));
                        }
                    }
                }
                pos = 0;

                labelDirectorio.Text = f.DirectoryName;

                sacamosSegundo();
            }

        }

        private void sacamosSegundo()
        {
            f2?.Close();
            if(pos < 0)
            {
                pos = imagenes.Count - 1;
            }
            if(pos >= imagenes.Count)
            {
                pos = 0;
            }
            f2 = new Form2();
            f2.SetBounds(this.Left + this.Width, this.Top, imagenes[pos].imagen.Width, imagenes[pos].imagen.Height);
            f2.panel1.BackgroundImage = imagenes[pos].imagen;
            if (imagenes.Count > 1)
                if (pos == imagenes.Count - 1)
                {
                    this.panel1.BackgroundImage = imagenes[0].imagen;
                }
                else
                {

                    this.panel1.BackgroundImage = imagenes[pos + 1].imagen;
                }
            f2.Show();

            labelDatos.Text = "Nombre: " + imagenes[pos].nombre + " tamaño: " + imagenes[pos].DevuelveTamano() + " resolucion " + imagenes[pos].resolucion;
            this.Text = "Visor de imagenes -" + imagenes[pos].nombre;
        }

        public void avance_Click(object sender, EventArgs e)
        {
            pos++;
            sacamosSegundo();
        }

        public  void retroceso_Click(object sender, EventArgs e)
        {
            pos--;
            sacamosSegundo();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if(MessageBox.Show("Quiere salir de verdad?", "Titulo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                base.OnClosing(e);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                avance_Click(this,e);
            }
            if (e.KeyCode == Keys.R)
            {
                retroceso_Click(this, e);
            }

        }
    }
}
