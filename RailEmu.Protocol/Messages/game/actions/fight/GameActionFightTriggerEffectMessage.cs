
















// Generated on 10/13/2017 02:18:41
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameActionFightTriggerEffectMessage : GameActionFightDispellEffectMessage
{

public const uint Id = 6147;
public override uint MessageId
{
    get { return Id; }
}



public GameActionFightTriggerEffectMessage()
{
}

public GameActionFightTriggerEffectMessage(short actionId, int sourceId, int targetId, int boostUID)
         : base(actionId, sourceId, targetId, boostUID)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}
