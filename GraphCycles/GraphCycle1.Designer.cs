namespace GraphCycles
{
    partial class GraphCycle1
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
            this.GraphCycle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Сброс = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphCycle
            // 
            this.GraphCycle.BackColor = System.Drawing.Color.White;
            this.GraphCycle.Location = new System.Drawing.Point(12, 12);
            this.GraphCycle.Name = "GraphCycle";
            this.GraphCycle.Size = new System.Drawing.Size(600, 600);
            this.GraphCycle.TabIndex = 0;
            this.GraphCycle.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Horizontal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Сброс
            // 
            this.Сброс.Location = new System.Drawing.Point(537, 560);
            this.Сброс.Name = "Сброс";
            this.Сброс.Size = new System.Drawing.Size(75, 23);
            this.Сброс.TabIndex = 2;
            this.Сброс.Text = "Сброс";
            this.Сброс.UseVisualStyleBackColor = true;
            this.Сброс.Click += new System.EventHandler(this.Сброс_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vertical";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Diagonal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GraphCycle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 619);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Сброс);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GraphCycle);
            this.Name = "GraphCycle1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphCycle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphCycle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Сброс;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

