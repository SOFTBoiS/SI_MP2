using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaClientTest
{
    class CarrierDTO
    {
        public int CarrierID;
        public string Name;

        public CarrierDTO(int carrierId, string name)
        {
            CarrierID = carrierId;
            Name = name;
        }
    }
}
