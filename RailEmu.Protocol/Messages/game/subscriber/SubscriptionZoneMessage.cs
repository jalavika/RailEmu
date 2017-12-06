
















// Generated on 10/13/2017 02:19:07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SubscriptionZoneMessage : Message
{

public const uint Id = 5573;
public override uint MessageId
{
    get { return Id; }
}

public bool active;
        

public SubscriptionZoneMessage()
{
}

public SubscriptionZoneMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(IDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}
