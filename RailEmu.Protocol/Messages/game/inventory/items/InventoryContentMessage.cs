
















// Generated on 10/13/2017 02:19:03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class InventoryContentMessage : Message
{

public const uint Id = 3016;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<Types.ObjectItem> objects;
        public int kamas;
        

public InventoryContentMessage()
{
}

public InventoryContentMessage(IEnumerable<Types.ObjectItem> objects, int kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public override void Serialize(IDataWriter writer)
{

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

            writer.WriteInt(kamas);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var objects_ = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects_[i] = new Types.ObjectItem();
                 objects_[i].Deserialize(reader);
            }
            objects = objects_;
            kamas = reader.ReadInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}
