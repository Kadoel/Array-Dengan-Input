using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Dengan_Input
{
    public partial class Form1 : Form
    {
        string[] nama = new string[5];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            if (index < nama.Length)
            {
                nama[index] = tBNama.Text;
                lBNama.Items.Add(nama[index]);
                tBNama.Focus();
                index++;
            }
            else
            {
                MessageBox.Show("Batas Array Sudah Mencapai Maksimal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tBNama.Text = "";
        }
    }
}
