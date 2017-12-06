
















// Generated on 10/13/2017 02:17:22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class FightLoot
{

public const short Id = 41;
public virtual short TypeId
{
    get { return Id; }
}

public IEnumerable<short> objects;
        public int kamas;
        

public FightLoot()
{
}

public FightLoot(IEnumerable<short> objects, int kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public virtual void Serialize(IDataWriter writer)
{

var objects_before = writer.Position;
            var objects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objects)
            {
                 writer.WriteShort(entry);
                 objects_count++;
            }
            var objects_after = writer.Position;
            writer.Seek((int)objects_before);
            writer.WriteUShort((ushort)objects_count);
            writer.Seek((int)objects_after);

            writer.WriteInt(kamas);
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var objects_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects_[i] = reader.ReadShort();
            }
            objects = objects_;
            kamas = reader.ReadInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}



}


}
