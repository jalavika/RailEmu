
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ObjectGroundAddedMessage : Message
{

public const uint Id = 3017;
public override uint MessageId
{
    get { return Id; }
}

public short cellId;
        public short objectGID;
        

public ObjectGroundAddedMessage()
{
}

public ObjectGroundAddedMessage(short cellId, short objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(cellId);
            writer.WriteShort(objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}
