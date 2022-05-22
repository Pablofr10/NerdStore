﻿using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string mensagem)
        {
            if (!object1.Equals(object2)) throw new DomainException(mensagem);
        }
        public static void ValidarSeDiferente(object object1, object object2, string mensagem)
        {
            if (object1.Equals(object2)) throw new DomainException(mensagem);
        }
        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarExpressao(string pattern, string valor, string mensagem)
        {
            var regex = new Regex(pattern);

            if (regex.IsMatch(valor)) throw new DomainException(mensagem);
        }
        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length == 0) throw new DomainException(mensagem);
        }
        public static void ValidarSeNulo(object object1, string mensagem)
        {
            if (object1 == null) throw new DomainException(mensagem);
        }
        public static void ValidarMininoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if(valor < minimo || valor < maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMininoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor < maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMininoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor < maximo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinino(long valor, long minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinino(double valor, double minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinino(decimal valor, decimal minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinino(int valor, int minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeFalso(bool boolValor, string mensagem)
        {
            if (boolValor) throw new DomainException(mensagem);
        }
        public static void ValidarSeVerdadeiro(bool boolValor, string mensagem)
        {
            if (!boolValor) throw new DomainException(mensagem);
        }
    }
}
