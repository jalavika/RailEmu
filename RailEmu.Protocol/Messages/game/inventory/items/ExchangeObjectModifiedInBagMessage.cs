
















// Generated on 10/13/2017 02:19:03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeObjectModifiedInBagMessage : ExchangeObjectMessage
{

public const uint Id = 6008;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ExchangeObjectModifiedInBagMessage()
{
}

public ExchangeObjectModifiedInBagMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            @object.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}
