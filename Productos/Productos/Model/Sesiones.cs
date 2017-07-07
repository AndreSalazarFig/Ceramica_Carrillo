using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model
{
    public class Sesiones
    {
        Boolean _Admin;
        String _Usuario;

        public bool Admin { get => _Admin; set => _Admin = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }

        public Sesiones()
        {
            _Admin = false;
            _Usuario = String.Empty;
        }
    }
}
