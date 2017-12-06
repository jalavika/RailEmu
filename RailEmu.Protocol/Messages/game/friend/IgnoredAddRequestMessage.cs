
















// Generated on 10/13/2017 02:18:55
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class IgnoredAddRequestMessage : Message
{

public const uint Id = 5673;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(string name, bool session)
        {
            this.name = name;
            this.session = session;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            session = reader.ReadBoolean();
            

}


}


}
