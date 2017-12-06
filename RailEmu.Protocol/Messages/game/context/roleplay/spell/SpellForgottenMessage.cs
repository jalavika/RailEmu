
















// Generated on 10/13/2017 02:18:54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class SpellForgottenMessage : Message
{

public const uint Id = 5834;
public override uint MessageId
{
    get { return Id; }
}

public IEnumerable<short> spellsId;
        public short boostPoint;
        

public SpellForgottenMessage()
{
}

public SpellForgottenMessage(IEnumerable<short> spellsId, short boostPoint)
        {
            this.spellsId = spellsId;
            this.boostPoint = boostPoint;
        }
        

public override void Serialize(IDataWriter writer)
{

var spellsId_before = writer.Position;
            var spellsId_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in spellsId)
            {
                 writer.WriteShort(entry);
                 spellsId_count++;
            }
            var spellsId_after = writer.Position;
            writer.Seek((int)spellsId_before);
            writer.WriteUShort((ushort)spellsId_count);
            writer.Seek((int)spellsId_after);

            writer.WriteShort(boostPoint);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            var spellsId_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellsId_[i] = reader.ReadShort();
            }
            spellsId = spellsId_;
            boostPoint = reader.ReadShort();
            if (boostPoint < 0)
                throw new Exception("Forbidden value on boostPoint = " + boostPoint + ", it doesn't respect the following condition : boostPoint < 0");
            

}


}


}
