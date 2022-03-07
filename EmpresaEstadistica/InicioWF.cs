using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmpresaEstadistica
{
    public partial class InicioWF : Form
    {
        Rubro rubro = new Rubro();
        Descripcion descripcion = new Descripcion();
        public InicioWF()
        {
            InitializeComponent();
           
        }
     

        private void InicioWF_Load(object sender, EventArgs e){
            UsuarioLabel1.Text = Datos.usuarioInsert;

            for (int r = 0; r < rubro.idRubro.Length; r++){
                if (Datos.CidRubroInsert == rubro.idRubro[r]){
                    RubroTitle.Text = rubro.nombre[r];
                    for (int d = 0; d < descripcion.idDescripcion.Length; d++){

                        if (descripcion.DidRubro[d] == rubro.idRubro[r]){
                            if (descripcion.idDescripcion[d]==1) {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip1.Text = descripcion.clasificacion[d];
                                richTextBox1.Text = (descripcion.detalle[d].ToString());
                            }

                            if (descripcion.idDescripcion[d] == 2)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip2.Text = descripcion.clasificacion[d];
                                richTextBox2.Text = (descripcion.detalle[d].ToString());
                            }

                            if (descripcion.idDescripcion[d] == 3)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip3.Text = descripcion.clasificacion[d];
                                richTextBox3.Text = (descripcion.detalle[d].ToString());
                            }

                            if (descripcion.idDescripcion[d] == 4)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip1.Text = descripcion.clasificacion[d];
                                richTextBox1.Text = (descripcion.detalle[d].ToString());
                            }

                            if (descripcion.idDescripcion[d] == 5)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip2.Text = descripcion.clasificacion[d];
                                richTextBox2.Text = (descripcion.detalle[d].ToString());
                            }

                            if (descripcion.idDescripcion[d] == 6)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip3.Text = descripcion.clasificacion[d];
                                richTextBox3.Text = (descripcion.detalle[d].ToString());
                            }
                            if (descripcion.idDescripcion[d] == 7)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip1.Text = descripcion.clasificacion[d];
                                richTextBox1.Text = (descripcion.detalle[d].ToString());
                            }
                            if (descripcion.idDescripcion[d] == 8)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip2.Text = descripcion.clasificacion[d];
                                richTextBox2.Text = (descripcion.detalle[d].ToString());
                            }
                            if (descripcion.idDescripcion[d] == 9)
                            {
                                //MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
                                TituloDescrip3.Text = descripcion.clasificacion[d];
                                richTextBox3.Text = (descripcion.detalle[d].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void SalirButton_Click_1(object sender, EventArgs e)
        {
            LoginWF login = new LoginWF();
            this.Hide();
            login.Show();
        }
    }
}

//for (int r = 0; r < rubro.idRubro.Length; r++)
//{
//    if (Datos.CidRubroInsert == rubro.idRubro[r])
//    {
//        for (int d = 0; d < descripcion.idDescripcion.Length; d++)
//        {
//            if (descripcion.DidRubro[d] == Datos.CidRubroInsert)
//            {
//                MessageBox.Show(rubro.nombre[r].ToString() + " clasificacion " + descripcion.clasificacion[d]);
//                UsuarioLabel1.Text = Datos.usuarioInsert;
//                TituloDescripLabel.Text = descripcion.clasificacion[d];
//                Info1richTextBox.Text = (descripcion.detalle[d].ToString());
//            }
//        }
//    }
//}
