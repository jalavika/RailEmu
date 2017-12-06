
















// Generated on 10/13/2017 02:19:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeSellMessage : Message
{

public const uint Id = 5778;
public override uint MessageId
{
    get { return Id; }
}

public int objectToSellId;
        public int quantity;
        

public ExchangeSellMessage()
{
}

public ExchangeSellMessage(int objectToSellId, int quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(objectToSellId);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectToSellId = reader.ReadInt();
            if (objectToSellId < 0)
                throw new Exception("Forbidden value on objectToSellId = " + objectToSellId + ", it doesn't respect the following condition : objectToSellId < 0");
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}
