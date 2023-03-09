using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace SQLManagedIdentityFunction
{
  public static class GetMatieres
  {
    [FunctionName("GetMatieres")]
    public static IActionResult Run(
      [HttpTrigger(AuthorizationLevel.Function, "get", Route = "getmatieres")]
      HttpRequest req,
      [Sql("select * from dbo.Matiere",
          "SqlConnectionString")]
      IEnumerable<Matiere> matieres)
    {
      return (ActionResult)new OkObjectResult(matieres);
    }
  }
}
