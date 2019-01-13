using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsLogger.Core.Models
{
    [Serializable]
    public class TeamsMessage

    {
        public string Text { get; set; }
        public string ThemeColor { get; set; }
    }
}
