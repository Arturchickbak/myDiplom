namespace diplom
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.form5BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Электричество",
            "Газ",
            "Вода"});
            this.comboBox1.Location = new System.Drawing.Point(49, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(112, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 293);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Счета";
            // 
            // form5BindingSource2
            // 
            this.form5BindingSource2.DataSource = typeof(diplom.Form5);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(diplom.Program);
            // 
            // form5BindingSource
            // 
            this.form5BindingSource.DataSource = typeof(diplom.Form5);
            // 
            // form5BindingSource1
            // 
            this.form5BindingSource1.DataSource = typeof(diplom.Form5);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.Controls.Add(this.panel3);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form5BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource form5BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form5BindingSource1;
        private System.Windows.Forms.BindingSource form5BindingSource2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}