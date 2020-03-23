using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impact_Respirators
{
    public enum eAlertState
	{
        RED =1,
        GREEN = 2,
        GREY = 3
	}


    public class cMachineData
    {
        public int iNumber;
        public eAlertState bAlertState = eAlertState.GREY;

        internal void SetNumber(int i)
        {
            iNumber = i;
        }
    }
}
