
















// Generated on 10/13/2017 02:18:45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameContextRemoveMultipleElementsMessage : Message
{

public const uint Id = 252;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<int> id;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(IEnumerable<int> id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

var id_before = writer.Position;
            var id_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in id)
            {
                 writer.WriteInt(entry);
                 id_count++;
            }
            var id_after = writer.Position;
            writer.Seek((int)id_before);
            writer.WriteUShort((ushort)id_count);
            writer.Seek((int)id_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var id_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 id_[i] = reader.ReadInt();
            }
            id = id_;
            

}


}


}
