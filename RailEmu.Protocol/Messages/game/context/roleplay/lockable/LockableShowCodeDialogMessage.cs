
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class LockableShowCodeDialogMessage : Message
{

public const uint Id = 5740;
public override uint MessageId
{
    get { return Id; }
}

public bool changeOrUse;
        public sbyte codeSize;
        

public LockableShowCodeDialogMessage()
{
}

public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(changeOrUse);
            writer.WriteSByte(codeSize);
            

}

public override void Deserialize(IDataReader reader)
{

changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSByte();
            if (codeSize < 0)
                throw new Exception("Forbidden value on codeSize = " + codeSize + ", it doesn't respect the following condition : codeSize < 0");
            

}


}


}
