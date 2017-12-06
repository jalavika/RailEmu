
















// Generated on 10/13/2017 02:17:21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class AchievementStartedPercent : Achievement
{

public const short Id = 362;
public override short TypeId
{
    get { return Id; }
}

public sbyte completionPercent;
        

public AchievementStartedPercent()
{
}

public AchievementStartedPercent(short id, sbyte completionPercent)
         : base(id)
        {
            this.completionPercent = completionPercent;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(completionPercent);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            completionPercent = reader.ReadSByte();
            if (completionPercent < 0)
                throw new Exception("Forbidden value on completionPercent = " + completionPercent + ", it doesn't respect the following condition : completionPercent < 0");
            

}



}


}
