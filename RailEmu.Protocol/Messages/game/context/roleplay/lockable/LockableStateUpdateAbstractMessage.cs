
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : Message
{

public const uint Id = 5671;
public override uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(locked);
            

}

public override void Deserialize(IDataReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}
