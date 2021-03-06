﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davefiles.add
{
    public partial class add_folder : Form
    {
        public add_folder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = textBox1.Text;
            string name = textBox2.Text;
            string path2 = path1 + "\\" + name;

            if (Directory.Exists(path2))
            {
                Form folder_e = new folder_exist();
                folder_e.ShowDialog();
            }
            else
            { 
                // create folder
                DirectoryInfo di = Directory.CreateDirectory(path2);
                Form good = new folder_right();
                good.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
