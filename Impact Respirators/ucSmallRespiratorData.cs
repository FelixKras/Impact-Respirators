using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impact_Respirators
{
    public partial class ucSmallRespiratorData : UserControl
    {
        int iIndex = 0;
        public ucSmallRespiratorData()
        {
            InitializeComponent();
        }


        public void SetNumber(int i)
        {
            lblMachineNum.Text = "machine number:" + i;
        }

        public void SetAlert(eAlertState e)
        {
            if (e == eAlertState.GREEN)
            {
                pnlAlertColor.BackColor = Color.LimeGreen;
            }

            if (e == eAlertState.GREY)
            {
                pnlAlertColor.BackColor = Color.Gray;
            }

            if (e == eAlertState.RED)
            {
                pnlAlertColor.BackColor = Color.Red;
            }
        }

        public delegate void dlgClickOnSmallRespiratorData(int iIndex);
        public event dlgClickOnSmallRespiratorData evClickOnSmallRespiratorData;

        private void pnlMainData_MouseClick(object sender, MouseEventArgs e)
        {
            if (evClickOnSmallRespiratorData != null) evClickOnSmallRespiratorData(iIndex);
        }
    }
}
