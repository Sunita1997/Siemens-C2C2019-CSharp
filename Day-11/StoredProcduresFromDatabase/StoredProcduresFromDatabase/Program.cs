using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;

namespace StoredProcduresFromDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(@"joydip-pc");
            Database db = server.Databases["siemensdb"];
            List<SqlSmoObject> list = new List<SqlSmoObject>();
            DataTable dataTable = db.EnumObjects(DatabaseObjectTypes.StoredProcedure);
            foreach (DataRow row in dataTable.Rows)
            {
                string sSchema = (string)row["Schema"];
                if (sSchema == "sys" || sSchema == "INFORMATION_SCHEMA")
                    continue;
                StoredProcedure sp = (StoredProcedure)server.GetSmoObject(
                   new Urn((string)row["Urn"]));
                if (!sp.IsSystemObject)
                    list.Add(sp);
            }
            Scripter scripter = new Scripter();
            scripter.Server = server;
            scripter.Options.IncludeHeaders = true;
            scripter.Options.SchemaQualify = true;
            scripter.Options.ToFileOnly = true;
            scripter.Options.FileName = @"E:\Siemens\C2C-2019\CSharp\Siemens-C2C2019-CSharp\Siemens-C2C2019-CSharp\Day-11\StoredProcduresFromDatabase\StoredProcedures.sql";
            scripter.Script(list.ToArray());
        }
    }
}