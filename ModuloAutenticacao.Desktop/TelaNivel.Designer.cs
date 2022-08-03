namespace ModuloAutenticacao.Desktop
{
    partial class TelaNivel
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
            this.txtID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNomeK = new System.Windows.Forms.TextBox();
            this.dgvNivel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(84, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome.Location = new System.Drawing.Point(84, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(35, 13);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(230, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(201, 48);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.txtCadastrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtNomeK
            // 
            this.txtNomeK.Location = new System.Drawing.Point(125, 84);
            this.txtNomeK.Name = "txtNomeK";
            this.txtNomeK.Size = new System.Drawing.Size(422, 20);
            this.txtNomeK.TabIndex = 4;
            // 
            // dgvNivel
            // 
            this.dgvNivel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivel.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNivel.Location = new System.Drawing.Point(87, 209);
            this.dgvNivel.Name = "dgvNivel";
            this.dgvNivel.Size = new System.Drawing.Size(495, 171);
            this.dgvNivel.TabIndex = 5;
            this.dgvNivel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNivel_CellContentClick);
            // 
            // TelaNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 411);
            this.Controls.Add(this.dgvNivel);
            this.Controls.Add(this.txtNomeK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TelaNivel";
            this.Text = "TelaNivel";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNomeK;
        private System.Windows.Forms.DataGridView dgvNivel;
    }
}