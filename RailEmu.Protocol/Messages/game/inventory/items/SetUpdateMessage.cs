
















// Generated on 10/13/2017 02:19:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SetUpdateMessage : Message
{

public const uint Id = 5503;
public override uint MessageId
{
    get { return Id; }
}

public short setId;
        public IEnumerable<short> setObjects;
        public IEnumerable<Types.ObjectEffect> setEffects;
        

public SetUpdateMessage()
{
}

public SetUpdateMessage(short setId, IEnumerable<short> setObjects, IEnumerable<Types.ObjectEffect> setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(setId);
            var setObjects_before = writer.Position;
            var setObjects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in setObjects)
            {
                 writer.WriteShort(entry);
                 setObjects_count++;
            }
            var setObjects_after = writer.Position;
            writer.Seek((int)setObjects_before);
            writer.WriteUShort((ushort)setObjects_count);
            writer.Seek((int)setObjects_after);

            var setEffects_before = writer.Position;
            var setEffects_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in setEffects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
                 setEffects_count++;
            }
            var setEffects_after = writer.Position;
            writer.Seek((int)setEffects_before);
            writer.WriteUShort((ushort)setEffects_count);
            writer.Seek((int)setEffects_after);

            

}

public override void Deserialize(IDataReader reader)
{

setId = reader.ReadShort();
            if (setId < 0)
                throw new Exception("Forbidden value on setId = " + setId + ", it doesn't respect the following condition : setId < 0");
            var limit = reader.ReadUShort();
            var setObjects_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 setObjects_[i] = reader.ReadShort();
            }
            setObjects = setObjects_;
            limit = reader.ReadUShort();
            var setEffects_ = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 setEffects_[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 setEffects_[i].Deserialize(reader);
            }
            setEffects = setEffects_;
            

}


}


}
