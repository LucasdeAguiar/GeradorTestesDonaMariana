namespace GeradorTestes.WinApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.toolbox = new System.Windows.Forms.MenuStrip();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.toolbox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaToolStripMenuItem});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(718, 24);
            this.toolbox.TabIndex = 0;
            this.toolbox.Text = "menuStrip1";
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasMenuItem});
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.disciplinaToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasMenuItem
            // 
            this.disciplinasMenuItem.Name = "disciplinasMenuItem";
            this.disciplinasMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasMenuItem.Text = "Disciplinas";
            this.disciplinasMenuItem.Click += new System.EventHandler(this.disciplinasMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripButton4,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelRegistros
            // 
            this.panelRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistros.Location = new System.Drawing.Point(46, 63);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(616, 335);
            this.panelRegistros.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::GeradorTestes.WinApp.Properties.Resources.add;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(30, 30);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::GeradorTestes.WinApp.Properties.Resources.edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(30, 30);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::GeradorTestes.WinApp.Properties.Resources.remove;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(30, 30);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton4.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(44, 17);
            this.labelRodape.Text = "rodapé";
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(75, 30);
            this.labelTipoCadastro.Text = "tipoCadastro";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolbox);
            this.MainMenuStrip = this.toolbox;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Testes 1.0";
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolbox;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
    }
}
