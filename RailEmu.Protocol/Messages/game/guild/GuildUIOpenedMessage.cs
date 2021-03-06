
















// Generated on 10/13/2017 02:18:57
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GuildUIOpenedMessage : Message
{

public const uint Id = 5561;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public GuildUIOpenedMessage()
{
}

public GuildUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(type);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}
