
















// Generated on 10/13/2017 02:18:59
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeCraftSlotCountIncreasedMessage : Message
{

public const uint Id = 6125;
public override uint MessageId
{
    get { return Id; }
}

public sbyte newMaxSlot;
        

public ExchangeCraftSlotCountIncreasedMessage()
{
}

public ExchangeCraftSlotCountIncreasedMessage(sbyte newMaxSlot)
        {
            this.newMaxSlot = newMaxSlot;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(newMaxSlot);
            

}

public override void Deserialize(IDataReader reader)
{

newMaxSlot = reader.ReadSByte();
            if (newMaxSlot < 0)
                throw new Exception("Forbidden value on newMaxSlot = " + newMaxSlot + ", it doesn't respect the following condition : newMaxSlot < 0");
            

}


}


}
