using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_Bloco_de_Notas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Abre a caixa para salvar o arquivo assim que eu clicar em Salvar.
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        //Slava meu arquivo .txt
        private void Salvar_Ok(object sender, CancelEventArgs e)
        {
            /*Dentro do FileName, vai existir o caminho do diretório do arquivo, o nome do arquivo e sua extensão.*/
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, caixa_de_texto.Text);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Abre um arquivo.
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre uma janela para selecionar um arquivo.
                openFileDialog1.ShowDialog();               
                this.caixa_de_texto.Text = File.ReadAllText(openFileDialog1.FileName);
                 //Muda o nome da minha janela para o diretório do meu arquivo.
                this.Text = openFileDialog1.FileName; 
            }
            catch (Exception ex)
            {

            }
            finally
            {
                openFileDialog1 = null;
            }

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.caixa_de_texto.Font = fontDialog1.Font;
                }
            } 
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
