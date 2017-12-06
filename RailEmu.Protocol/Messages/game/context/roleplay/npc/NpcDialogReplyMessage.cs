
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class NpcDialogReplyMessage : Message
{

public const uint Id = 5616;
public override uint MessageId
{
    get { return Id; }
}

public short replyId;
        

public NpcDialogReplyMessage()
{
}

public NpcDialogReplyMessage(short replyId)
        {
            this.replyId = replyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(replyId);
            

}

public override void Deserialize(IDataReader reader)
{

replyId = reader.ReadShort();
            if (replyId < 0)
                throw new Exception("Forbidden value on replyId = " + replyId + ", it doesn't respect the following condition : replyId < 0");
            

}


}


}
