
















// Generated on 10/13/2017 02:18:44
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChatServerWithObjectMessage : ChatServerMessage
{

public const uint Id = 883;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ObjectItem> objects;
        

public ChatServerWithObjectMessage()
{
}

public ChatServerWithObjectMessage(sbyte channel, string content, int timestamp, string fingerprint, int senderId, string senderName, int senderAccountId, IEnumerable<Types.ObjectItem> objects)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
        {
            this.objects = objects;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            var objects_before = writer.Position;
            var objects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
                 objects_count++;
            }
            var objects_after = writer.Position;
            writer.Seek((int)objects_before);
            writer.WriteUShort((ushort)objects_count);
            writer.Seek((int)objects_after);

            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            var objects_ = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects_[i] = new Types.ObjectItem();
                 objects_[i].Deserialize(reader);
            }
            objects = objects_;
            

}


}


}
