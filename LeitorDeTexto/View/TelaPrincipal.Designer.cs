
namespace LeitorDeTexto.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btxLer = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btxLer
            // 
            this.btxLer.Location = new System.Drawing.Point(116, 133);
            this.btxLer.Name = "btxLer";
            this.btxLer.Size = new System.Drawing.Size(535, 23);
            this.btxLer.TabIndex = 0;
            this.btxLer.Text = "Ler";
            this.btxLer.UseVisualStyleBackColor = true;
            this.btxLer.Click += new System.EventHandler(this.btxLer_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(285, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Leitor de texto com informações delimitadas";
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 15;
            this.lbxInfo.Location = new System.Drawing.Point(116, 184);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(535, 244);
            this.lbxInfo.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btxLer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Leitor de texto Delimitados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxLer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lbxInfo;
    }
}