using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLimparPalavra_Click(object sender, EventArgs e)
        {
            txtPalavra.Clear(); //comando para limpar uma caixa de texto ao apertar o botão
            cboDropDownList.SelectedIndex = -1; //Comando para selecionar todas as opções do combobox e limpá-los
            txtPosItem.Clear();
            txtTotal.Clear();
            txtTextoSel.Clear();

            txtPalavra.Focus(); //Comando para fazer o cursor piscar na textBox
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboDropDownList.Items.Add(txtPalavra.Text); //Pega a palavra de um textbox e adiciona na combobox como um dos itens
            txtPalavra.Clear();
            txtPalavra.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cboDropDownList.SelectedIndex == -1) //Verifica se o combobox está com alguma opção selecionada, o -1 refere-se a não estar
            {
                MessageBox.Show("Nenhum item selecionado", "Combo", MessageBoxButtons.OK, MessageBoxIcon.Information);  //Se não, aparece uma mensagem de erro
            }
            else //Se estiver tudo certo
            {
                cboDropDownList.Items.RemoveAt(cboDropDownList.SelectedIndex); //remove a opção selecionada no combobox
                txtPosItem.Clear(); //Limpa o restante das textbox
                txtTextoSel.Clear();
                txtTotal.Clear();
            }
        }
    }
}
