
















// Generated on 10/13/2017 02:18:42
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class CharacterSelectedErrorMessage : Message
{

public const uint Id = 5836;
public override uint MessageId
{
    get { return Id; }
}



public CharacterSelectedErrorMessage()
{
}



public override void Serialize(IDataWriter writer)
{



}

public override void Deserialize(IDataReader reader)
{



}


}


}
