﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gọi hàm insert to DB
        }

        private void BtnSound_Click(object sender, EventArgs e)
        {
            Cow cow = new Cow();
            Sheep sheep = new Sheep();
            Goat goat = new Goat();
            string sound = "";
            if(Convert.ToInt32(TxtGoat.Text) >0)
            {
               sound+= sound + goat.GetSound();
            }
            if (Convert.ToInt32(TxtSheep.Text) >0)
            {
                sound+= sound + sheep.GetSound();
            }
            if (Convert.ToInt32(TxtCow.Text) >0)
            {
                sound+= sound + cow.GetSound();
            }

            MessageBox.Show("When Animal hungry: \n"+ sound);

        }

        private void BtnMilk_Click(object sender, EventArgs e)
        {
            int countCow = AnimalsBLL.Instance.CountMilkCow();
              int countSheep = AnimalsBLL.Instance.CountMilkSheep();
            int countGoat = AnimalsBLL.Instance.CountMilkGoat();
            MessageBox.Show(" Amount milk of Cows is: " + countCow);
            MessageBox.Show(" Amount milk of Sheep is: " + countSheep);
            MessageBox.Show(" Amount milk of Goat is: " + countGoat);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // gọi hàm Reset DB về 
        }

        private void BtnChild_Click(object sender, EventArgs e)
        {
           /* int countCow = AnimalsBLL.Instance.CountMilkCow();
            int countSheep = AnimalsBLL.Instance.CountMilkSheep();
            int countGoat = AnimalsBLL.Instance.CountMilkGoat();
            MessageBox.Show(" Amount milk of Cows is: " + countCow);
            MessageBox.Show(" Amount milk of Sheep is: " + countSheep);
            MessageBox.Show(" Amount milk of Goat is: " + countGoat);*/
        }
    }
}
