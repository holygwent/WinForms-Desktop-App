
namespace kolko_krzyzyk_p4_zaliczenie
{
    partial class Wyniki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyniki));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSortuj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.textBoxGr = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataTable1TableAdapter1 = new kolko_krzyzyk_p4_zaliczenie.DataSet.WynikiTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSortuj
            // 
            this.btnSortuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortuj.Location = new System.Drawing.Point(417, 66);
            this.btnSortuj.Name = "btnSortuj";
            this.btnSortuj.Size = new System.Drawing.Size(135, 31);
            this.btnSortuj.TabIndex = 1;
            this.btnSortuj.Text = "Sortuj";
            this.btnSortuj.UseVisualStyleBackColor = true;
            this.btnSortuj.Click += new System.EventHandler(this.btnSortuj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(12, 70);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(136, 31);
            this.btnSzukaj.TabIndex = 2;
            this.btnSzukaj.Text = "Szukaj Gracza";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGr
            // 
            this.textBoxGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGr.Location = new System.Drawing.Point(154, 70);
            this.textBoxGr.Name = "textBoxGr";
            this.textBoxGr.Size = new System.Drawing.Size(177, 27);
            this.textBoxGr.TabIndex = 4;
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(12, 12);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(136, 31);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usun z ID";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(154, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(83, 27);
            this.numericUpDown1.TabIndex = 7;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // Wyniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(564, 511);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.textBoxGr);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnSortuj);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wyniki";
            this.Text = "Wyniki";
            this.Load += new System.EventHandler(this.Wyniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet.WynikiTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.Button btnSortuj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox textBoxGr;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}