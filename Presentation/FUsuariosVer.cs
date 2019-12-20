﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class FUsuariosVer : Form
    {
        public FUsuariosVer()
        {
            InitializeComponent();
            Usuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios()
        {
            UserModel user = new UserModel();
            user.MostrarUSuarios(dgvUsuarios);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Form crear = new FUsuarioCrear();
            crear.Show();
        }
    }
}