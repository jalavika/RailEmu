
















// Generated on 10/13/2017 02:18:40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 5825;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations summon;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(short actionId, int sourceId, Types.GameFightFighterInformations summon)
         : base(actionId, sourceId)
        {
            this.summon = summon;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(summon.TypeId);
            summon.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            summon = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            summon.Deserialize(reader);
            

}


}


}
