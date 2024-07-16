using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btVersionOk_Click(object sender, EventArgs e) {
            Close();
        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var now = DateTime.Now;
            var asi = new AssemblyInfo(Assembly.GetExecutingAssembly());
            var asm = Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            lbVersion.Text = "Ver." + ver.ToString();
            lbInfo.Text =asi.Copyright +" 2005-"+now.Year+" "+Application.CompanyName; 
        }
    }
}
