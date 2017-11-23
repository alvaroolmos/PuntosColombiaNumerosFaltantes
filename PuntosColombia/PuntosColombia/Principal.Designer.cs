namespace PuntosColombia
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblGrupoA = new System.Windows.Forms.Label();
            this.lblgrupoB = new System.Windows.Forms.Label();
            this.txtValoresListaA = new System.Windows.Forms.TextBox();
            this.txtValoresListaB = new System.Windows.Forms.TextBox();
            this.btnEvaluarListas = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupoA
            // 
            this.lblGrupoA.AutoSize = true;
            this.lblGrupoA.Location = new System.Drawing.Point(19, 23);
            this.lblGrupoA.Name = "lblGrupoA";
            this.lblGrupoA.Size = new System.Drawing.Size(46, 13);
            this.lblGrupoA.TabIndex = 0;
            this.lblGrupoA.Text = "Grupo A";
            // 
            // lblgrupoB
            // 
            this.lblgrupoB.AutoSize = true;
            this.lblgrupoB.Location = new System.Drawing.Point(19, 68);
            this.lblgrupoB.Name = "lblgrupoB";
            this.lblgrupoB.Size = new System.Drawing.Size(46, 13);
            this.lblgrupoB.TabIndex = 1;
            this.lblgrupoB.Text = "Grupo B";
            // 
            // txtValoresListaA
            // 
            this.txtValoresListaA.Location = new System.Drawing.Point(100, 20);
            this.txtValoresListaA.MaxLength = 3276700;
            this.txtValoresListaA.Name = "txtValoresListaA";
            this.txtValoresListaA.Size = new System.Drawing.Size(395, 20);
            this.txtValoresListaA.TabIndex = 2;
            // 
            // txtValoresListaB
            // 
            this.txtValoresListaB.Location = new System.Drawing.Point(100, 65);
            this.txtValoresListaB.MaxLength = 3276700;
            this.txtValoresListaB.Name = "txtValoresListaB";
            this.txtValoresListaB.Size = new System.Drawing.Size(395, 20);
            this.txtValoresListaB.TabIndex = 3;
            // 
            // btnEvaluarListas
            // 
            this.btnEvaluarListas.Location = new System.Drawing.Point(406, 119);
            this.btnEvaluarListas.Name = "btnEvaluarListas";
            this.btnEvaluarListas.Size = new System.Drawing.Size(89, 23);
            this.btnEvaluarListas.TabIndex = 1;
            this.btnEvaluarListas.Text = "Evaluar Listas";
            this.btnEvaluarListas.UseVisualStyleBackColor = true;
            this.btnEvaluarListas.Click += new System.EventHandler(this.btnEvaluarListas_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(22, 179);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(473, 159);
            this.txtMensaje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensajes al Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMensaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEvaluarListas);
            this.groupBox1.Controls.Add(this.lblGrupoA);
            this.groupBox1.Controls.Add(this.txtValoresListaB);
            this.groupBox1.Controls.Add(this.lblgrupoB);
            this.groupBox1.Controls.Add(this.txtValoresListaA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 378);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrupoA;
        private System.Windows.Forms.Label lblgrupoB;
        private System.Windows.Forms.TextBox txtValoresListaA;
        private System.Windows.Forms.TextBox txtValoresListaB;
        private System.Windows.Forms.Button btnEvaluarListas;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}