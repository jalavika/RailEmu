
















// Generated on 10/13/2017 02:18:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class EmotePlayRequestMessage : Message
{

public const uint Id = 5685;
public override uint MessageId
{
    get { return Id; }
}

public sbyte emoteId;
        

public EmotePlayRequestMessage()
{
}

public EmotePlayRequestMessage(sbyte emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(emoteId);
            

}

public override void Deserialize(IDataReader reader)
{

emoteId = reader.ReadSByte();
            if (emoteId < 0)
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0");
            

}


}


}
