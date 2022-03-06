using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaEstadistica
{
    public partial class LoginWF : Form
    {
        InicioWF inicio = new InicioWF();
        public LoginWF()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void IngresarButton_Click(object sender, EventArgs e){
            Cliente cliente = new Cliente();
            for (int i = 0; i < cliente.usuario.Length; i++)
            {
                if (UsuariotextBox.Text == string.Empty || ClavetextBox.Text == string.Empty)
                {
                     MessageBox.Show("Por favor complete los campos.");
                     return;
                }

                if (UsuariotextBox.Text == cliente.usuario[i] && ClavetextBox.Text == cliente.clave[i])
                {
                    MessageBox.Show("Bienvenido usuari@ " +cliente.usuario[i]);
                    this.Hide();
                    inicio.Show();
                }
            }
        }
    }
}

//for (int c = 0; c < cliente.CidCliente.Count(); c++)
//{
//    if (UsuariotextBox.Text == string.Empty || ClavetextBox.Text == string.Empty)
//    {
//        MessageBox.Show("Por favor complete los campos.");
//        return;
//    }
//    if (UsuariotextBox.Text != cliente.usuario[c])
//    {
//        MessageBox.Show(cliente.usuario[c]);
//        MessageBox.Show("Su usuario es incorrecto. Por favor, verificar los campos."+cliente.usuario[c] + cliente.CidCliente.Count());
//        UsuariotextBox.Focus();
//        return;
//    }
//    //if (ClavetextBox.Text != cliente.clave[c])
//    //{
//    //    MessageBox.Show("Su clave es incorrecta. Por favor, verificar los campos.");
//    //    ClavetextBox.Focus();
//    //    return;
//    //}
//    //if (cliente.usuario[c] == UsuariotextBox.Text)
//    //{
//    //    MessageBox.Show("Bienvenido: " + cliente.usuario[c].ToString());
//    //}

//Cliente cliente = new Cliente();
//Rubro rubro = new Rubro();
//Descripcion descripcion = new Descripcion();
//for (int i=0; i<cliente.clave.Length; i++){
//    if (cliente.CidCliente[i]==0) {
//        MessageBox.Show("Existen clientes sin registro. );");
//    }
//    //MessageBox.Show("Dame su id " + cliente.CidCliente[i]);
//    //MessageBox.Show("Dame su contra " + cliente.cliente[i]);
//    //MessageBox.Show("Dame su contra "+cliente.clave[i]);
//    //MessageBox.Show("Dame su id de rubro " + cliente.CidRubro[i]);
//}
//for (int j = 0; j < rubro.idRubro.Length; j++)
//{
//    for (int f=0; f<descripcion.idDescrpcion.Length; f++){
//        if (descripcion.DidRubro[f] == rubro.idRubro[j]) {
//            //MessageBox.Show("Dame su id de rubro " + rubro.idRubro[j] + " nombre: " + rubro.nombre[j]);
//            //MessageBox.Show("Dame su nombre de descrpcion: " + rubro.nombre[j] + ",    clasificacion: " + descripcion.clasificacion[f] +",   detalle "+descripcion.detalle[f]);
//        }
//    }
//}
