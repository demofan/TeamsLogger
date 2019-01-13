using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeamsLogger.Core
{
   public interface ITeamsWebhookClient
    {
        void Post(string jsonPayload);

        Task PostAsync(string jsonPayload);
    }
}
