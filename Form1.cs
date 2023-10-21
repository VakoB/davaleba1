using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace დავალება1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mgzavrebis_raodenoba = int.Parse(textBox1.Text);
            int gayiduli_biletebis_raodenoba = int.Parse(textBox2.Text);
            Airplane airplane = new Airplane();
            airplane.mgzavrebis_raodenoba = mgzavrebis_raodenoba;
            airplane.gayiduli_biletebis_raodenoba = gayiduli_biletebis_raodenoba;
            string str = "მგზავრების რაოდენობა: " + airplane.mgzavrebis_raodenoba +
            "\nგაყიდული ბილეთების რაოდენობა: " + airplane.gayiduli_biletebis_raodenoba;
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string unis_dasaxeleba = textBox3.Text;
            int kursi = int.Parse(textBox4.Text);
            Student student = new Student();
            student.unis_dasaxleba = unis_dasaxeleba;
            student.kursi = kursi;
            string str = "უნის დასახელება: " + student.unis_dasaxleba +
            "\nკურსი: " + student.kursi;
            label2.Text = str;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double biletebis_fasi = double.Parse(textBox6.Text);
            int gayiduli_biletebis_raodenoba = int.Parse(textBox5.Text);
            Train train = new Train();
            train.biletis_fasi = biletebis_fasi;
            train.gayiduli_biletebis_raodenoba = gayiduli_biletebis_raodenoba;
            string str = "ბილეთების ფასი: " + train.biletis_fasi +
            "\nგაყიდული ბილეთების რაოდენობა: " + train.gayiduli_biletebis_raodenoba;
            label9.Text = str;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double side_1 = double.Parse(textBox8.Text);
            double side_2 = double.Parse(textBox7.Text);
            double side_3 = double.Parse(textBox11.Text);
            Samkutxedi samkutxedi = new Samkutxedi();
            samkutxedi.side_1 = side_1;
            samkutxedi.side_3 = side_3;
            samkutxedi.side_2 = side_2;
            string str = "გვერდი 1: " + samkutxedi.side_1 +
            "\nგვერდი 2: " + samkutxedi.side_2 +
            "\nგვერდი 3: " + samkutxedi.side_3;
            label12.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mflobelis_gvari = textBox10.Text;
            string gamoshvebis_firma = textBox9.Text;
            Avtomanqana avtomanqana = new Avtomanqana();
            avtomanqana.mflobelis_gvari = mflobelis_gvari;
            avtomanqana.gamomshvebi_firma = gamoshvebis_firma;
            string str = "მფლობელის გვარი: " + avtomanqana.mflobelis_gvari +
            "\nგამომშვები ფირმა: " + avtomanqana.gamomshvebi_firma;
            label15.Text = str;


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }


}
