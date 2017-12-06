
















// Generated on 10/13/2017 02:18:56
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GuildHouseTeleportRequestMessage : Message
{

public const uint Id = 5712;
public override uint MessageId
{
    get { return Id; }
}

public int houseId;
        

public GuildHouseTeleportRequestMessage()
{
}

public GuildHouseTeleportRequestMessage(int houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(houseId);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}
