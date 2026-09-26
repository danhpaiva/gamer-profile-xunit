using GamerProfile.App;
using Xunit;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    private readonly PerfilJogadorService _service;

    public PerfilJogadorServiceTests()
    {
        // Instancia o serviço para reutilização em todos os testes
        _service = new PerfilJogadorService();
    }

    [Fact]
    public void GerarTagUsuario_DeveRetornarNicknameECodigoFormatadosComHash()
    {
        // Arrange (Organizar)
        string nickname = "Aragorn";
        string codigo = "1042";
        string resultadoEsperado = "Aragorn#1042";

        // Act (Agir)
        string resultado = _service.GerarTagUsuario(nickname, codigo);

        // Assert (Validar)
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarDuasFasesEAdicionarBonusDeCem()
    {
        // Arrange (Organizar)
        int xpFase1 = 200;
        int xpFase2 = 300;
        int resultadoEsperado = 600; // 200 + 300 + 100 (bônus)

        // Act (Agir)
        int resultado = _service.CalcularXPTotal(xpFase1, xpFase2);

        // Assert (Validar)
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRetornarTrue_QuandoNivelForMaiorOuIgualA15()
    {
        // Arrange (Organizar)
        int nivelJogador = 15;

        // Act (Agir)
        bool resultado = _service.EEligivelParaRanked(nivelJogador);

        // Assert (Validar)
        Assert.True(resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRetornarFalse_QuandoNivelForMenorQue15()
    {
        // Arrange (Organizar)
        int nivelJogador = 14;

        // Act (Agir)
        bool resultado = _service.EEligivelParaRanked(nivelJogador);

        // Assert (Validar)
        Assert.False(resultado);
    }
}