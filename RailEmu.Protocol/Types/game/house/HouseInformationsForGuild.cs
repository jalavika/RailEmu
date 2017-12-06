
















// Generated on 10/13/2017 02:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class HouseInformationsForGuild
{

public const short Id = 170;
public virtual short TypeId
{
    get { return Id; }
}

public int houseId;
        public int modelId;
        public string ownerName;
        public short worldX;
        public short worldY;
        public IEnumerable<int> skillListIds;
        public uint guildshareParams;
        

public HouseInformationsForGuild()
{
}

public HouseInformationsForGuild(int houseId, int modelId, string ownerName, short worldX, short worldY, IEnumerable<int> skillListIds, uint guildshareParams)
        {
            this.houseId = houseId;
            this.modelId = modelId;
            this.ownerName = ownerName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.skillListIds = skillListIds;
            this.guildshareParams = guildshareParams;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(houseId);
            writer.WriteInt(modelId);
            writer.WriteUTF(ownerName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            var skillListIds_before = writer.Position;
            var skillListIds_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in skillListIds)
            {
                 writer.WriteInt(entry);
                 skillListIds_count++;
            }
            var skillListIds_after = writer.Position;
            writer.Seek((int)skillListIds_before);
            writer.WriteUShort((ushort)skillListIds_count);
            writer.Seek((int)skillListIds_after);

            writer.WriteUInt(guildshareParams);
            

}

public virtual void Deserialize(IDataReader reader)
{

houseId = reader.ReadInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            modelId = reader.ReadInt();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            ownerName = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            var limit = reader.ReadUShort();
            var skillListIds_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 skillListIds_[i] = reader.ReadInt();
            }
            skillListIds = skillListIds_;
            guildshareParams = reader.ReadUInt();
            if (guildshareParams < 0 || guildshareParams > 4294967295)
                throw new Exception("Forbidden value on guildshareParams = " + guildshareParams + ", it doesn't respect the following condition : guildshareParams < 0 || guildshareParams > 4294967295");
            

}



}


}
