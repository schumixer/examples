﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      MyPoint t = new MyPoint(int.Parse(textBox1.Text));
      MyPoint t1 = new MyPoint(int.Parse(textBox2.Text));
      textBox4.Text= Convert.ToString(t.Sum(t1));
    }
  }
}
