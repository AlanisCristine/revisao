using revisao;

Automovel auto = new Automovel();
auto.Marca = "Fiat";
auto.Cor = "Cinza";
auto.Placa = "1234567";
auto.Modelo = "Pálio";

Funcionario fun = new Funcionario();
fun.RetornarNovaMatricula();
fun.VerificarVeiculo(auto);

Pessoa pes = new Pessoa();
pes.nome = "Alanis";