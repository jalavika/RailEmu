
















// Generated on 10/13/2017 02:18:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class StatedMapUpdateMessage : Message
{

public const uint Id = 5716;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.StatedElement> statedElements;
        

public StatedMapUpdateMessage()
{
}

public StatedMapUpdateMessage(IEnumerable<Types.StatedElement> statedElements)
        {
            this.statedElements = statedElements;
        }
        

public override void Serialize(IDataWriter writer)
{

var statedElements_before = writer.Position;
            var statedElements_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
                 statedElements_count++;
            }
            var statedElements_after = writer.Position;
            writer.Seek((int)statedElements_before);
            writer.WriteUShort((ushort)statedElements_count);
            writer.Seek((int)statedElements_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var statedElements_ = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 statedElements_[i] = new Types.StatedElement();
                 statedElements_[i].Deserialize(reader);
            }
            statedElements = statedElements_;
            

}


}


}
