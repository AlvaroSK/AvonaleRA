using System;
using System.ComponentModel.DataAnnotations;

namespace AvonaleRA.Models
{
    public class Cartao
    {
        public string titular { get; set; }
        public string numeroCartao { get; set; }
        public string data_expiracao { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }


    }
}
