
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ObjectModifiedMessage : Message
{

public const uint Id = 3029;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ObjectModifiedMessage()
{
}

public ObjectModifiedMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(IDataWriter writer)
{

@object.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}
