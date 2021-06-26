﻿using ListaDeFilmes.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFilmes.Business.Interfaces
{
    public interface IFilmeRepository : IRepository<Filme>
    {
        Task<List<Filme>> PesquisaNomeFilme(string nomeFilme);

        Task<List<Filme>> GetFilmesComNomeGeneroAsync();

    }
}
