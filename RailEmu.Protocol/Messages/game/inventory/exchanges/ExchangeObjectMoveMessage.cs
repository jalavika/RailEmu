
















// Generated on 10/13/2017 02:19:00
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeObjectMoveMessage : Message
{

public const uint Id = 5518;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        public int quantity;
        

public ExchangeObjectMoveMessage()
{
}

public ExchangeObjectMoveMessage(int objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteInt(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadInt();
            

}


}


}
