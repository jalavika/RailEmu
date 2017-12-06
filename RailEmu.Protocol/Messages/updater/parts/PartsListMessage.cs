
















// Generated on 10/13/2017 02:19:08
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PartsListMessage : Message
{

public const uint Id = 1502;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ContentPart> parts;
        

public PartsListMessage()
{
}

public PartsListMessage(IEnumerable<Types.ContentPart> parts)
        {
            this.parts = parts;
        }
        

public override void Serialize(IDataWriter writer)
{

var parts_before = writer.Position;
            var parts_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in parts)
            {
                 entry.Serialize(writer);
                 parts_count++;
            }
            var parts_after = writer.Position;
            writer.Seek((int)parts_before);
            writer.WriteUShort((ushort)parts_count);
            writer.Seek((int)parts_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var parts_ = new Types.ContentPart[limit];
            for (int i = 0; i < limit; i++)
            {
                 parts_[i] = new Types.ContentPart();
                 parts_[i].Deserialize(reader);
            }
            parts = parts_;
            

}


}


}
