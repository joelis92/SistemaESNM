using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abastecimiento
{
    public partial class Frm_iniciar_sesion : Form
    {
        public Frm_iniciar_sesion()
        {
            InitializeComponent();
        }

        private void Frm_iniciar_sesion_Load(object sender, EventArgs e)
        {

            lbl_exito.Visible = false;
            lbl_noexito.Visible = false;

            try
            {
                Comun.establecer_conexion.Open();
                lbl_exito.Visible = true;
                Comun.establecer_conexion.Close();
            }
            catch (Exception)
            {
                lbl_noexito.Visible = true;
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            validar_usuario();
        }
        private void validar_usuario()
        {
            if (txt_usuario.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
            }
            else
                if (txt_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario");
            }
            else
                    if (txt_password.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña");
            }

            else
            {
                //para dar de alta hijo en caso de que exista el personal en BDD(frmhijo,aceptar)
                int existe = Brl.logearUsuario(txt_usuario.Text, txt_password.Text);





                if (existe == 1)
                {
                   
                    this.Hide();
                    new Frm_principal().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sus datos no se encuentra en la base de datos. Consulte con su administrador");
                    limpiar_login();
                    txt_usuario.Focus();
                }

            }
            }
            private void limpiar_login()
        {
            txt_usuario.Text = "";
            txt_password.Text = "";
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validar_usuario();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
