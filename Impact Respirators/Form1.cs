using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impact_Respirators
{
    public partial class Form1 : Form
    {
        cMachineData[] o1MachineData;
        ucSmallRespiratorData[] o1SmallRespiratorData;

        public Form1()
        {
            InitializeComponent();
            
            o1MachineData = new cMachineData[48];
            for (int i = 0; i < 48; i++)
            {
                o1MachineData[i] = new cMachineData();
                o1MachineData[i].SetNumber(i);
                o1MachineData[i].bAlertState = eAlertState.GREY;
            }

            o1SmallRespiratorData = new ucSmallRespiratorData[48];
            for (int i = 0; i < 48; i++)
			{
			    o1SmallRespiratorData[i] = new ucSmallRespiratorData();
                o1SmallRespiratorData[i].SetNumber(i);
			}

            //DEBUG TEST
            o1MachineData[1].bAlertState = eAlertState.GREEN;
            o1MachineData[2].bAlertState = eAlertState.RED;

            //END DEBUG TEST

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    o1SmallRespiratorData[i * 8 + j].Location = new Point(j * o1SmallRespiratorData[i * 8 + j].Width, i * o1SmallRespiratorData[i * 8 + j].Height+80);
                    this.Controls.Add(o1SmallRespiratorData[i * 8 + j]);
                }
            }
        }


        private void timerMain_Tick(object sender, EventArgs e)
        {
            timerMain.Enabled = false;

            for (int i = 0; i < 48; i++)
            {
                o1SmallRespiratorData[i].SetAlert(o1MachineData[i].bAlertState);//LOCK IF PASSING BY REF !!!!!!!

                if (o1MachineData[i].bAlertState == eAlertState.GREEN)
                {

                }

                if (o1MachineData[i].bAlertState == eAlertState.GREY)
                {

                }

                if (o1MachineData[i].bAlertState == eAlertState.RED)
                {
                    //o1SmallRespiratorData[i].
                }
            }

            timerMain.Enabled = true;
        }

        

       
    }
}
