
















// Generated on 10/13/2017 02:18:56
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChallengeFightJoinRefusedMessage : Message
{

public const uint Id = 5908;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        public sbyte reason;
        

public ChallengeFightJoinRefusedMessage()
{
}

public ChallengeFightJoinRefusedMessage(int playerId, sbyte reason)
        {
            this.playerId = playerId;
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(playerId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            reason = reader.ReadSByte();
            

}


}


}
