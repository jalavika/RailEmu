
















// Generated on 10/13/2017 02:19:07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class DownloadCurrentSpeedMessage : Message
{

public const uint Id = 1511;
public override uint MessageId
{
    get { return Id; }
}

public sbyte downloadSpeed;
        

public DownloadCurrentSpeedMessage()
{
}

public DownloadCurrentSpeedMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSByte(downloadSpeed);
            

}

public override void Deserialize(IDataReader reader)
{

downloadSpeed = reader.ReadSByte();
            if (downloadSpeed < 1 || downloadSpeed > 10)
                throw new Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
            

}


}


}
