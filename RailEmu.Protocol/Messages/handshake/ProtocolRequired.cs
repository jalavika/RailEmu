
















// Generated on 10/13/2017 02:19:07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class ProtocolRequired : Message
{

public const uint Id = 1;
public override uint MessageId
{
    get { return Id; }
}

public int requiredVersion;
        public int currentVersion;
        

public ProtocolRequired()
{
}

public ProtocolRequired(int requiredVersion, int currentVersion)
        {
            this.requiredVersion = requiredVersion;
            this.currentVersion = currentVersion;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(requiredVersion);
            writer.WriteInt(currentVersion);
            

}

public override void Deserialize(IDataReader reader)
{

requiredVersion = reader.ReadInt();
            if (requiredVersion < 0)
                throw new Exception("Forbidden value on requiredVersion = " + requiredVersion + ", it doesn't respect the following condition : requiredVersion < 0");
            currentVersion = reader.ReadInt();
            if (currentVersion < 0)
                throw new Exception("Forbidden value on currentVersion = " + currentVersion + ", it doesn't respect the following condition : currentVersion < 0");
            

}


}


}
