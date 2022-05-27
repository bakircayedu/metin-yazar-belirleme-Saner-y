using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MetinYazariBelirleme_200601021_SanerYesil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.ShowDialog();
        }

        private void btnHashOlustur_Click(object sender, EventArgs e)
        {
            HashTable<FileDialog,FileDialog> ht = new HashTable<FileDialog,FileDialog>();
        }
    }
}
