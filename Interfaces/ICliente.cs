﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
 public   interface ICliente
    {
        int Agregar(Cliente cliente, List<Mascota> mascotas);
        int Editar(Cliente nivelacceso);
        DataTable BuscarApellidos(Cliente cliente);
        DataTable BuscarDni(Cliente cliente);
        DataTable Listar();
        int ContarNumClientes(Cliente cliente);
    }
}
