using Sitecore.DependencyInjection;
using Sitecore.Marketing.Definitions;
using Sitecore.Marketing.Definitions.Outcomes.Model;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Marketing.Definitions
{
  public class DefinitionManagerInitializer
  {
    public void Process(PipelineArgs args)
    {
      // Sitecore.Marketing.Definitions.Outcomes.Data.ItemDb.ItemOutcomeDefinitionRepository is a singleton.
      // Creating its instance during initialization helps to ensure no deadlocks occur when aggregation starts for the first time.
      var outcomeDefinition = ServiceLocator.ServiceProvider.GetService(typeof(IDefinitionManager<IOutcomeDefinition>));
    }
  }
}