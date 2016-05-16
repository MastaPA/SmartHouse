using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Eqipment
{
    public interface IBaseEquipment
    {
        bool State { get; set; }

        string Name { get; set; }

        int Id { get; set; }

        void Status();
    }
}
