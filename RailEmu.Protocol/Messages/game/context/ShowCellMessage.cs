
















// Generated on 10/13/2017 02:18:45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ShowCellMessage : Message
{

public const uint Id = 5612;
public override uint MessageId
{
    get { return Id; }
}

public int sourceId;
        public short cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(int sourceId, short cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(sourceId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(IDataReader reader)
{

sourceId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}
