using CalcLibrary;
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

        private class OperationB
        {
            public OperationB(IOperation operation)
            {
                Operation = operation;
                var type = operation.GetType();
                var names = type.FullName.Split('.');
                
                BeautyName = $"{type.Name}.{operation}";
                
            }

            public IOperation Operation { get; set; }
            public string BeautyName { get; set; }
        }
        private Calc Calc { get; set; }

        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();

            CBOper.DataSource = Calc.Operations.Select(o=>new OperationB(o));
            CBOper.DisplayMember = "NameOfOperation";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = "";

            var oper = CBOper.Text;

            object result = null;
            var operB = CBOper.SelectedItem as OperationB;
            var moreArgs = CBOper.SelectedItem is IOperationArgs;
           

            var args = new List<object>();

            if (moreArgs)
            {
                // "1 2 3" => new string [] {"1", "2", "3"}
                args.AddRange(Result.Text.Split(' '));
            }
            else
            {
                var x = TB1.Text;
                var y = TB2.Text;
                args.Add(x);
                args.Add(y);
            }

            try
            {
                result = Calc.Execute(oper, args.ToArray());
            }
            catch (DivideByZeroException ex)
            {
                Result.Text = $"DivideByZero: {ex.Message}";
            }
            catch (Exception ex)
            {
                Result.Text = $"Error: {ex.Message}";
            }

            if (result != null)
            {
                Result.Text = $"{result}";
            }
        }

        private void CBOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            var moreArgs = CBOper.SelectedItem is IOperationArgs;
            var operB = CBOper.SelectedItem as OperationB;

            NewPanArgs.Visible = !moreArgs;
            PanArgs.Visible = moreArgs;
        }
    }

   

}
