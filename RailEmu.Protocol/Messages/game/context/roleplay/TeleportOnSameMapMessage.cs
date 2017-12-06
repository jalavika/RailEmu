
















// Generated on 10/13/2017 02:18:48
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class TeleportOnSameMapMessage : Message
{

public const uint Id = 6048;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public short cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(int targetId, short cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(targetId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(IDataReader reader)
{

targetId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}
