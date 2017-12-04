using ManejoDatos;
using System;
using System.Windows.Forms;


namespace SIVIGILA_EDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String FechaInicial;
        String FechaFinal;
        Consulta oConsulta = new Consulta();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            FechaInicial = dateTimePicker1.Value.ToString("yyyyMMdd");
            FechaFinal = dateTimePicker2.Value.ToString("yyyyMMdd");

            txtMenores1.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "0 MENORES DE UN AÑO");

            txt1a4.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "1 A 4");

            txt5a9.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "5 A 9");

            txt10a14.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "10 A 14");

            txt15a19.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "15 A 19");

            txt20a24.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "20 A 24");

            txt25a29.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "25 A 29");

            txt30a34.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "30 A 34");

            txt35a39.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "35 A 39");

            txt40a44.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "40 A 44");

            txt45a49.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "45 A 49");

            txt50a54.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "50 A 54");

            txt55a59.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "55 A 59");

            txt60a64.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "60 A 64");

            txt65a69.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "65 A 69");

            txt70a74.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "70 A 74");

            txt75a79.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "75 A 79");

            txtMas80.Text = oConsulta.GetEDAGrupo(FechaInicial, FechaFinal, "80 Y MAS");

            txtTotal.Text = oConsulta.GetTotalSP(FechaInicial, FechaFinal);

            txtMujeres.Text = oConsulta.GetTotalSexo(FechaInicial, FechaFinal, "F");

            txtHombres.Text = oConsulta.GetTotalSexo(FechaInicial, FechaFinal, "M");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
