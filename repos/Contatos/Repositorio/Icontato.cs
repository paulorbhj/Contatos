﻿using Contatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Repositorio
{
    public interface Icontato
    {
        List<Contato> ListarTodos();
        Contato Adicionar(Contato contato);
    }
}
