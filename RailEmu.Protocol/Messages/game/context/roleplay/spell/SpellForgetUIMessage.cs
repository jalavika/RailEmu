
















// Generated on 10/13/2017 02:18:54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SpellForgetUIMessage : Message
{

public const uint Id = 5565;
public override uint MessageId
{
    get { return Id; }
}

public bool open;
        

public SpellForgetUIMessage()
{
}

public SpellForgetUIMessage(bool open)
        {
            this.open = open;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(open);
            

}

public override void Deserialize(IDataReader reader)
{

open = reader.ReadBoolean();
            

}


}


}
