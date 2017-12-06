
















// Generated on 10/13/2017 02:18:51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;
using RailEmu.Protocol.Types;

namespace RailEmu.Protocol.Messages
{

public class JobListedUpdateMessage : Message
{

public const uint Id = 6016;
public override uint MessageId
{
    get { return Id; }
}

public bool addedOrDeleted;
        public sbyte jobId;
        

public JobListedUpdateMessage()
{
}

public JobListedUpdateMessage(bool addedOrDeleted, sbyte jobId)
        {
            this.addedOrDeleted = addedOrDeleted;
            this.jobId = jobId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(addedOrDeleted);
            writer.WriteSByte(jobId);
            

}

public override void Deserialize(IDataReader reader)
{

addedOrDeleted = reader.ReadBoolean();
            jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}
