
















// Generated on 10/13/2017 02:18:55
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class FriendDeleteResultMessage : Message
{

public const uint Id = 5601;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public string name;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(success);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

success = reader.ReadBoolean();
            name = reader.ReadUTF();
            

}


}


}
