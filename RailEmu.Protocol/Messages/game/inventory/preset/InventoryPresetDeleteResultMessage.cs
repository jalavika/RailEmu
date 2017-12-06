
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class InventoryPresetDeleteResultMessage : Message
{

public const uint Id = 6173;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        

public InventoryPresetDeleteResultMessage()
{
}

public InventoryPresetDeleteResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}
