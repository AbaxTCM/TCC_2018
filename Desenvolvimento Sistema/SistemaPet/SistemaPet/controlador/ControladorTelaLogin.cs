using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.controlador
{
    class ControladorTelaLogin
    {
        public sealed class Session
        {

            private static volatile Session instance;
            private static object sync = new Object();

            private Session() { }

            public static Session Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (sync)
                        {
                            if (instance == null)
                            {
                                instance = new Session();
                            }
                        }
                    }
                    return instance;
                }

            }
            public int UserID { get; set; }

        }
    }
}
