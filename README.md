# Desafio

Para este desafio, foram criado 3 aplicações, onde a aplicação Aluno, é responsável pelo cadastro dos alunos; a Gabarito é responsável pelo cadastro dos gabaritos, 
e a RespostaAluno é responsável pelo cadastro das respostas dos alunos.

Mesmo sendo solicitado apenas a função de adicionar dados ao sistema, tomei a liberdade de colocar as opções de consultar todos e exclusão com filtro pelo Id.

Os dados foram imputados diretamente no banco de dados SqL Server.

Aplicações:
Alunos = Nome e SobreNome;
Gabarito = Questao, PesoQuestao, OpcaoCorreta, ProvaId;
RespostaAluno = ProvaId, GabaritoId, AlunoId, Resposta. 
Todas as aplicações foram desenvolvidas em c#, todo o código foi feito no programa Visual Studio Code.
Para os testes de apresentação das requisições foi utilizada a ferramenta do swagger e do Postman, e as informações eram apresentadas via requisição HTTP e retornavam JSON.
