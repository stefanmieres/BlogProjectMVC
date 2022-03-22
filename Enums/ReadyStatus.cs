using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectMVC.Models.Enums
{
    public enum ReadyStatus
    {

        //Se usa para indicar status y evitar problemas de tipado del usuario. Es una buena practica
        
        Imcomplete,
        ProductionReady,
        PreviewReady,

         
    }
}
