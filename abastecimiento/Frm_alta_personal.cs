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
    public partial class Frm_alta_personal : Form
    {
        public Frm_alta_personal()
        {
            InitializeComponent();
        }

        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_apellido.Text != "")
            {
                MessageBox.Show("Ingrese apellido");

            }
            else
                if (txt_nombre.Text != "")
            {
                MessageBox.Show("Ingrese nombre");

            }
            //final de las validaciones
            else
                Brl.insertar_personal(txt_apellido, txt_nombre, txt_dni, txt_matricula, dtp_fecha_nacimiento, dtp_fecha_ingreso, 
                    dtp_fecha_ascenso, txt_jerarquia, txt_estudios_finalizados, txt_estudios_curso, txt_estudios_curso, txt_altura, 
                    txt_peso, txt_grupo_sanguineo, txt_domicilio_real, txt_domicilio_eventual, txt_telefono, txt_celular, txt_email, 
                    txt_lugar_trabajo, txt_funcion_puesto, txt_turno, txt_observaciones, dtp_fecha_casamiento);

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
