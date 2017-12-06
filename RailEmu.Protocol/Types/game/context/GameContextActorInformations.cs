
















// Generated on 10/13/2017 02:17:22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class GameContextActorInformations
{

public const short Id = 150;
public virtual short TypeId
{
    get { return Id; }
}

public int contextualId;
        public Types.EntityLook look;
        public Types.EntityDispositionInformations disposition;
        

public GameContextActorInformations()
{
}

public GameContextActorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
        {
            this.contextualId = contextualId;
            this.look = look;
            this.disposition = disposition;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(contextualId);
            look.Serialize(writer);
            writer.WriteShort(disposition.TypeId);
            disposition.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

contextualId = reader.ReadInt();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            disposition = Types.ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadShort());
            disposition.Deserialize(reader);
            

}



}


}
