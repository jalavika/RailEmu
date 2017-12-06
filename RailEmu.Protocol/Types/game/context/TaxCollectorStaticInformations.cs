
















// Generated on 10/13/2017 02:17:22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class TaxCollectorStaticInformations
{

public const short Id = 147;
public virtual short TypeId
{
    get { return Id; }
}

public short firstNameId;
        public short lastNameId;
        public Types.GuildInformations guildIdentity;
        

public TaxCollectorStaticInformations()
{
}

public TaxCollectorStaticInformations(short firstNameId, short lastNameId, Types.GuildInformations guildIdentity)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.guildIdentity = guildIdentity;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(firstNameId);
            writer.WriteShort(lastNameId);
            guildIdentity.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

firstNameId = reader.ReadShort();
            if (firstNameId < 0)
                throw new Exception("Forbidden value on firstNameId = " + firstNameId + ", it doesn't respect the following condition : firstNameId < 0");
            lastNameId = reader.ReadShort();
            if (lastNameId < 0)
                throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
            guildIdentity = new Types.GuildInformations();
            guildIdentity.Deserialize(reader);
            

}



}


}
