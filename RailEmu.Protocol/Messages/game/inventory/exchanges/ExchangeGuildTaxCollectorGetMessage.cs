
















// Generated on 10/13/2017 02:18:59
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeGuildTaxCollectorGetMessage : Message
{

public const uint Id = 5762;
public override uint MessageId
{
    get { return Id; }
}

public string collectorName;
        public short worldX;
        public short worldY;
        public int mapId;
        public string userName;
        public double experience;
        public IEnumerable<Types.ObjectItemQuantity> objectsInfos;
        

public ExchangeGuildTaxCollectorGetMessage()
{
}

public ExchangeGuildTaxCollectorGetMessage(string collectorName, short worldX, short worldY, int mapId, string userName, double experience, IEnumerable<Types.ObjectItemQuantity> objectsInfos)
        {
            this.collectorName = collectorName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.userName = userName;
            this.experience = experience;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(collectorName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteUTF(userName);
            writer.WriteDouble(experience);
            var objectsInfos_before = writer.Position;
            var objectsInfos_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
                 objectsInfos_count++;
            }
            var objectsInfos_after = writer.Position;
            writer.Seek((int)objectsInfos_before);
            writer.WriteUShort((ushort)objectsInfos_count);
            writer.Seek((int)objectsInfos_after);

            

}

public override void Deserialize(IDataReader reader)
{

collectorName = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            userName = reader.ReadUTF();
            experience = reader.ReadDouble();
            var limit = reader.ReadUShort();
            var objectsInfos_ = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos_[i] = new Types.ObjectItemQuantity();
                 objectsInfos_[i].Deserialize(reader);
            }
            objectsInfos = objectsInfos_;
            

}


}


}
