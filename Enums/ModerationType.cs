using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectMVC.Models.Enums
{
    public enum ModerationType
    {   
        [Description("Political Propaganda")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drugs Reference")]
        Drugs,
        [Description("Threatening Speech")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
    }
}
