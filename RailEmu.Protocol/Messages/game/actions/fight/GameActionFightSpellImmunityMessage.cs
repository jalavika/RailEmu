
















// Generated on 10/13/2017 02:18:40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
{

public const uint Id = 6221;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public int spellId;
        

public GameActionFightSpellImmunityMessage()
{
}

public GameActionFightSpellImmunityMessage(short actionId, int sourceId, int targetId, int spellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteInt(spellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            spellId = reader.ReadInt();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}
