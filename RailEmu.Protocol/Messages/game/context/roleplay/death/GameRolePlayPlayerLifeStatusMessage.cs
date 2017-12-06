
















// Generated on 10/13/2017 02:18:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class GameRolePlayPlayerLifeStatusMessage : Message
{

public const uint Id = 5996;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public GameRolePlayPlayerLifeStatusMessage()
{
}

public GameRolePlayPlayerLifeStatusMessage(sbyte state)
        {
            this.state = state;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(state);
            

}

public override void Deserialize(IDataReader reader)
{

state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}
