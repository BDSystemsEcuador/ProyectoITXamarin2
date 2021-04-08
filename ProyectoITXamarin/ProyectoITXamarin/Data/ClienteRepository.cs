using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ProyectoITXamarin.DataModel
{
    public class ClienteRepository
    {
        readonly BindingList<Cliente> clientes;

        public ClienteRepository()
        {
            this.clientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> Clientes
        {
            get { return clientes; }
        }
    }
}
