
















// Generated on 10/13/2017 02:18:55
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class FriendWarnOnLevelGainStateMessage : Message
{

public const uint Id = 6078;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendWarnOnLevelGainStateMessage()
{
}

public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}
