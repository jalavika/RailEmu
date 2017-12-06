
















// Generated on 10/13/2017 02:18:48
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChangeMapMessage : Message
{

public const uint Id = 221;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public ChangeMapMessage()
{
}

public ChangeMapMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}
