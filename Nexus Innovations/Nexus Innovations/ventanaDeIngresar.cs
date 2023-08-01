using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_Innovations
{
    public partial class ventanaDeIngresar : Form
    {
        public ventanaDeIngresar()
        {
            InitializeComponent();
            comboCategoria.SelectedIndex = 0;
        }

        private void bSalir2_Click(object sender, EventArgs e)
        {


        }

        private void bSalir2_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir del programa?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                Program.form1.Close();
            }
        }


        private void ventanaDeIngresar_Load(object sender, EventArgs e)
        {
            bProcesar.Enabled = false;

        }
        private void bProcesar_Click(object sender, EventArgs e)
        {
            string nombre, categoriaSelect = " ";
            int categoria = 0;
            float bonoPorLenguaje = 0, bonoPorFramework = 0, sueldoFinal = 0;
            string mensajeLenguajesSelect = " ", mensajeFrameworkSelect = " ", mensajeBonoExperiencia = " ";
            int acumuladorLenguajes = 0, acumuladorFramework = 0;
            float bonoExperiencia = 0;



            int residualAñosXp = 0;

            bool selectBotstrap = checkBotstrap.Checked;
            bool selectJava = checkJava.Checked;
            bool selectPython = checkPython.Checked;
            bool selectHtml = checkHtml.Checked;
            bool selectC = checkC.Checked;
            bool selectLaravel = checkLaravel.Checked;
            bool selectReact = checkReact.Checked;
            bool selectPHP = checkPhp.Checked;
            bool selectFundation = checkFundation.Checked;
            bool selectDjango = checkDjango.Checked;

            bool isValidIdentificador = int.TryParse(cajaIdentificador.Text, out int identificador);
            bool isValidAñosExperiencia = int.TryParse(cajaAñosDeExperiencia.Text, out int añosDeExperiencia);
            bool isValidSueldoEmpleado = float.TryParse(cajaSueldoBase.Text, out float sueldoEmpleado);
            bool isValidPorcentajeFrame = float.TryParse(cajaBonoFramework.Text, out float porcentajeFrame);
            bool isValidBonoPorExperiencia = float.TryParse(cajaBonoPorAños.Text, out float bonoPorExperiencia);
            bool isValidPorcentajeLenguaje = float.TryParse(cajaBonoPorLenguaje.Text, out float porcentajeLenguaje);
            bool isValidEdadEmpleado = int.TryParse(cajaEdad.Text, out int edadEmpleado);


            if (!isValidIdentificador || !isValidAñosExperiencia || !isValidSueldoEmpleado ||
                !isValidPorcentajeFrame || !isValidBonoPorExperiencia || !isValidPorcentajeLenguaje || !isValidEdadEmpleado)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nombre = cajaNombre.Text;
            identificador = int.Parse(cajaIdentificador.Text);
            añosDeExperiencia = int.Parse(cajaAñosDeExperiencia.Text);
            sueldoEmpleado = float.Parse(cajaSueldoBase.Text);
            porcentajeFrame = float.Parse(cajaBonoFramework.Text);
            porcentajeLenguaje = float.Parse(cajaBonoPorLenguaje.Text);
            categoria = comboCategoria.SelectedIndex;
            edadEmpleado = int.Parse(cajaEdad.Text);
            bonoPorExperiencia = float.Parse(cajaBonoPorAños.Text);

            residualAñosXp = edadEmpleado - añosDeExperiencia;

            if (edadEmpleado < 18)
            {
                MessageBox.Show("El programador no puede tener menos de 18 años", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (edadEmpleado == añosDeExperiencia)
            {
                MessageBox.Show("Verifique que la edad no sea igual\naños de experiencia...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (residualAñosXp <= 8)
            {
                MessageBox.Show("Verifique su edad o años de experiencia...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((selectBotstrap != true) && (selectJava != true) && (selectPython != true) && (selectHtml != true) && (selectC != true) &&
                (selectLaravel != true) && (selectReact != true) && (selectPHP != true) && (selectFundation != true) && (selectDjango != true))
            {
                MessageBox.Show("Seleccione por lo menos un lenguaje o Framework...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (identificador <= 0)
            {
                MessageBox.Show("El identificador no puedo ser 0 ni menor a 0...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (añosDeExperiencia <= 0)
            {
                MessageBox.Show("Los años de experiencia no puede ser menor a 0...", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (bonoPorExperiencia <= 0)
            {
                MessageBox.Show("El bono por experiencia no puede ser menor a 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (porcentajeFrame <= 0)
            {
                MessageBox.Show("El bono por Cada framework que maneja no puede ser menor a 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (porcentajeLenguaje <= 0)
            {
                MessageBox.Show("El bono por Cada lenguaje que maneja no puede ser menor a 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sueldoEmpleado <= 0)
            {
                MessageBox.Show("El sueldo del programador no puede ser 0 o menor a 0", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (añosDeExperiencia > 5)
                {

                    mensajeBonoExperiencia = "Se agrego " + bonoPorExperiencia + "% al sueldo del programador\npor tener mas de 5 años de experiencia";
                }
                else
                {
                    bonoPorExperiencia = 0;
                    mensajeBonoExperiencia = "No tiene mas de 5 años de experiencia\npor ende no tiene bono por experiencia...";
                }
                switch (comboCategoria.SelectedIndex)
                {
                    case 0:
                        categoriaSelect = "FullStack";
                        break;
                    case 1:
                        categoriaSelect = "FrontEnd";
                        break;
                    case 2:
                        categoriaSelect = "BackEnd";
                        break;
                }


                if (selectJava == true)
                {
                    mensajeLenguajesSelect += "JavaScript, ";
                    acumuladorLenguajes++;

                }

                if (selectHtml == true)
                {
                    mensajeLenguajesSelect += "Html y Css, ";
                    acumuladorLenguajes++;

                }

                if (selectPython == true)
                {
                    mensajeLenguajesSelect += "Python, ";
                    acumuladorLenguajes++;

                }

                if (selectFundation == true)
                {
                    mensajeFrameworkSelect += "Fundation, ";
                    acumuladorFramework++;

                }

                if (selectC == true)
                {
                    mensajeLenguajesSelect += "C# || C || C++, ";
                    acumuladorLenguajes++;

                }
                if (selectBotstrap == true)
                {
                    mensajeFrameworkSelect += "Bootstraps, ";
                    acumuladorFramework++;

                }

                if (selectDjango == true)
                {
                    mensajeFrameworkSelect += "Django, ";
                    acumuladorFramework++;

                }

                if (selectLaravel == true)
                {
                    mensajeFrameworkSelect += "Laravel, ";
                    acumuladorFramework++;

                }

                if (selectPHP == true)
                {
                    mensajeLenguajesSelect += "PHP, ";
                    acumuladorLenguajes++;

                }

                if (selectReact == true)
                {
                    mensajeFrameworkSelect += "React, ";
                    acumuladorFramework++;

                }
                bonoExperiencia = MporcetnajeEx(bonoPorExperiencia, sueldoEmpleado);

                bonoPorFramework = acumuladorFramework * porcentajeFrame;
                bonoPorLenguaje = acumuladorLenguajes * porcentajeLenguaje;
                sueldoFinal = sueldoEmpleado + bonoPorLenguaje + bonoPorFramework + bonoExperiencia;
                mensajeLenguajesSelect = mensajeLenguajesSelect.TrimEnd(',', ' ');
                mensajeFrameworkSelect = mensajeFrameworkSelect.TrimEnd(',', ' ');

                DialogResult respuestaProcc = MessageBox.Show("Desea ver resultado final ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuestaProcc == DialogResult.Yes)
                {

                    string mensaje = "Nombre: " + nombre + "\n" +
                                    "Identificador: " + identificador + "\n" +
                                    "Años de Experiencia: " + añosDeExperiencia + "\n" +
                                    "Edad del Programador: " + edadEmpleado + "\n" +
                                    "Categoría Seleccionada: " + categoriaSelect + "\n" +
                                    "Sueldo del Programador: $" + sueldoEmpleado + "\n\n" +


                                    "Habilidades:\n" +
                                    "   - Lenguajes que Maneja: " + mensajeLenguajesSelect + "\n" +
                                    "   - Frameworks que Maneja: " + mensajeFrameworkSelect + "\n\n" +


                                    "Bonificaciones:\n" +
                                    "   - Bono por cada Lenguaje: $" + porcentajeLenguaje + "\n" +
                                    "   - Bono por cada Framework: $" + porcentajeFrame + "\n\n" +


                                    "Total de Bonificaciones:\n" +
                                    "   - Total por Lenguajes: $" + bonoPorLenguaje + "\n" +
                                    "   - Total por Frameworks: $" + bonoPorFramework + "\n\n" +


                                    mensajeBonoExperiencia + "\n\n" +


                                    "Sueldo Final del Empleado: $" + sueldoFinal + "\n";

                    

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK);

                    limpiarDatos();
                }



            }




        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(cajaIdentificador.Text) &&
                !string.IsNullOrEmpty(cajaNombre.Text) &&
                !string.IsNullOrEmpty(cajaAñosDeExperiencia.Text) &&
                !string.IsNullOrEmpty(cajaBonoFramework.Text) &&
                !string.IsNullOrEmpty(cajaBonoPorAños.Text) &&
                !string.IsNullOrEmpty(cajaBonoPorLenguaje.Text) &&
                !string.IsNullOrEmpty(cajaEdad.Text) &&
                !string.IsNullOrEmpty(cajaSueldoBase.Text);
            bProcesar.Enabled = vr;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void limpiarDatos()
        {
            cajaNombre.Text = null;
            cajaIdentificador.Text = null;
            cajaBonoFramework.Text = null;
            cajaBonoPorLenguaje.Text = null;
            cajaEdad.Text = null;
            cajaSueldoBase.Text = null;
            cajaBonoPorAños.Text = null;
            cajaAñosDeExperiencia.Text = null;

            checkBotstrap.Checked = false;
            checkJava.Checked = false;
            checkPython.Checked = false;
            checkHtml.Checked = false;
            checkC.Checked = false;
            checkLaravel.Checked = false;
            checkReact.Checked = false;
            checkPhp.Checked = false;
            checkFundation.Checked = false;
            checkDjango.Checked = false;
        }
        static float MporcetnajeEx(float bonoPorExperiencia, float sueldoEmpleado)
        {
            float bonoExperiencia = 0;
            return bonoExperiencia = (bonoPorExperiencia / 100) * sueldoEmpleado;
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();

        }

        private void cajaNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaIdentificador_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaAñosDeExperiencia_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaSueldoBase_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaBonoPorAños_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaBonoPorLenguaje_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaEdad_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cajaBonoFramework_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
