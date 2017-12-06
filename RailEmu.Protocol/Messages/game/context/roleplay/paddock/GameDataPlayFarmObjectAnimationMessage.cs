
















// Generated on 10/13/2017 02:18:52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : Message
{

public const uint Id = 6026;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<short> cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(IEnumerable<short> cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

var cellId_before = writer.Position;
            var cellId_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in cellId)
            {
                 writer.WriteShort(entry);
                 cellId_count++;
            }
            var cellId_after = writer.Position;
            writer.Seek((int)cellId_before);
            writer.WriteUShort((ushort)cellId_count);
            writer.Seek((int)cellId_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var cellId_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellId_[i] = reader.ReadShort();
            }
            cellId = cellId_;
            

}


}


}
