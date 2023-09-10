using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCoder
{
    public interface IUsuario
    {
        public void ModificarNombreUsuario();
        public void ModificarContraseña();
        public void ModificarMail();
        public void EliminarUsuario();

    }
}
