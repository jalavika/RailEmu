
















// Generated on 10/13/2017 02:18:46
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChallengeInfoMessage : Message
{

public const uint Id = 6022;
public override uint MessageId
{
    get { return Id; }
}

public sbyte challengeId;
        public int targetId;
        public int baseXpBonus;
        public int extraXpBonus;
        public int baseDropBonus;
        public int extraDropBonus;
        

public ChallengeInfoMessage()
{
}

public ChallengeInfoMessage(sbyte challengeId, int targetId, int baseXpBonus, int extraXpBonus, int baseDropBonus, int extraDropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.baseXpBonus = baseXpBonus;
            this.extraXpBonus = extraXpBonus;
            this.baseDropBonus = baseDropBonus;
            this.extraDropBonus = extraDropBonus;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(challengeId);
            writer.WriteInt(targetId);
            writer.WriteInt(baseXpBonus);
            writer.WriteInt(extraXpBonus);
            writer.WriteInt(baseDropBonus);
            writer.WriteInt(extraDropBonus);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadSByte();
            if (challengeId < 0)
                throw new Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadInt();
            baseXpBonus = reader.ReadInt();
            if (baseXpBonus < 0)
                throw new Exception("Forbidden value on baseXpBonus = " + baseXpBonus + ", it doesn't respect the following condition : baseXpBonus < 0");
            extraXpBonus = reader.ReadInt();
            if (extraXpBonus < 0)
                throw new Exception("Forbidden value on extraXpBonus = " + extraXpBonus + ", it doesn't respect the following condition : extraXpBonus < 0");
            baseDropBonus = reader.ReadInt();
            if (baseDropBonus < 0)
                throw new Exception("Forbidden value on baseDropBonus = " + baseDropBonus + ", it doesn't respect the following condition : baseDropBonus < 0");
            extraDropBonus = reader.ReadInt();
            if (extraDropBonus < 0)
                throw new Exception("Forbidden value on extraDropBonus = " + extraDropBonus + ", it doesn't respect the following condition : extraDropBonus < 0");
            

}


}


}
