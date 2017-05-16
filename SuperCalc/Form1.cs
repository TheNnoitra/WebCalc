using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalc
{
    public partial class Form1 : Form
    {

        private CalcLibrary.Calc Calc { get; set; }
        public Form1()
        {
            InitializeComponent();
            Calc = new CalcLibrary.Calc();

            CBOper.Items.AddRange(Calc.Operations.Select(o=>o.NameofOperation).ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            var x = TB1.Text;
            var y = TB2.Text;
            var oper = CBOper.Text;

            object result=null;
            try
            {
                result = Calc.Execute(oper, new object[] { x, y });
            }
            catch (DivideByZeroException ex)
            {
                Result.Text = $"DivideByZero{ex.Message}";
            }
            catch (Exception ex)
            {
                Result.Text = $"Error{ex.Message}";
            }
            if (result != null)
            {
                Result.Text = $"{x}{oper}{y}={result}";
            }


        }
    }
}
