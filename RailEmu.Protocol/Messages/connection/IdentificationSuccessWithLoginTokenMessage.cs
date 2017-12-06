
















// Generated on 10/13/2017 02:18:37
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
{

public const uint Id = 6209;
public override uint MessageId
{
    get { return Id; }
}

public string loginToken;
        

public IdentificationSuccessWithLoginTokenMessage()
{
}

public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string nickname, int accountId, sbyte communityId, string secretQuestion, double remainingSubscriptionTime, string loginToken)
         : base(hasRights, wasAlreadyConnected, nickname, accountId, communityId, secretQuestion, remainingSubscriptionTime)
        {
            this.loginToken = loginToken;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(loginToken);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            loginToken = reader.ReadUTF();
            

}


}


}
