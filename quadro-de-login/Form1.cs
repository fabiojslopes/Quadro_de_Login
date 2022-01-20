using System;
using System.Windows.Forms;

namespace quadro_de_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = false;
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = text_usuario.Text != "" && text_senha.Text != "" ? true : false;
        }

        private void text_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cmd_entrar_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_senha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            if (!cmd_entrar.Enabled) return;
            MessageBox.Show("Sucesso!");
        }
    }
}
