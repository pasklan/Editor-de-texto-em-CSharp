using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Editor_de_texto
{
    public partial class frmPrincipal : Form
    {
        StringReader leitura = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.rtCampo.Text;
            leitura = new StringReader(texto);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void AlinharEsquerda()
        {
            rtCampo.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharDireita()
        {
            rtCampo.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Centralizar()
        {
            rtCampo.SelectionAlignment = HorizontalAlignment.Center;
        }


        private void Sublinhado()
        {
            string fontName = null;
            float fontSize = 0;
            bool n, i, s = false;

            fontName = rtCampo.Font.Name;
            fontSize = rtCampo.Font.Size;
            n = rtCampo.SelectionFont.Bold;
            i = rtCampo.SelectionFont.Italic;
            s = rtCampo.SelectionFont.Underline;

            rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);

            if (s == false)
            {
                if (n == true & i == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline | FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == false & n == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                }
            }
            else
            {
                if (i == true & n == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                }
                else if (i == true & n == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                }
            }
        }

        private void Italico()
        {
            string fontName = null;
            float fontSize = 0;
            bool n, i, s = false;

            fontName = rtCampo.Font.Name;
            fontSize = rtCampo.Font.Size;
            n = rtCampo.SelectionFont.Bold;
            i = rtCampo.SelectionFont.Italic;
            s = rtCampo.SelectionFont.Underline;

            rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                }
            }
        }

        private void Negrito()
        {
            string fontName = null;
            float fontSize = 0;
            bool n, i, s = false;

            fontName = rtCampo.Font.Name;
            fontSize = rtCampo.Font.Size;
            n = rtCampo.SelectionFont.Bold;
            i = rtCampo.SelectionFont.Italic;
            s = rtCampo.SelectionFont.Underline;

            rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);

            if (n == false)
            {
                if(i == true & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if(i == false & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);
                }
                else if(i == false & s == false){
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    rtCampo.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                }
            }
           
        }

        private void Copiar()
        {
            if(rtCampo.SelectionLength > 0)
            {
                rtCampo.Copy();
            }
        }

        private void Colar()
        {
            rtCampo.Paste();
        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";
            try
            {

                if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader txt_streamReader = new StreamReader(arquivo);
                    txt_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.rtCampo.Text = "";
                    string linha = txt_streamReader.ReadLine();
                    while(linha != null)
                    {
                        this.rtCampo.Text += linha + "\n";
                        linha = txt_streamReader.ReadLine();
                        txt_streamReader.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao abrir: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Novo()
        {
            rtCampo.Clear();
            rtCampo.Focus();
        }

        private void Salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter txt_StreamWriter = new StreamWriter(arquivo);
                    txt_StreamWriter.Flush();
                    txt_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    txt_StreamWriter.Write(this.rtCampo.Text);
                    txt_StreamWriter.Flush();
                    txt_StreamWriter.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void mnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void mnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void mnCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void mnColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void mnNegrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void mnItalico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void mnSublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void mnAlinharEsquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void mnAlinharCentro_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void mnAlinharDireita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void mnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float posY = 0;
            int cont = 0;
            float margimEsq = e.MarginBounds.Left - 50;
            float margimSup = e.MarginBounds.Top - 50;
            string linha = null;
            if(margimEsq < 5)
            {
                margimEsq = 20;
            }
            if(margimSup < 5)
            {
                margimSup = 20;
            }

            Font fonte = this.rtCampo.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhasPagina)
            {
                posY = (margimSup + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margimEsq, posY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if(linha != null)       
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }
    }
}
