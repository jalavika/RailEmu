
















// Generated on 10/13/2017 02:19:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeRemovedPaymentForCraftMessage : Message
{

public const uint Id = 6031;
public override uint MessageId
{
    get { return Id; }
}

public bool onlySuccess;
        public int objectUID;
        

public ExchangeRemovedPaymentForCraftMessage()
{
}

public ExchangeRemovedPaymentForCraftMessage(bool onlySuccess, int objectUID)
        {
            this.onlySuccess = onlySuccess;
            this.objectUID = objectUID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(onlySuccess);
            writer.WriteInt(objectUID);
            

}

public override void Deserialize(IDataReader reader)
{

onlySuccess = reader.ReadBoolean();
            objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}
