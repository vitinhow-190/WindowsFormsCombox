using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCombox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //add itens manualmente no ComboBox
            
            cboLista.Items.Add(txtTexto.Text);

            //Exibe a quantidade de itens no ComboBox
            lblQtde.Text = cboLista.Items.Count.ToString();

            //Limpa a caixa de texto
            txtTexto.Clear();

            //Move o foco para a caixa de texto
            txtTexto.Select();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Ativa a propriedade para ordena a lista no combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //remove o item selecionado no combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);

                //Exibe quantidade de itens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();

                //Limpa o texto da combo
                cboLista.ResetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //Exibe o conteudo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();

                //Exibe o indice (posição) do item no combo
                txtindice.Text = cboLista.SelectedItem.ToString();

            }
        }
    }
}
