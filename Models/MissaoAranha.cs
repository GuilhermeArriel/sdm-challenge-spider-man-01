namespace SpiderNetApi.Models;

public class MissaoAranha
{
    public int Id { get; set; }
    public string VilaoEnfrentado { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
    public int NivelPerigo { get; set; }
    public bool Resolvido { get; set; }
}