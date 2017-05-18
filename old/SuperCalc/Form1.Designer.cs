namespace SuperCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.CBOper = new System.Windows.Forms.ComboBox();
            this.SelOperation = new System.Windows.Forms.Label();
            this.PanArgs = new System.Windows.Forms.Panel();
            this.NewPanArgs = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanArgs.SuspendLayout();
            this.NewPanArgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(50, 0);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 1;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(50, 45);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 20);
            this.TB2.TabIndex = 2;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(43, 26);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(0, 13);
            this.LBL1.TabIndex = 4;
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Location = new System.Drawing.Point(199, 26);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(0, 13);
            this.LBL2.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(62, 141);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(21, 13);
            this.Result.TabIndex = 6;
            this.Result.Text = "res";
            // 
            // CBOper
            // 
            this.CBOper.FormattingEnabled = true;
            this.CBOper.Location = new System.Drawing.Point(356, 10);
            this.CBOper.Name = "CBOper";
            this.CBOper.Size = new System.Drawing.Size(121, 21);
            this.CBOper.TabIndex = 7;
            this.CBOper.SelectedIndexChanged += new System.EventHandler(this.CBOper_SelectedIndexChanged);
            // 
            // SelOperation
            // 
            this.SelOperation.AutoSize = true;
            this.SelOperation.Location = new System.Drawing.Point(276, 13);
            this.SelOperation.Name = "SelOperation";
            this.SelOperation.Size = new System.Drawing.Size(71, 13);
            this.SelOperation.TabIndex = 8;
            this.SelOperation.Text = "Sel Operation";
            // 
            // PanArgs
            // 
            this.PanArgs.Controls.Add(this.TB1);
            this.PanArgs.Controls.Add(this.TB2);
            this.PanArgs.Location = new System.Drawing.Point(15, 26);
            this.PanArgs.Name = "PanArgs";
            this.PanArgs.Size = new System.Drawing.Size(200, 100);
            this.PanArgs.TabIndex = 9;
            this.PanArgs.Visible = false;
            // 
            // NewPanArgs
            // 
            this.NewPanArgs.Controls.Add(this.textBox1);
            this.NewPanArgs.Location = new System.Drawing.Point(18, 173);
            this.NewPanArgs.Name = "NewPanArgs";
            this.NewPanArgs.Size = new System.Drawing.Size(200, 100);
            this.NewPanArgs.TabIndex = 10;
            this.NewPanArgs.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 52);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 294);
            this.Controls.Add(this.NewPanArgs);
            this.Controls.Add(this.PanArgs);
            this.Controls.Add(this.SelOperation);
            this.Controls.Add(this.CBOper);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanArgs.ResumeLayout(false);
            this.PanArgs.PerformLayout();
            this.NewPanArgs.ResumeLayout(false);
            this.NewPanArgs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.ComboBox CBOper;
        private System.Windows.Forms.Label SelOperation;
        private System.Windows.Forms.Panel PanArgs;
        private System.Windows.Forms.Panel NewPanArgs;
        private System.Windows.Forms.TextBox textBox1;
    }
}

