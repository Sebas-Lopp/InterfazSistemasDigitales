using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace InterfazSistemasDigitales
{
    public partial class Form1 : Form
    {
        private SerialPort ArduinoPort;

        public Form1()
        {
            InitializeComponent();

            // Configuración del puerto serie
            ArduinoPort = new SerialPort("COM7", 9600);
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            ArduinoPort.Open();
            this.FormClosing += Form1_FormClosing;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = ArduinoPort.ReadLine(); // Leer datos desde el Arduino
                this.Invoke(new Action(() => ProcessData(data))); // Asegurar actualización en UI thread
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en recepción de datos: {ex.Message}");
            }
        }

        private void ProcessData(string data)
        {
            lblDatosRecibidos.Text = data; // Muestra la línea de datos recibida para depuración

            if (data.Contains("ALERTA")) lblHumo.Text = "🚨 ¡Humo Detectado!";
            else lblHumo.Text = "✅ Aire limpio";

            if (data.Contains("Objeto detectado")) lblObjeto.Text = "👀 Objeto cerca!";
            else lblObjeto.Text = "✅ Área despejada";

            if (data.Contains("Piso 1")) lblPiso.Text = "🏢 Piso 1";
            else if (data.Contains("Segundo piso")) lblPiso.Text = "🏢 Piso 2";
            else if (data.Contains("Piso 3")) lblPiso.Text = "🏢 Piso 3";
            else lblPiso.Text = "❌ Fuera de rango";
        }

        private void btnServo_Click(object sender, EventArgs e)
        {
            ArduinoPort.WriteLine("SERVO");
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            ArduinoPort.WriteLine("ADELANTE");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ArduinoPort.WriteLine("ATRAS");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void lblDatosRecibidos_Click(object sender, EventArgs e)
        {

        }
    }
}