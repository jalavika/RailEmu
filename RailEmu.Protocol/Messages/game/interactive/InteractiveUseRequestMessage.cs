
















// Generated on 10/13/2017 02:18:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class InteractiveUseRequestMessage : Message
{

public const uint Id = 5001;
public override uint MessageId
{
    get { return Id; }
}

public int elemId;
        public int skillInstanceUid;
        

public InteractiveUseRequestMessage()
{
}

public InteractiveUseRequestMessage(int elemId, int skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(elemId);
            writer.WriteInt(skillInstanceUid);
            

}

public override void Deserialize(IDataReader reader)
{

elemId = reader.ReadInt();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillInstanceUid = reader.ReadInt();
            if (skillInstanceUid < 0)
                throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}
