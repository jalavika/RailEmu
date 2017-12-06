
















// Generated on 10/13/2017 02:18:46
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameFightRemoveTeamMemberMessage : Message
{

public const uint Id = 711;
public override uint MessageId
{
    get { return Id; }
}

public short fightId;
        public sbyte teamId;
        public int charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(short fightId, sbyte teamId, int charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteInt(charId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            charId = reader.ReadInt();
            

}


}


}
