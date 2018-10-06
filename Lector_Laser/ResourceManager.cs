using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lector_Laser
{
    public class ResourceManager
    {
        public static bool cargarDLL(out string message)
        {
            if (!File.Exists("MEDAQLib.dll"))
            {
                try
                {
                    var archivo = Lector_Laser.Properties.Resources.MEDAQLib;
                    File.WriteAllBytes("MEDAQLib.dll", archivo);
                    message = "done";
                    return true;
                }
                catch (Exception e)
                {
                    message = e.Message;
                    return false;
                }
            }
            else
            {
                message = "done";
                return true;
            }
        }
    }
}
