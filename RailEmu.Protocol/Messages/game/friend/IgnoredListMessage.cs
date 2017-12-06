
















// Generated on 10/13/2017 02:18:56
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class IgnoredListMessage : Message
{

public const uint Id = 5674;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.IgnoredInformations> ignoredList;
        

public IgnoredListMessage()
{
}

public IgnoredListMessage(IEnumerable<Types.IgnoredInformations> ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        

public override void Serialize(IDataWriter writer)
{

var ignoredList_before = writer.Position;
            var ignoredList_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
                 ignoredList_count++;
            }
            var ignoredList_after = writer.Position;
            writer.Seek((int)ignoredList_before);
            writer.WriteUShort((ushort)ignoredList_count);
            writer.Seek((int)ignoredList_after);

            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var ignoredList_ = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 ignoredList_[i] = Types.ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
                 ignoredList_[i].Deserialize(reader);
            }
            ignoredList = ignoredList_;
            

}


}


}
