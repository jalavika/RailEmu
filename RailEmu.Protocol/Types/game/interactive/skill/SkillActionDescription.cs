
















// Generated on 10/13/2017 02:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class SkillActionDescription
{

public const short Id = 102;
public virtual short TypeId
{
    get { return Id; }
}

public short skillId;
        

public SkillActionDescription()
{
}

public SkillActionDescription(short skillId)
        {
            this.skillId = skillId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(skillId);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadShort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}



}


}
