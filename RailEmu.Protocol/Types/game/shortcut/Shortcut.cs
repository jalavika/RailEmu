
















// Generated on 10/13/2017 02:17:27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class Shortcut
{

public const short Id = 369;
public virtual short TypeId
{
    get { return Id; }
}

public int slot;
        

public Shortcut()
{
}

public Shortcut(int slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(slot);
            

}

public virtual void Deserialize(IDataReader reader)
{

slot = reader.ReadInt();
            if (slot < 0 || slot > 99)
                throw new Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : slot < 0 || slot > 99");
            

}



}


}
