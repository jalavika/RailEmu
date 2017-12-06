
















// Generated on 10/13/2017 02:19:06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PrismWorldInformationRequestMessage : Message
{

public const uint Id = 5985;
public override uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismWorldInformationRequestMessage()
{
}

public PrismWorldInformationRequestMessage(bool join)
        {
            this.join = join;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(join);
            

}

public override void Deserialize(IDataReader reader)
{

join = reader.ReadBoolean();
            

}


}


}
