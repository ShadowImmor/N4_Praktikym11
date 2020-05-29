namespace Задание_1_г
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
            this.Xlabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.ShowCordlable = new System.Windows.Forms.Label();
            this.ZadCordbutton = new System.Windows.Forms.Button();
            this.Raslabel = new System.Windows.Forms.Label();
            this.Ras = new System.Windows.Forms.TextBox();
            this.RasNachDoToch = new System.Windows.Forms.Button();
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.Scalarlabel = new System.Windows.Forms.Label();
            this.PerVectorbutton = new System.Windows.Forms.Button();
            this.Scalar = new System.Windows.Forms.NumericUpDown();
            this.CordPointgroupBox = new System.Windows.Forms.GroupBox();
            this.VectorgroupBox = new System.Windows.Forms.GroupBox();
            this.YmnScalar = new System.Windows.Forms.Button();
            this.ShowCord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scalar)).BeginInit();
            this.CordPointgroupBox.SuspendLayout();
            this.VectorgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xlabel.Location = new System.Drawing.Point(5, 34);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(122, 28);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "Абциса, x";
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(177, 26);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 36);
            this.X.TabIndex = 1;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ylabel.Location = new System.Drawing.Point(5, 77);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(150, 28);
            this.Ylabel.TabIndex = 2;
            this.Ylabel.Text = "Ордината, y";
            // 
            // Y
            // 
            this.Y.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(177, 75);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 36);
            this.Y.TabIndex = 3;
            // 
            // ShowCordlable
            // 
            this.ShowCordlable.AutoSize = true;
            this.ShowCordlable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCordlable.Location = new System.Drawing.Point(27, 402);
            this.ShowCordlable.Name = "ShowCordlable";
            this.ShowCordlable.Size = new System.Drawing.Size(234, 28);
            this.ShowCordlable.TabIndex = 5;
            this.ShowCordlable.Text = "Координаты точки:";
            // 
            // ZadCordbutton
            // 
            this.ZadCordbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZadCordbutton.Location = new System.Drawing.Point(10, 122);
            this.ZadCordbutton.Name = "ZadCordbutton";
            this.ZadCordbutton.Size = new System.Drawing.Size(267, 60);
            this.ZadCordbutton.TabIndex = 6;
            this.ZadCordbutton.Text = "Задать координаты";
            this.ZadCordbutton.UseVisualStyleBackColor = true;
            this.ZadCordbutton.Click += new System.EventHandler(this.ZadCordbutton_Click);
            // 
            // Raslabel
            // 
            this.Raslabel.AutoSize = true;
            this.Raslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raslabel.Location = new System.Drawing.Point(27, 288);
            this.Raslabel.Name = "Raslabel";
            this.Raslabel.Size = new System.Drawing.Size(489, 28);
            this.Raslabel.TabIndex = 7;
            this.Raslabel.Text = "Расстояние от начала координат до точки";
            // 
            // Ras
            // 
            this.Ras.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ras.Location = new System.Drawing.Point(537, 285);
            this.Ras.Name = "Ras";
            this.Ras.ReadOnly = true;
            this.Ras.Size = new System.Drawing.Size(167, 36);
            this.Ras.TabIndex = 8;
            // 
            // RasNachDoToch
            // 
            this.RasNachDoToch.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RasNachDoToch.Location = new System.Drawing.Point(251, 222);
            this.RasNachDoToch.Name = "RasNachDoToch";
            this.RasNachDoToch.Size = new System.Drawing.Size(308, 55);
            this.RasNachDoToch.TabIndex = 9;
            this.RasNachDoToch.Text = "Рассчитать расстояние";
            this.RasNachDoToch.UseVisualStyleBackColor = true;
            this.RasNachDoToch.Click += new System.EventHandler(this.RasNachDoToch_Click);
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alabel.Location = new System.Drawing.Point(28, 34);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(24, 28);
            this.Alabel.TabIndex = 10;
            this.Alabel.Text = "a";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blabel.Location = new System.Drawing.Point(28, 77);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(25, 28);
            this.Blabel.TabIndex = 11;
            this.Blabel.Text = "b";
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(129, 32);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 36);
            this.A.TabIndex = 12;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(129, 75);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 36);
            this.B.TabIndex = 13;
            // 
            // Scalarlabel
            // 
            this.Scalarlabel.AutoSize = true;
            this.Scalarlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scalarlabel.Location = new System.Drawing.Point(27, 345);
            this.Scalarlabel.Name = "Scalarlabel";
            this.Scalarlabel.Size = new System.Drawing.Size(94, 28);
            this.Scalarlabel.TabIndex = 14;
            this.Scalarlabel.Text = "Скаляр";
            // 
            // PerVectorbutton
            // 
            this.PerVectorbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PerVectorbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerVectorbutton.Location = new System.Drawing.Point(6, 122);
            this.PerVectorbutton.Name = "PerVectorbutton";
            this.PerVectorbutton.Size = new System.Drawing.Size(288, 70);
            this.PerVectorbutton.TabIndex = 15;
            this.PerVectorbutton.Text = "Переместить точку на вектор";
            this.PerVectorbutton.UseVisualStyleBackColor = true;
            this.PerVectorbutton.Click += new System.EventHandler(this.PerVectorbutton_Click);
            // 
            // Scalar
            // 
            this.Scalar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scalar.Location = new System.Drawing.Point(167, 343);
            this.Scalar.Name = "Scalar";
            this.Scalar.Size = new System.Drawing.Size(100, 36);
            this.Scalar.TabIndex = 16;
            // 
            // CordPointgroupBox
            // 
            this.CordPointgroupBox.Controls.Add(this.Xlabel);
            this.CordPointgroupBox.Controls.Add(this.Ylabel);
            this.CordPointgroupBox.Controls.Add(this.X);
            this.CordPointgroupBox.Controls.Add(this.Y);
            this.CordPointgroupBox.Controls.Add(this.ZadCordbutton);
            this.CordPointgroupBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CordPointgroupBox.Location = new System.Drawing.Point(22, 16);
            this.CordPointgroupBox.Name = "CordPointgroupBox";
            this.CordPointgroupBox.Size = new System.Drawing.Size(300, 200);
            this.CordPointgroupBox.TabIndex = 17;
            this.CordPointgroupBox.TabStop = false;
            this.CordPointgroupBox.Text = "Координаты точки";
            // 
            // VectorgroupBox
            // 
            this.VectorgroupBox.Controls.Add(this.Alabel);
            this.VectorgroupBox.Controls.Add(this.Blabel);
            this.VectorgroupBox.Controls.Add(this.A);
            this.VectorgroupBox.Controls.Add(this.PerVectorbutton);
            this.VectorgroupBox.Controls.Add(this.B);
            this.VectorgroupBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorgroupBox.Location = new System.Drawing.Point(466, 16);
            this.VectorgroupBox.Name = "VectorgroupBox";
            this.VectorgroupBox.Size = new System.Drawing.Size(300, 200);
            this.VectorgroupBox.TabIndex = 18;
            this.VectorgroupBox.TabStop = false;
            this.VectorgroupBox.Text = "Вектор";
            // 
            // YmnScalar
            // 
            this.YmnScalar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YmnScalar.Location = new System.Drawing.Point(307, 327);
            this.YmnScalar.Name = "YmnScalar";
            this.YmnScalar.Size = new System.Drawing.Size(435, 64);
            this.YmnScalar.TabIndex = 19;
            this.YmnScalar.Text = "Умножить координаты на скаляр ";
            this.YmnScalar.UseVisualStyleBackColor = true;
            this.YmnScalar.Click += new System.EventHandler(this.YmnScalar_Click);
            // 
            // ShowCord
            // 
            this.ShowCord.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCord.Location = new System.Drawing.Point(285, 399);
            this.ShowCord.Name = "ShowCord";
            this.ShowCord.ReadOnly = true;
            this.ShowCord.Size = new System.Drawing.Size(193, 36);
            this.ShowCord.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowCord);
            this.Controls.Add(this.YmnScalar);
            this.Controls.Add(this.VectorgroupBox);
            this.Controls.Add(this.CordPointgroupBox);
            this.Controls.Add(this.Scalar);
            this.Controls.Add(this.Scalarlabel);
            this.Controls.Add(this.RasNachDoToch);
            this.Controls.Add(this.Ras);
            this.Controls.Add(this.Raslabel);
            this.Controls.Add(this.ShowCordlable);
            this.Name = "Form1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scalar)).EndInit();
            this.CordPointgroupBox.ResumeLayout(false);
            this.CordPointgroupBox.PerformLayout();
            this.VectorgroupBox.ResumeLayout(false);
            this.VectorgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.Label ShowCordlable;
        private System.Windows.Forms.Button ZadCordbutton;
        private System.Windows.Forms.Label Raslabel;
        private System.Windows.Forms.TextBox Ras;
        private System.Windows.Forms.Button RasNachDoToch;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.NumericUpDown A;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.Label Scalarlabel;
        private System.Windows.Forms.Button PerVectorbutton;
        private System.Windows.Forms.NumericUpDown Scalar;
        private System.Windows.Forms.GroupBox CordPointgroupBox;
        private System.Windows.Forms.GroupBox VectorgroupBox;
        private System.Windows.Forms.Button YmnScalar;
        private System.Windows.Forms.TextBox ShowCord;
    }
}

