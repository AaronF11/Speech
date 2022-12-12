using Speech.src.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
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
        private CSpeech Speech;
        private bool IsActivated;

        //-------------------------------------------------------------------------
        // Constructor: FrmMain
        // Description: This constructor is used to create the main form
        // Date: 11/12/2022
        //-------------------------------------------------------------------------
        public FrmMain()
        {
            InitializeComponent();
            Speech = new CSpeech();
            IsActivated = false;
        }

        //-------------------------------------------------------------------------
        // Method: BtnActivate_Click
        // Description: This method is used to activate the speech recognition
        // Date: 12/12/2022
        //-------------------------------------------------------------------------
        private void BtnActivate_Click(object sender, EventArgs e)
        {
            if (!IsActivated)
            {
                Speech.Activate();
                Speech.SpeechRecognized += Detection;
                IsActivated = true;
            }
        }

        //-------------------------------------------------------------------------
        // Method: Detection
        // Description: This method is used to detect the speech
        // Date: 12/12/2022
        //-------------------------------------------------------------------------
        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {
            TxtText.Text = e.Result.Text;
        }

        //-------------------------------------------------------------------------
        // Method: BtnDeactivate_Click
        // Description: This method is used to deactivate the speech recognition
        // Date: 12/12/2022
        //-------------------------------------------------------------------------
        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            if (IsActivated)
            {
                Speech.Deactivate();
                IsActivated = false;
            }
        }
    }
}
