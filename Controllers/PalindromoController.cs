using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad2_Palindromo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromoController : ControllerBase
    {
        [HttpGet("{palabra}")]
        public string Get(string Palabra) 
        {
            string palabra, inverso, caracter, resultado;
            int i;
            int count = Palabra.Split(' ').Length;

            palabra = Palabra.ToLower().Replace(" ","");
            i = palabra.Length;
            inverso = "";

            for (int x=i-1; x>=0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }

            if (palabra == inverso)
            {
                resultado = $"La palabra: {Palabra}, es palindromo";
            }
            else 
            {
                resultado = $"La palabra: {Palabra}, no es palindromo";
            }

            return $"{resultado} Total de palabras: {count}";
        }
    }
}
