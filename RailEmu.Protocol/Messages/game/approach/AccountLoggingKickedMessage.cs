
















// Generated on 10/13/2017 02:18:41
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class AccountLoggingKickedMessage : Message
{

public const uint Id = 6029;
public override uint MessageId
{
    get { return Id; }
}

public int days;
        public int hours;
        public int minutes;
        

public AccountLoggingKickedMessage()
{
}

public AccountLoggingKickedMessage(int days, int hours, int minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(days);
            writer.WriteInt(hours);
            writer.WriteInt(minutes);
            

}

public override void Deserialize(IDataReader reader)
{

days = reader.ReadInt();
            if (days < 0)
                throw new Exception("Forbidden value on days = " + days + ", it doesn't respect the following condition : days < 0");
            hours = reader.ReadInt();
            if (hours < 0)
                throw new Exception("Forbidden value on hours = " + hours + ", it doesn't respect the following condition : hours < 0");
            minutes = reader.ReadInt();
            if (minutes < 0)
                throw new Exception("Forbidden value on minutes = " + minutes + ", it doesn't respect the following condition : minutes < 0");
            

}


}


}
