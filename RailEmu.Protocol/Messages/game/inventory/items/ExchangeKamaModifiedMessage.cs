
















// Generated on 10/13/2017 02:19:03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 5521;
public override uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ExchangeKamaModifiedMessage()
{
}

public ExchangeKamaModifiedMessage(bool remote, int quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}
