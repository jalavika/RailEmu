
















// Generated on 10/13/2017 02:17:25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailEmu.Protocol.IO;

namespace RailEmu.Protocol.Types
{

public class FriendInformations
{

public const short Id = 78;
public virtual short TypeId
{
    get { return Id; }
}

public string name;
        public sbyte playerState;
        public int lastConnection;
        

public FriendInformations()
{
}

public FriendInformations(string name, sbyte playerState, int lastConnection)
        {
            this.name = name;
            this.playerState = playerState;
            this.lastConnection = lastConnection;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteSByte(playerState);
            writer.WriteInt(lastConnection);
            

}

public virtual void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            playerState = reader.ReadSByte();
            if (playerState < 0)
                throw new Exception("Forbidden value on playerState = " + playerState + ", it doesn't respect the following condition : playerState < 0");
            lastConnection = reader.ReadInt();
            if (lastConnection < 0)
                throw new Exception("Forbidden value on lastConnection = " + lastConnection + ", it doesn't respect the following condition : lastConnection < 0");
            

}



}


}
