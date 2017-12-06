
















// Generated on 10/13/2017 02:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class FriendSpouseInformations
{

public const short Id = 77;
public virtual short TypeId
{
    get { return Id; }
}

public int spouseId;
        public string spouseName;
        public byte spouseLevel;
        public sbyte breed;
        public sbyte sex;
        public Types.EntityLook spouseEntityLook;
        public Types.BasicGuildInformations guildInfo;
        public sbyte alignmentSide;
        

public FriendSpouseInformations()
{
}

public FriendSpouseInformations(int spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.BasicGuildInformations guildInfo, sbyte alignmentSide)
        {
            this.spouseId = spouseId;
            this.spouseName = spouseName;
            this.spouseLevel = spouseLevel;
            this.breed = breed;
            this.sex = sex;
            this.spouseEntityLook = spouseEntityLook;
            this.guildInfo = guildInfo;
            this.alignmentSide = alignmentSide;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(spouseId);
            writer.WriteUTF(spouseName);
            writer.WriteByte(spouseLevel);
            writer.WriteSByte(breed);
            writer.WriteSByte(sex);
            spouseEntityLook.Serialize(writer);
            guildInfo.Serialize(writer);
            writer.WriteSByte(alignmentSide);
            

}

public virtual void Deserialize(IDataReader reader)
{

spouseId = reader.ReadInt();
            if (spouseId < 0)
                throw new Exception("Forbidden value on spouseId = " + spouseId + ", it doesn't respect the following condition : spouseId < 0");
            spouseName = reader.ReadUTF();
            spouseLevel = reader.ReadByte();
            if (spouseLevel < 1 || spouseLevel > 200)
                throw new Exception("Forbidden value on spouseLevel = " + spouseLevel + ", it doesn't respect the following condition : spouseLevel < 1 || spouseLevel > 200");
            breed = reader.ReadSByte();
            sex = reader.ReadSByte();
            spouseEntityLook = new Types.EntityLook();
            spouseEntityLook.Deserialize(reader);
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            alignmentSide = reader.ReadSByte();
            

}



}


}
