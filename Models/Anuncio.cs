using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace BlackImoveisII.Models
{
    public class Anuncio
    {
        //-----------------PERSONAL INFO----------------
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Sobrenome {get; set;}
        public string Email {get; set;}
        public int Telefone {get; set;}


        //------------------REAL ESTATE INFO-------------
        public string Tipo {get; set;}
        public string TipoServico {get; set;}
        public bool Financiamento {get; set;}
        public string Endereco {get; set;}
        public string Cidade {get; set;}
        public int Sala {get; set;}
        public int Quarto {get; set;}
        public int Suite {get; set;}
        public string Varanda {get; set;}
        public string QrtoReversivel {get; set;}
        public string Armarios {get; set;}
        public string WCSocial {get; set;}
        public string Cozinha {get; set;}
        public string Copa {get; set;}
        public string ArmariosCozinha {get; set;}
        public string AreaServico {get; set;}
        public string WCServico {get; set;}
        public string Piscina {get; set;}
        public string SLFesta {get; set;}
        public string Garagem {get; set;}
        public double AreaUtil {get; set;}
        public double ValorImovel {get; set;}
        public double Condominio {get; set;}
        public double IPTU {get; set;}
        public string Comentario {get; set;}
        public string Bairro {get; set;}

        //------------------- IMAGE UPLOAD

        //public List<IFormFile> Fotos {get; set;}

        //------------------- CONTENT FOR BEING POSTED

        public string Titulo {get; set;}
        public string Descricao {get; set;}
        public bool Post {get; set;}

        

    }
}