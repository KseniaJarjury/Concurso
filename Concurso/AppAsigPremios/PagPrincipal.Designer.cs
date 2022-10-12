
namespace AppAsigPremios
{
    partial class PagPrincipal
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
            this.tipoSorteoCmb = new System.Windows.Forms.ComboBox();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.comenzarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Participante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoSorteoCmb
            // 
            this.tipoSorteoCmb.FormattingEnabled = true;
            this.tipoSorteoCmb.Items.AddRange(new object[] {
            "Ruleta",
            "Sorteo",
            "Distribución"});
            this.tipoSorteoCmb.Location = new System.Drawing.Point(81, 119);
            this.tipoSorteoCmb.Name = "tipoSorteoCmb";
            this.tipoSorteoCmb.Size = new System.Drawing.Size(121, 23);
            this.tipoSorteoCmb.TabIndex = 0;
            this.tipoSorteoCmb.SelectedIndexChanged += new System.EventHandler(this.tipoSorteoCmb_SelectedIndexChanged);
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("SimSun", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tituloLbl.Location = new System.Drawing.Point(61, 31);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(390, 64);
            this.tituloLbl.TabIndex = 1;
            this.tituloLbl.Text = "Concurso!!!";
            // 
            // comenzarBtn
            // 
            this.comenzarBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.comenzarBtn.Enabled = false;
            this.comenzarBtn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comenzarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comenzarBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.comenzarBtn.Location = new System.Drawing.Point(250, 113);
            this.comenzarBtn.Name = "comenzarBtn";
            this.comenzarBtn.Size = new System.Drawing.Size(102, 37);
            this.comenzarBtn.TabIndex = 2;
            this.comenzarBtn.Text = "Comenzar";
            this.comenzarBtn.UseVisualStyleBackColor = false;
            this.comenzarBtn.Click += new System.EventHandler(this.comenzar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Participante,
            this.Premio});
            this.dataGridView1.Location = new System.Drawing.Point(81, 175);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(621, 178);
            this.dataGridView1.TabIndex = 3;
            // 
            // Participante
            // 
            this.Participante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Participante.DataPropertyName = "Participante";
            this.Participante.HeaderText = "Participante";
            this.Participante.Name = "Participante";
            this.Participante.ReadOnly = true;
            // 
            // Premio
            // 
            this.Premio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Premio.DataPropertyName = "Premio";
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            this.Premio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(293, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PagPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comenzarBtn);
            this.Controls.Add(this.tituloLbl);
            this.Controls.Add(this.tipoSorteoCmb);
            this.Name = "PagPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoSorteoCmb;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Button comenzarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.Label label1;
    }
}

