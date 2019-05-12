﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(   );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            this.chart1.Series[0].Name = "教师001";
            this.chart1.Series[1].Name = "学生002";
            for (int i = 1; i < 12; i++)
            {
                this.chart1.Series[0].Points.AddXY(i, random.Next(100));
                this.chart1.Series[1].Points.AddXY(i, random.Next(100));
                this.chart2.Series[0].Points.AddXY(i, random.Next(100));
            }
            double[] yValues = { 65.62, 75.54, 
                                   60.45, 55.73, 70.42 };
            string[] xValues = { "FranceAAA", "CanadaContry", "UK-001",
                                   "USA-contour", "Italy-island" };            
            this.chart3.Series[0].CustomProperties = "DoughnutRadius=60, PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            this.chart3.Series[0].Label = "#PERCENT";
            this.chart3.Series[0]["PieLabelStyle"] = "Inside";
            this.chart3.Series[0].Points.DataBindXY(xValues, yValues);
        }
    }
}
