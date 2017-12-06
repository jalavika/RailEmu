
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class ObjectEffectLadder : ObjectEffectCreature
{

public const short Id = 81;
public override short TypeId
{
    get { return Id; }
}

public int monsterCount;
        

public ObjectEffectLadder()
{
}

public ObjectEffectLadder(short actionId, short monsterFamilyId, int monsterCount)
         : base(actionId, monsterFamilyId)
        {
            this.monsterCount = monsterCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(monsterCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterCount = reader.ReadInt();
            if (monsterCount < 0)
                throw new Exception("Forbidden value on monsterCount = " + monsterCount + ", it doesn't respect the following condition : monsterCount < 0");
            

}



}


}
