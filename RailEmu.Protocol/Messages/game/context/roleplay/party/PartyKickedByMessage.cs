
















// Generated on 10/13/2017 02:18:53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PartyKickedByMessage : Message
{

public const uint Id = 5590;
public override uint MessageId
{
    get { return Id; }
}

public int kickerId;
        

public PartyKickedByMessage()
{
}

public PartyKickedByMessage(int kickerId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(kickerId);
            

}

public override void Deserialize(IDataReader reader)
{

kickerId = reader.ReadInt();
            if (kickerId < 0)
                throw new Exception("Forbidden value on kickerId = " + kickerId + ", it doesn't respect the following condition : kickerId < 0");
            

}


}


}
