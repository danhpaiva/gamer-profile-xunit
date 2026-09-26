using GamerProfile.App;

PerfilJogadorService perfilJogadorService = new PerfilJogadorService();
string tag = perfilJogadorService.GerarTagUsuario("Aragorn", "1042");
Console.WriteLine(tag);