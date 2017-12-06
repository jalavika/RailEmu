
















// Generated on 10/13/2017 02:18:44
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const uint Id = 882;
public override uint MessageId
{
    get { return Id; }
}

public int receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, int receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(receiverId);
            writer.WriteUTF(receiverName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadInt();
            if (receiverId < 0)
                throw new Exception("Forbidden value on receiverId = " + receiverId + ", it doesn't respect the following condition : receiverId < 0");
            receiverName = reader.ReadUTF();
            

}


}


}
