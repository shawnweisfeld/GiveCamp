using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GiveCamp.Models
{
    public class GiveCampContextInitializer : DropCreateDatabaseIfModelChanges<GiveCampContext> //DropCreateDatabaseAlways<GiveCampContext>
    {
    }
}
