
















// Generated on 10/13/2017 02:18:43
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChatAbstractClientMessage : Message
{

public const uint Id = 850;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public ChatAbstractClientMessage()
{
}

public ChatAbstractClientMessage(string content)
        {
            this.content = content;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            

}

public override void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}
