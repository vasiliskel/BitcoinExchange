﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UtilityWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetBitcoinBalance" in both code and config file together.
    [ServiceContract]
    public interface IGetBtcBalance
    {

        [OperationContract]
        double GetCurrentBtcBalance(int current_id);


    }
}