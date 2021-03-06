
















// Generated on 10/13/2017 02:19:05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PrismFightAttackedMessage : Message
{

public const uint Id = 5894;
public override uint MessageId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        public int mapId;
        public short subareaId;
        public sbyte prismSide;
        

public PrismFightAttackedMessage()
{
}

public PrismFightAttackedMessage(short worldX, short worldY, int mapId, short subareaId, sbyte prismSide)
        {
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subareaId = subareaId;
            this.prismSide = prismSide;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteShort(subareaId);
            writer.WriteSByte(prismSide);
            

}

public override void Deserialize(IDataReader reader)
{

worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            subareaId = reader.ReadShort();
            if (subareaId < 0)
                throw new Exception("Forbidden value on subareaId = " + subareaId + ", it doesn't respect the following condition : subareaId < 0");
            prismSide = reader.ReadSByte();
            

}


}


}
