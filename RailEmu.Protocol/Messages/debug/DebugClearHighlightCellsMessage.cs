
















// Generated on 10/13/2017 02:18:38
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class DebugClearHighlightCellsMessage : Message
{

public const uint Id = 2002;
public override uint MessageId
{
    get { return Id; }
}



public DebugClearHighlightCellsMessage()
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
