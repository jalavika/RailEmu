
















// Generated on 10/13/2017 02:18:56
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GuildInvitationStateRecrutedMessage : Message
{

public const uint Id = 5548;
public override uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public GuildInvitationStateRecrutedMessage()
{
}

public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(invitationState);
            

}

public override void Deserialize(IDataReader reader)
{

invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}
