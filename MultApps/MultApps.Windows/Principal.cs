using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void MeunuCalculadoraImc_Click(object sender, EventArgs e)
        {
            var form = new FrmCalculadoraIMC();
            form.ShowDialog();  
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }


        private void MDIPrincipal_Shown(object sender, EventArgs e)
        {
            var loading = new FrmSplashScreen();
            loading.ShowDialog();
        }
    }
}
