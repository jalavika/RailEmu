
















// Generated on 10/13/2017 02:18:41
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class AccountCapabilitiesMessage : Message
{

public const uint Id = 6216;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool tutorialAvailable;
        public short breedsVisible;
        public short breedsAvailable;
        

public AccountCapabilitiesMessage()
{
}

public AccountCapabilitiesMessage(int accountId, bool tutorialAvailable, short breedsVisible, short breedsAvailable)
        {
            this.accountId = accountId;
            this.tutorialAvailable = tutorialAvailable;
            this.breedsVisible = breedsVisible;
            this.breedsAvailable = breedsAvailable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(tutorialAvailable);
            writer.WriteShort(breedsVisible);
            writer.WriteShort(breedsAvailable);
            

}

public override void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            tutorialAvailable = reader.ReadBoolean();
            breedsVisible = reader.ReadShort();
            if (breedsVisible < 0)
                throw new Exception("Forbidden value on breedsVisible = " + breedsVisible + ", it doesn't respect the following condition : breedsVisible < 0");
            breedsAvailable = reader.ReadShort();
            if (breedsAvailable < 0)
                throw new Exception("Forbidden value on breedsAvailable = " + breedsAvailable + ", it doesn't respect the following condition : breedsAvailable < 0");
            

}


}


}
