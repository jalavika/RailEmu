
















// Generated on 10/13/2017 02:18:52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PartyAbdicateThroneMessage : Message
{

public const uint Id = 6080;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        

public PartyAbdicateThroneMessage()
{
}

public PartyAbdicateThroneMessage(int playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}