
















// Generated on 10/13/2017 02:18:57
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GuildFightPlayersHelpersJoinMessage : Message
{

public const uint Id = 5720;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        

public GuildFightPlayersHelpersJoinMessage()
{
}

public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            playerInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
            

}


}


}
