
















// Generated on 10/13/2017 02:18:59
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeCraftInformationObjectMessage : ExchangeCraftResultWithObjectIdMessage
{

public const uint Id = 5794;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        

public ExchangeCraftInformationObjectMessage()
{
}

public ExchangeCraftInformationObjectMessage(sbyte craftResult, int objectGenericId, int playerId)
         : base(craftResult, objectGenericId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}
