using Speech.src.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speech
{
    //-------------------------------------------------------------------------
    // Class: FrmMain
    // Description: This class is used to create the main form
    // Date: 11/12/2022
    //-------------------------------------------------------------------------
    public partial class FrmMain : Form
    {
        //-------------------------------------------------------------------------
        // Attributes
        //-------------------------------------------------------------------------
        CSpeech Speech;
        //-------------------------------------------------------------------------
        // Constructor: FrmMain
        // Description: This constructor is used to create the main form
        // Date: 11/12/2022
        //-------------------------------------------------------------------------
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {

        }
    }
}
