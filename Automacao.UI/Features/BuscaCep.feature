Feature: Busca CEP
	Eu como usuário
	desejo buscar o CEP no site dos correios
	para visualizar o resultado da busca

@Automatizado
Scenario:  Buscar cep que nao existe
	Given que acesse o site correios
	When desejo buscar um cep inexistente
	Then o site deve retornar que endereco nao existe
	And voltar para a tela inicial


@Automatizado
Scenario:  Buscar cep correto
	Given que acesse o site correios
	When desejo buscar um cep correto
	Then o site deve retornar o endereco Rua Quinze de Novembro, São Paulo/SP com sucesso
	And voltar para a tela inicial
