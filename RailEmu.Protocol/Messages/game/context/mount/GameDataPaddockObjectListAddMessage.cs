
















// Generated on 10/13/2017 02:18:47
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameDataPaddockObjectListAddMessage : Message
{

public const uint Id = 5992;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.PaddockItem> paddockItemDescription;
        

public GameDataPaddockObjectListAddMessage()
{
}

public GameDataPaddockObjectListAddMessage(IEnumerable<Types.PaddockItem> paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

var paddockItemDescription_before = writer.Position;
            var paddockItemDescription_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in paddockItemDescription)
            {
                 entry.Serialize(writer);
                 paddockItemDescription_count++;
            }
            var paddockItemDescription_after = writer.Position;
            writer.Seek((int)paddockItemDescription_before);
            writer.WriteUShort((ushort)paddockItemDescription_count);
            writer.Seek((int)paddockItemDescription_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var paddockItemDescription_ = new Types.PaddockItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockItemDescription_[i] = new Types.PaddockItem();
                 paddockItemDescription_[i].Deserialize(reader);
            }
            paddockItemDescription = paddockItemDescription_;
            

}


}


}
