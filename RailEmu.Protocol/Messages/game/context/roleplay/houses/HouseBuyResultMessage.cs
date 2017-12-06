
















// Generated on 10/13/2017 02:18:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class HouseBuyResultMessage : Message
{

public const uint Id = 5735;
public override uint MessageId
{
    get { return Id; }
}

public int houseId;
        public bool bought;
        public int realPrice;
        

public HouseBuyResultMessage()
{
}

public HouseBuyResultMessage(int houseId, bool bought, int realPrice)
        {
            this.houseId = houseId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(houseId);
            writer.WriteBoolean(bought);
            writer.WriteInt(realPrice);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            bought = reader.ReadBoolean();
            realPrice = reader.ReadInt();
            if (realPrice < 0)
                throw new Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            

}


}


}
