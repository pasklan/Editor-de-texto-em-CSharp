
namespace Editor_de_texto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtCampo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnNovo = new System.Windows.Forms.ToolStripButton();
            this.mnAbrir = new System.Windows.Forms.ToolStripButton();
            this.mnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCopiar = new System.Windows.Forms.ToolStripButton();
            this.mnColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnNegrito = new System.Windows.Forms.ToolStripButton();
            this.mnItalico = new System.Windows.Forms.ToolStripButton();
            this.mnSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnAlinharDireita = new System.Windows.Forms.ToolStripButton();
            this.mnAlinharCentro = new System.Windows.Forms.ToolStripButton();
            this.mnAlinharEsquerda = new System.Windows.Forms.ToolStripButton();
            this.mnAlinharJustificado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnImprimir = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtCampo
            // 
            this.rtCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtCampo.Location = new System.Drawing.Point(0, 64);
            this.rtCampo.Name = "rtCampo";
            this.rtCampo.Size = new System.Drawing.Size(732, 504);
            this.rtCampo.TabIndex = 0;
            this.rtCampo.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editorToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.print;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.bold;
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.center_align;
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.left_align;
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.right_align;
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // justificarToolStripMenuItem
            // 
            this.justificarToolStripMenuItem.Image = global::Editor_de_texto.Properties.Resources.justify;
            this.justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            this.justificarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.justificarToolStripMenuItem.Text = "Justificar";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNovo,
            this.mnAbrir,
            this.mnSalvar,
            this.toolStripSeparator1,
            this.mnCopiar,
            this.mnColar,
            this.toolStripSeparator2,
            this.mnNegrito,
            this.mnItalico,
            this.mnSublinhado,
            this.toolStripSeparator3,
            this.mnAlinharEsquerda,
            this.mnAlinharCentro,
            this.mnAlinharDireita,
            this.mnAlinharJustificado,
            this.toolStripSeparator4,
            this.mnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnNovo
            // 
            this.mnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnNovo.Image = global::Editor_de_texto.Properties.Resources.file;
            this.mnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnNovo.Name = "mnNovo";
            this.mnNovo.Size = new System.Drawing.Size(23, 22);
            this.mnNovo.Text = "Novo";
            this.mnNovo.Click += new System.EventHandler(this.mnNovo_Click);
            // 
            // mnAbrir
            // 
            this.mnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnAbrir.Image = global::Editor_de_texto.Properties.Resources.folder;
            this.mnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnAbrir.Name = "mnAbrir";
            this.mnAbrir.Size = new System.Drawing.Size(23, 22);
            this.mnAbrir.Text = "Abrir";
            this.mnAbrir.Click += new System.EventHandler(this.mnAbrir_Click);
            // 
            // mnSalvar
            // 
            this.mnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSalvar.Image = global::Editor_de_texto.Properties.Resources.save;
            this.mnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSalvar.Name = "mnSalvar";
            this.mnSalvar.Size = new System.Drawing.Size(23, 22);
            this.mnSalvar.Text = "Salvar";
            this.mnSalvar.Click += new System.EventHandler(this.mnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnCopiar
            // 
            this.mnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnCopiar.Image = global::Editor_de_texto.Properties.Resources.copy;
            this.mnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnCopiar.Name = "mnCopiar";
            this.mnCopiar.Size = new System.Drawing.Size(23, 22);
            this.mnCopiar.Text = "Copiar";
            this.mnCopiar.Click += new System.EventHandler(this.mnCopiar_Click);
            // 
            // mnColar
            // 
            this.mnColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnColar.Image = global::Editor_de_texto.Properties.Resources.paste;
            this.mnColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnColar.Name = "mnColar";
            this.mnColar.Size = new System.Drawing.Size(23, 22);
            this.mnColar.Text = "Colar";
            this.mnColar.Click += new System.EventHandler(this.mnColar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnNegrito
            // 
            this.mnNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnNegrito.Image = global::Editor_de_texto.Properties.Resources.bold;
            this.mnNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnNegrito.Name = "mnNegrito";
            this.mnNegrito.Size = new System.Drawing.Size(23, 22);
            this.mnNegrito.Text = "Negrito";
            this.mnNegrito.Click += new System.EventHandler(this.mnNegrito_Click);
            // 
            // mnItalico
            // 
            this.mnItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnItalico.Image = global::Editor_de_texto.Properties.Resources.italic;
            this.mnItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnItalico.Name = "mnItalico";
            this.mnItalico.Size = new System.Drawing.Size(23, 22);
            this.mnItalico.Text = "Itálico";
            this.mnItalico.Click += new System.EventHandler(this.mnItalico_Click);
            // 
            // mnSublinhado
            // 
            this.mnSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSublinhado.Image = global::Editor_de_texto.Properties.Resources.underline;
            this.mnSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSublinhado.Name = "mnSublinhado";
            this.mnSublinhado.Size = new System.Drawing.Size(23, 22);
            this.mnSublinhado.Text = "Sublinhado";
            this.mnSublinhado.Click += new System.EventHandler(this.mnSublinhado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnAlinharDireita
            // 
            this.mnAlinharDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnAlinharDireita.Image = global::Editor_de_texto.Properties.Resources.right_align;
            this.mnAlinharDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnAlinharDireita.Name = "mnAlinharDireita";
            this.mnAlinharDireita.Size = new System.Drawing.Size(23, 22);
            this.mnAlinharDireita.Text = "Direita";
            this.mnAlinharDireita.Click += new System.EventHandler(this.mnAlinharDireita_Click);
            // 
            // mnAlinharCentro
            // 
            this.mnAlinharCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnAlinharCentro.Image = global::Editor_de_texto.Properties.Resources.center_align;
            this.mnAlinharCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnAlinharCentro.Name = "mnAlinharCentro";
            this.mnAlinharCentro.Size = new System.Drawing.Size(23, 22);
            this.mnAlinharCentro.Text = "Centralizar";
            this.mnAlinharCentro.Click += new System.EventHandler(this.mnAlinharCentro_Click);
            // 
            // mnAlinharEsquerda
            // 
            this.mnAlinharEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnAlinharEsquerda.Image = global::Editor_de_texto.Properties.Resources.left_align;
            this.mnAlinharEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnAlinharEsquerda.Name = "mnAlinharEsquerda";
            this.mnAlinharEsquerda.Size = new System.Drawing.Size(23, 22);
            this.mnAlinharEsquerda.Text = "Esquerda";
            this.mnAlinharEsquerda.Click += new System.EventHandler(this.mnAlinharEsquerda_Click);
            // 
            // mnAlinharJustificado
            // 
            this.mnAlinharJustificado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnAlinharJustificado.Image = global::Editor_de_texto.Properties.Resources.justify;
            this.mnAlinharJustificado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnAlinharJustificado.Name = "mnAlinharJustificado";
            this.mnAlinharJustificado.Size = new System.Drawing.Size(23, 22);
            this.mnAlinharJustificado.Text = "Justificar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnImprimir
            // 
            this.mnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnImprimir.Image = global::Editor_de_texto.Properties.Resources.print;
            this.mnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnImprimir.Name = "mnImprimir";
            this.mnImprimir.Size = new System.Drawing.Size(23, 22);
            this.mnImprimir.Text = "Imprimir";
            this.mnImprimir.Click += new System.EventHandler(this.mnImprimir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "(*.TXT)|*.txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 580);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtCampo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto em Rich-text";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtCampo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnNovo;
        private System.Windows.Forms.ToolStripButton mnAbrir;
        private System.Windows.Forms.ToolStripButton mnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnCopiar;
        private System.Windows.Forms.ToolStripButton mnColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnNegrito;
        private System.Windows.Forms.ToolStripButton mnItalico;
        private System.Windows.Forms.ToolStripButton mnSublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mnImprimir;
        private System.Windows.Forms.ToolStripButton mnAlinharDireita;
        private System.Windows.Forms.ToolStripButton mnAlinharCentro;
        private System.Windows.Forms.ToolStripButton mnAlinharEsquerda;
        private System.Windows.Forms.ToolStripButton mnAlinharJustificado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

