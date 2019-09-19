using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
      
        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(NilaiA.Text);
            var b = Convert.ToInt32(NilaiB.Text);

            lstHasil.Items.Clear();

            
            lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} : {1} = {2}", a, b, Pembagian(a, b)));
        }
    }
}
