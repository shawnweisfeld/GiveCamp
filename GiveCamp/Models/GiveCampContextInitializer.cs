using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GiveCamp.Models
{
    public class GiveCampContextInitializer : 
        CreateDatabaseIfNotExists<GiveCampContext>
        //DropCreateDatabaseIfModelChanges<GiveCampContext> 
        //DropCreateDatabaseAlways<GiveCampContext>
    {
    }
}
