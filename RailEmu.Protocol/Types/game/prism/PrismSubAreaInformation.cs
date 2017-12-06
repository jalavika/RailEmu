
















// Generated on 10/13/2017 02:17:27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class PrismSubAreaInformation
{

public const short Id = 142;
public virtual short TypeId
{
    get { return Id; }
}

public int subId;
        public sbyte alignment;
        public short worldX;
        public short worldY;
        public int mapId;
        public bool isInFight;
        public bool isFightable;
        

public PrismSubAreaInformation()
{
}

public PrismSubAreaInformation(int subId, sbyte alignment, short worldX, short worldY, int mapId, bool isInFight, bool isFightable)
        {
            this.subId = subId;
            this.alignment = alignment;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.isInFight = isInFight;
            this.isFightable = isFightable;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(subId);
            writer.WriteSByte(alignment);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteBoolean(isInFight);
            writer.WriteBoolean(isFightable);
            

}

public virtual void Deserialize(IDataReader reader)
{

subId = reader.ReadInt();
            if (subId < 0)
                throw new Exception("Forbidden value on subId = " + subId + ", it doesn't respect the following condition : subId < 0");
            alignment = reader.ReadSByte();
            if (alignment < 0)
                throw new Exception("Forbidden value on alignment = " + alignment + ", it doesn't respect the following condition : alignment < 0");
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            isInFight = reader.ReadBoolean();
            isFightable = reader.ReadBoolean();
            

}



}


}
