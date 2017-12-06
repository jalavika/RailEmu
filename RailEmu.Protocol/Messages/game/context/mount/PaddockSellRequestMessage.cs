
















// Generated on 10/13/2017 02:18:48
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PaddockSellRequestMessage : Message
{

public const uint Id = 5953;
public override uint MessageId
{
    get { return Id; }
}

public int price;
        

public PaddockSellRequestMessage()
{
}

public PaddockSellRequestMessage(int price)
        {
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(price);
            

}

public override void Deserialize(IDataReader reader)
{

price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}
