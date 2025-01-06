namespace BlazorWebConsumirApiTerceiros.Models;


public class Dolar
{
    public USDBRL USDBRL { get; set; }
}

public class USDBRL
{
    public string code { get; set; }
    public string codein { get; set; }
    public string name { get; set; } // nome moeada 
    public string high { get; set; } // cotação máxima
    public string low { get; set; }  // cotação mínima
    public string varBid { get; set; }
    public string pctChange { get; set; }
    public string bid { get; set; }
    public string ask { get; set; } // cotação atual
    public string timestamp { get; set; }
    public string create_date { get; set; } // data cotação
}

