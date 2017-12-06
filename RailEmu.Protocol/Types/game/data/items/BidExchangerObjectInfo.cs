
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class BidExchangerObjectInfo
{

public const short Id = 122;
public virtual short TypeId
{
    get { return Id; }
}

public int objectUID;
        public short powerRate;
        public bool overMax;
        public IEnumerable<Types.ObjectEffect> effects;
        public IEnumerable<int> prices;
        

public BidExchangerObjectInfo()
{
}

public BidExchangerObjectInfo(int objectUID, short powerRate, bool overMax, IEnumerable<Types.ObjectEffect> effects, IEnumerable<int> prices)
        {
            this.objectUID = objectUID;
            this.powerRate = powerRate;
            this.overMax = overMax;
            this.effects = effects;
            this.prices = prices;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteShort(powerRate);
            writer.WriteBoolean(overMax);
            var effects_before = writer.Position;
            var effects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
                 effects_count++;
            }
            var effects_after = writer.Position;
            writer.Seek((int)effects_before);
            writer.WriteUShort((ushort)effects_count);
            writer.Seek((int)effects_after);

            var prices_before = writer.Position;
            var prices_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in prices)
            {
                 writer.WriteInt(entry);
                 prices_count++;
            }
            var prices_after = writer.Position;
            writer.Seek((int)prices_before);
            writer.WriteUShort((ushort)prices_count);
            writer.Seek((int)prices_after);

            

}

public virtual void Deserialize(IDataReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            powerRate = reader.ReadShort();
            overMax = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            var effects_ = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects_[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects_[i].Deserialize(reader);
            }
            effects = effects_;
            limit = reader.ReadUShort();
            var prices_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices_[i] = reader.ReadInt();
            }
            prices = prices_;
            

}



}


}
