namespace GamerProfile.App;

public class PerfilJogadorService
{
    /// <summary>
    /// Gera a tag formatada do usuário no padrão Nickname#Codigo.
    /// </summary>
    public string GerarTagUsuario(string nickname, string codigo)
    {
        return $"{nickname}#{codigo}";
    }

    /// <summary>
    /// Soma o XP acumulado em duas fases e concede um bônus fixo de 100 pontos.
    /// </summary>
    public int CalcularXPTotal(int xpFase1, int xpFase2)
    {
        const int bonusFixo = 100;
        return xpFase1 + xpFase2 + bonusFixo;
    }

    /// <summary>
    /// Verifica se o jogador atinge o nível mínimo (15) para acessar a fila ranqueada.
    /// </summary>
    public bool EEligivelParaRanked(int nivelJogador)
    {
        return nivelJogador >= 15;
    }
}