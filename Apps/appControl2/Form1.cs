using System;
using System.Windows.Forms;

namespace apps
{
    public partial class Form1 : Form
    {
        private int intentos = 3;
        private int contadorClicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // -------------------- LOGIN --------------------
        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = ctUsuario.Text.Trim();
            string pass = ctPass.Text.Trim();

            if (user == "admin" && pass == "123qwe")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                intentos--;
                MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {intentos}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctUsuario.Clear();
                ctPass.Clear();

                if (intentos == 0)
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos", "Bloqueado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close(); // 🔹 se cierra el formulario
                }
            }
        }

        // -------------------- CONVERSIONES --------------------
        // -------------------- VALIDACIÓN DE NÚMEROS --------------------
        private void SoloNumerosConDecimal(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txt.Text.Contains(".")) return;

            e.Handled = true;
        }

        private void ctPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosConDecimal(e, ctPeso);
        }

        private void ctAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosConDecimal(e, ctAltura);
        }

        private void ctFahrenheit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosConDecimal(e, ctFahrenheit1);
        }

        private void ctCelsius1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosConDecimal(e, ctCelsius1);
        }
        private void btFaC_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ctFahrenheit1.Text, out decimal f))
            {
                decimal c = (f - 32) * 5 / 9;
                ctCelsius2.Text = c.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingresa un valor válido en Fahrenheit.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCaF_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ctCelsius1.Text, out decimal c))
            {
                decimal f = (c * 9 / 5) + 32;
                ctFahrenheit2.Text = f.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingresa un valor válido en Celsius.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------- CLICK COUNTER --------------------
        private void btContador_Click(object sender, EventArgs e)
        {
            contadorClicks++;
            lClicks.Text = $"__{contadorClicks}__";
        }

        // -------------------- IMC --------------------
        private void BtCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ctPeso.Text, out decimal pesoKg) &&
                decimal.TryParse(ctAltura.Text, out decimal alturaM))
            {
                if (alturaM <= 0)
                {
                    MessageBox.Show("La altura debe ser mayor que cero.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal imc = pesoKg / (alturaM * alturaM);
                IMC.Text = "IMC: " + imc.ToString("0.00");

                if (imc < 18.5m)
                    lClasificacion.Text = "Bajo peso";
                else if (imc < 25m)
                    lClasificacion.Text = "Peso normal";
                else if (imc < 30m)
                    lClasificacion.Text = "Sobrepeso";
                else
                    lClasificacion.Text = "Obesidad";
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores válidos en Kg y Metros.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
