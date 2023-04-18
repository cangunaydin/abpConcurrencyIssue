using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doohlink.Saas;

public interface ITenantDataSeeder
{
    Task CreateTestTenantAsync();
}
