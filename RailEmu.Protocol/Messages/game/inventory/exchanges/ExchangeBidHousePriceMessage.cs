
















// Generated on 10/13/2017 02:18:59
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeBidHousePriceMessage : Message
{

public const uint Id = 5805;
public override uint MessageId
{
    get { return Id; }
}

public int genId;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(int genId)
        {
            this.genId = genId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(genId);
            

}

public override void Deserialize(IDataReader reader)
{

genId = reader.ReadInt();
            if (genId < 0)
                throw new Exception("Forbidden value on genId = " + genId + ", it doesn't respect the following condition : genId < 0");
            

}


}


}
