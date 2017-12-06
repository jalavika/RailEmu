using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailEmu.Common.Database.Modeles.Auth
{
    public class WorldServer
    {
        public int ServerId { get; set; }
        public int Status { get; set; }
        public int Completion { get; set; }
        public string Name { get; set; }

    }
}
