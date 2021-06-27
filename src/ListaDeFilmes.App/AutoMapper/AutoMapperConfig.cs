﻿using AutoMapper;
using ListaDeFilmes.App.ViewModels;
using ListaDeFilmes.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeFilmes.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Filme, FilmeViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>().ReverseMap();
            CreateMap<Diretor, DiretorViewModel>().ReverseMap();
            CreateMap<Ator, AtorViewModel>().ReverseMap();
            CreateMap<Produtora, ProdutoraViewModel>().ReverseMap();
            CreateMap<FilmeAtor, FilmeAtorViewModel>().ReverseMap();
        }
    }
}
