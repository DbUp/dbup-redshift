using DbUp.Tests.Common;

namespace DbUp.Redshift.Tests;

public class NoPublicApiChanges : NoPublicApiChangesBase
{
    public NoPublicApiChanges()
        : base(typeof(RedshiftExtensions).Assembly)
    {
    }
}
