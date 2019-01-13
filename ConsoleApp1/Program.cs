using System;
using TeamsLogger.Core;
using TeamsLogger.Core.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger(
                 new TeamsWebhookClient("https://outlook.office.com/webhook/569e9a71-1a77-4814-8bee-e2b6910f3193@2384fc1e-f84b-4dbc-978e-f5193d6a7828/IncomingWebhook/8f861a469cb045d19469a5c66590d875/041c64a3-5389-4501-8e99-faa47ab92f5f"),
                 new LoggerConfiguration { AutomaticallySetColor = true },
                 "SomeModule");

            //logger.LogMessage(LogSeverity.Info, "Message to log");
            //logger.LogMessage(LogSeverity.Warn, "Log message", "CCDDC4");
            logger.BeginRunningLog("Begin logging");
            logger.CreateNewMessageCard();
            logger.AddLogToCurrentMessageCard(LogSeverity.Info, "Some event happened");
            logger.AddLogToCurrentMessageCard(LogSeverity.Warn, "Not so good event happened");
            logger.AddLogToCurrentMessageCard(LogSeverity.Error, "Bad event happened");
            string str = null;
            try
            {
                var place = str[3];
            }
            catch (Exception ex)
            {
                logger.CreateNewExceptionMessageCard(ex, "http://microsoft.com");
            }

            logger.AddLogToCurrentMessageCard(LogSeverity.Info, "Some event happened");
            logger.AddLogToCurrentMessageCard(LogSeverity.Warn, "Not so good event happened");
            logger.PostRunningLog();
        }
    }
}
