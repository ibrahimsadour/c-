namespace WindowsFormsApp1
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
            this.dgvmelding = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtzoek = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmelding)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmelding
            // 
            this.dgvmelding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmelding.Location = new System.Drawing.Point(12, 12);
            this.dgvmelding.Name = "dgvmelding";
            this.dgvmelding.RowTemplate.Height = 24;
            this.dgvmelding.Size = new System.Drawing.Size(627, 284);
            this.dgvmelding.TabIndex = 0;
            this.dgvmelding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmelding_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zoek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoek :  ";
            // 
            // txtzoek
            // 
            this.txtzoek.Location = new System.Drawing.Point(221, 318);
            this.txtzoek.Name = "txtzoek";
            this.txtzoek.Size = new System.Drawing.Size(213, 22);
            this.txtzoek.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtzoek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvmelding);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmelding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtzoek;
        private System.Windows.Forms.Button button2;
    }
}