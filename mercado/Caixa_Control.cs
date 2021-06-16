using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercado
{
    public partial class Caixa_Control : UserControl
    {
        //Declaração variávies globais
        double Subtotal, troco, valorrec;
        int totalItem;

        public Caixa_Control()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //declaração variáveis locais
            double valorUnit, total;
            int qtd;
            //atribui os valores para as variáveis
            qtd = Convert.ToInt32(txtQTD.Text);
            valorUnit = Convert.ToDouble(txtValorUnit.Text);
            //Calculamos o total, subtotal e o total de itens
            total = valorUnit * qtd;
            Subtotal += total;
            totalItem += qtd;
            //Adicionamos o produto no datagrid
            DGV_ListaPodutos.Rows.Insert(0, txtProduto.Text, txtValorUnit.Text,
                txtQTD.Text, total);
            //Mostramos o Subtotal.
            lblSubTotal.Text = Convert.ToString(Subtotal);
            //Mostramos o totoal de itens.
            lblTotItens.Text = Convert.ToString(totalItem);




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try
            {
                //Remove o tem selecionado
                DGV_ListaPodutos.Rows.RemoveAt(DGV_ListaPodutos.SelectedRows[0].Index);
            }
            catch (Exception)
            {
                //Mensagem de erro
                MessageBox.Show("Selecione um item para remover");
            }
            
        }

        private void txtValorRec_TextChanged(object sender, EventArgs e)
        {
           
            //tratamento de erro
            try
            {
                //atribuimos o valor recebido
                valorrec = Convert.ToDouble(txtValorRec.Text);
                //Calculamos o troco
                troco = valorrec - Subtotal;
                //Mostramos o valor
                txtTroco.Text = Convert.ToString(troco);
            }
            catch (Exception)
            {
                //Caso ocorra erro limpamos a caixa do troco
                txtTroco.Clear();
            }

           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Atribuomos 0 para as variáveis globias
            Subtotal = 0;
            totalItem = 0;
            valorrec = 0;
            troco = 0;
            //Limpamos o dataGrid
            DGV_ListaPodutos.Rows.Clear();
            //Limpamos a caixas de texto
            txtProduto.Clear();
            txtValorUnit.Clear();
            txtQTD.Clear();
            txtValorRec.Clear();
            txtTroco.Clear();
            //Mostramos o valor zerado para o total e total de itens 
            lblSubTotal.Text = Convert.ToString(Subtotal);
            lblTotItens.Text = Convert.ToString(totalItem);
           
            
        }
    }
}
