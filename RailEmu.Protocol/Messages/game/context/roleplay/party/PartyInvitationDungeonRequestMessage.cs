
















// Generated on 10/13/2017 02:18:53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6245;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        

public PartyInvitationDungeonRequestMessage()
{
}

public PartyInvitationDungeonRequestMessage(string name, short dungeonId)
         : base(name)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(dungeonId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}
