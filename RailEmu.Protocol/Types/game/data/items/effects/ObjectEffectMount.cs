
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class ObjectEffectMount : ObjectEffect
{

public const short Id = 179;
public override short TypeId
{
    get { return Id; }
}

public int mountId;
        public double date;
        public short modelId;
        

public ObjectEffectMount()
{
}

public ObjectEffectMount(short actionId, int mountId, double date, short modelId)
         : base(actionId)
        {
            this.mountId = mountId;
            this.date = date;
            this.modelId = modelId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mountId);
            writer.WriteDouble(date);
            writer.WriteShort(modelId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mountId = reader.ReadInt();
            if (mountId < 0)
                throw new Exception("Forbidden value on mountId = " + mountId + ", it doesn't respect the following condition : mountId < 0");
            date = reader.ReadDouble();
            modelId = reader.ReadShort();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            

}



}


}
