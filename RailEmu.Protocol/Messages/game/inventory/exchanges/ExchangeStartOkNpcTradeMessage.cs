
















// Generated on 10/13/2017 02:19:02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ExchangeStartOkNpcTradeMessage : Message
{

public const uint Id = 5785;
public override uint MessageId
{
    get { return Id; }
}

public int npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(int npcId)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(npcId);
            

}

public override void Deserialize(IDataReader reader)
{

npcId = reader.ReadInt();
            

}


}


}
