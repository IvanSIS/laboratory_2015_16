﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryManagementClient
{
    interface IDBConnection
    {
        string GetDBConnectionParameters();
    }
}
