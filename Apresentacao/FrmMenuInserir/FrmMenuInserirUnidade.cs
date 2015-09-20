﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenuInserirUnidade : Form
    {
        public FrmMenuInserirUnidade()
        {
            InitializeComponent();
        }

        private void buttonInserirUnidadeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuInserirUnidade_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserirUnidadeConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxInserirUnidadeNome.Text == "" || textBoxInserirUnidadeCidade.Text == ""
                || textBoxInserirUnidadeEstado.Text == "" || textBoxInserirUnidadePais.Text == "")
            {
                FrmInserirConfirmacaoProblema frmInserirConfirmacaoProblema = new FrmInserirConfirmacaoProblema();
                frmInserirConfirmacaoProblema.ShowDialog();
            }
            else
            {
                FrmInserirConfirmacaoSucesso frmInserirConfirmacaoSucesso = new FrmInserirConfirmacaoSucesso();
                frmInserirConfirmacaoSucesso.ShowDialog();
                this.Close();
            }
        }
    }
}
