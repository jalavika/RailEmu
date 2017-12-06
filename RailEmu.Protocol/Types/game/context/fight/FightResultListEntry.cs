
















// Generated on 10/13/2017 02:17:23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class FightResultListEntry
{

public const short Id = 16;
public virtual short TypeId
{
    get { return Id; }
}

public short outcome;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(short outcome, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.rewards = rewards;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(outcome);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

outcome = reader.ReadShort();
            if (outcome < 0)
                throw new Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}



}


}
