
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ObjectsAddedMessage : Message
{

public const uint Id = 6033;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ObjectItem> @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(IEnumerable<Types.ObjectItem> @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(IDataWriter writer)
{

var @object_before = writer.Position;
            var @object_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
                 @object_count++;
            }
            var @object_after = writer.Position;
            writer.Seek((int)@object_before);
            writer.WriteUShort((ushort)@object_count);
            writer.Seek((int)@object_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var @object_ = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object_[i] = new Types.ObjectItem();
                 @object_[i].Deserialize(reader);
            }
            @object = @object_;
            

}


}


}
