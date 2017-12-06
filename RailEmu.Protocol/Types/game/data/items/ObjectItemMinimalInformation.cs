
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class ObjectItemMinimalInformation : Item
{

public const short Id = 124;
public override short TypeId
{
    get { return Id; }
}

public short objectGID;
        public short powerRate;
        public bool overMax;
        public IEnumerable<Types.ObjectEffect> effects;
        

public ObjectItemMinimalInformation()
{
}

public ObjectItemMinimalInformation(short objectGID, short powerRate, bool overMax, IEnumerable<Types.ObjectEffect> effects)
        {
            this.objectGID = objectGID;
            this.powerRate = powerRate;
            this.overMax = overMax;
            this.effects = effects;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(objectGID);
            writer.WriteShort(powerRate);
            writer.WriteBoolean(overMax);
            var effects_before = writer.Position;
            var effects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
                 effects_count++;
            }
            var effects_after = writer.Position;
            writer.Seek((int)effects_before);
            writer.WriteUShort((ushort)effects_count);
            writer.Seek((int)effects_after);

            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            powerRate = reader.ReadShort();
            overMax = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            var effects_ = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects_[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects_[i].Deserialize(reader);
            }
            effects = effects_;
            

}



}


}
