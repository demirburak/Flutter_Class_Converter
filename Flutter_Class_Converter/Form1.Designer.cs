
namespace Flutter_Class_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYardim = new System.Windows.Forms.Button();
            this.btnDonustur = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.PROPERTIES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnYardim);
            this.panel1.Controls.Add(this.btnDonustur);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "C# Model Name";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(516, 31);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(148, 22);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Clean";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.Location = new System.Drawing.Point(680, 30);
            this.btnYardim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(64, 22);
            this.btnYardim.TabIndex = 2;
            this.btnYardim.Text = "How To";
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // btnDonustur
            // 
            this.btnDonustur.Location = new System.Drawing.Point(363, 31);
            this.btnDonustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(148, 22);
            this.btnDonustur.TabIndex = 1;
            this.btnDonustur.Text = "Convert";
            this.btnDonustur.UseVisualStyleBackColor = true;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(11, 31);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(336, 23);
            this.txtModel.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROPERTIES});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv.Location = new System.Drawing.Point(0, 67);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(360, 329);
            this.dgv.TabIndex = 1;
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // PROPERTIES
            // 
            this.PROPERTIES.HeaderText = "PROPERTIES";
            this.PROPERTIES.MinimumWidth = 6;
            this.PROPERTIES.Name = "PROPERTIES";
            // 
            // txtMetin
            // 
            this.txtMetin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMetin.Location = new System.Drawing.Point(360, 67);
            this.txtMetin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(400, 329);
            this.txtMetin.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 396);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Converter C# Model To Flutter/Dart Class";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYardim;
        private System.Windows.Forms.Button btnDonustur;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPERTIES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
    }
}

