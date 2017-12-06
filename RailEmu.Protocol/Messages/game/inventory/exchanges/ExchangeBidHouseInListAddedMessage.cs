
















// Generated on 10/13/2017 02:18:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeBidHouseInListAddedMessage : Message
{

public const uint Id = 5949;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public int objGenericId;
        public short powerRate;
        public bool overMax;
        public IEnumerable<Types.ObjectEffect> effects;
        public IEnumerable<int> prices;
        

public ExchangeBidHouseInListAddedMessage()
{
}

public ExchangeBidHouseInListAddedMessage(int itemUID, int objGenericId, short powerRate, bool overMax, IEnumerable<Types.ObjectEffect> effects, IEnumerable<int> prices)
        {
            this.itemUID = itemUID;
            this.objGenericId = objGenericId;
            this.powerRate = powerRate;
            this.overMax = overMax;
            this.effects = effects;
            this.prices = prices;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteInt(objGenericId);
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

public override void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objGenericId = reader.ReadInt();
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
