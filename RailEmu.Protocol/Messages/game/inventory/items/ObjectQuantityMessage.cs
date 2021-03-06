
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ObjectQuantityMessage : Message
{

public const uint Id = 3023;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        public int quantity;
        

public ObjectQuantityMessage()
{
}

public ObjectQuantityMessage(int objectUID, int quantity)
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
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}
