
















// Generated on 10/13/2017 02:18:44
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameContextKickMessage : Message
{

public const uint Id = 6081;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameContextKickMessage()
{
}

public GameContextKickMessage(int targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

targetId = reader.ReadInt();
            

}


}


}
