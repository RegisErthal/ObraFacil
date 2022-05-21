using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace ObraFacil.Data
{
    public class ServerVersionMysql : ServerVersion
    {
        public ServerVersionMysql(Version version, ServerType type, string typeIdentifier = null) : base(version, type, typeIdentifier)
        {
        }

        public override ServerVersionSupport Supports => throw new NotImplementedException();
    }
}
