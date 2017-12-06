
















// Generated on 10/13/2017 02:18:52
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class PartyCancelInvitationNotificationMessage : Message
{

public const uint Id = 6251;
public override uint MessageId
{
    get { return Id; }
}

public int cancelerId;
        public int guestId;
        

public PartyCancelInvitationNotificationMessage()
{
}

public PartyCancelInvitationNotificationMessage(int cancelerId, int guestId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(cancelerId);
            writer.WriteInt(guestId);
            

}

public override void Deserialize(IDataReader reader)
{

cancelerId = reader.ReadInt();
            if (cancelerId < 0)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
            guestId = reader.ReadInt();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}
