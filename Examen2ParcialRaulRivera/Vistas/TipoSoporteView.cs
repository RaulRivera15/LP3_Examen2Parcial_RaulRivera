﻿using Examen2ParcialRaulRivera.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2ParcialRaulRivera.Vistas
{
    public partial class TipoSoporteView : Form
    {
        public TipoSoporteView()
        {
            InitializeComponent();
           TipoSoporteController controller = new TipoSoporteController(this);
        }
    }
}