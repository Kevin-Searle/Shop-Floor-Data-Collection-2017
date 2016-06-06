using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop_Floor_Data_Collection_2017
{
    public class ProdOrderLineUI
    {
        public string OrderNo;
        public string LineNo;
        public string OperationNo;

        public ProdOrderLines toNAV()
        {
            ProdOrderLines navData = new ProdOrderLines();
            navData.OrderNo = this.OrderNo;
            navData.LineNo = this.LineNo;
            navData.OperationNo = this.OperationNo;

            return navData;
        }

    }

    

}
