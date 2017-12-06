
















// Generated on 10/13/2017 02:18:54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class QuestStepNoInfoMessage : Message
{

public const uint Id = 5627;
public override uint MessageId
{
    get { return Id; }
}

public short questId;
        

public QuestStepNoInfoMessage()
{
}

public QuestStepNoInfoMessage(short questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(questId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}
