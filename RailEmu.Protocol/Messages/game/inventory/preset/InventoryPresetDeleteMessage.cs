
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class InventoryPresetDeleteMessage : Message
{

public const uint Id = 6169;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        

public InventoryPresetDeleteMessage()
{
}

public InventoryPresetDeleteMessage(sbyte presetId)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            

}


}


}
