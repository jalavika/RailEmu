
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class FriendOnlineInformations : FriendInformations
{

public const short Id = 92;
public override short TypeId
{
    get { return Id; }
}

public string playerName;
        public short level;
        public sbyte alignmentSide;
        public sbyte breed;
        public bool sex;
        public Types.BasicGuildInformations guildInfo;
        public sbyte moodSmileyId;
        

public FriendOnlineInformations()
{
}

public FriendOnlineInformations(string name, sbyte playerState, int lastConnection, string playerName, short level, sbyte alignmentSide, sbyte breed, bool sex, Types.BasicGuildInformations guildInfo, sbyte moodSmileyId)
         : base(name, playerState, lastConnection)
        {
            this.playerName = playerName;
            this.level = level;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.sex = sex;
            this.guildInfo = guildInfo;
            this.moodSmileyId = moodSmileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            writer.WriteShort(level);
            writer.WriteSByte(alignmentSide);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            guildInfo.Serialize(writer);
            writer.WriteSByte(moodSmileyId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            level = reader.ReadShort();
            if (level < 0 || level > 200)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 200");
            alignmentSide = reader.ReadSByte();
            breed = reader.ReadSByte();
            if (breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal)
                throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal");
            sex = reader.ReadBoolean();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            moodSmileyId = reader.ReadSByte();
            

}



}


}
