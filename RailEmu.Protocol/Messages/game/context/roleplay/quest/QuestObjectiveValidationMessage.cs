
















// Generated on 10/13/2017 02:18:54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class QuestObjectiveValidationMessage : Message
{

public const uint Id = 6085;
public override uint MessageId
{
    get { return Id; }
}

public short questId;
        public short objectiveId;
        

public QuestObjectiveValidationMessage()
{
}

public QuestObjectiveValidationMessage(short questId, short objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(questId);
            writer.WriteShort(objectiveId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            objectiveId = reader.ReadShort();
            if (objectiveId < 0)
                throw new Exception("Forbidden value on objectiveId = " + objectiveId + ", it doesn't respect the following condition : objectiveId < 0");
            

}


}


}
