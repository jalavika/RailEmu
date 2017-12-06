
















// Generated on 10/13/2017 02:18:45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameFightJoinRequestMessage : Message
{

public const uint Id = 701;
public override uint MessageId
{
    get { return Id; }
}

public int fighterId;
        public int fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(int fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(fighterId);
            writer.WriteInt(fightId);
            

}

public override void Deserialize(IDataReader reader)
{

fighterId = reader.ReadInt();
            fightId = reader.ReadInt();
            

}


}


}
