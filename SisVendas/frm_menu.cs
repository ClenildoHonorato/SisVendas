using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm_produtos = new frm_Produtos();
            frm_produtos.Show();
        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_Categorias frm_Categorias = new frm_Categorias();
            frm_Categorias.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produtos frm_produtos = new frm_Produtos();
            frm_produtos.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categorias frm_categorias = new frm_Categorias();
            frm_categorias.Show();
        }
    }
}
