
















// Generated on 10/13/2017 02:19:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeOnHumanVendorRequestMessage : Message
{

public const uint Id = 5772;
public override uint MessageId
{
    get { return Id; }
}

public int humanVendorId;
        public int humanVendorCell;
        

public ExchangeOnHumanVendorRequestMessage()
{
}

public ExchangeOnHumanVendorRequestMessage(int humanVendorId, int humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(humanVendorId);
            writer.WriteInt(humanVendorCell);
            

}

public override void Deserialize(IDataReader reader)
{

humanVendorId = reader.ReadInt();
            if (humanVendorId < 0)
                throw new Exception("Forbidden value on humanVendorId = " + humanVendorId + ", it doesn't respect the following condition : humanVendorId < 0");
            humanVendorCell = reader.ReadInt();
            if (humanVendorCell < 0)
                throw new Exception("Forbidden value on humanVendorCell = " + humanVendorCell + ", it doesn't respect the following condition : humanVendorCell < 0");
            

}


}


}
