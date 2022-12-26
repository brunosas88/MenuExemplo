# MenuExemplo
Implementação feita para servir como base de criação de menus em console mantendo a tela sempre "limpa", com apenas o menu atual em exibição.

## Recursos Utilizados
  * Lista para salvar os dados cadastrados;
  * Funções para melhorar a legibilidade e usabilidade do código;

## Pontos a serem observados
1. A variável **"opcao"** é uma string pois facilita o tratamento de entradas não aceitáveis ao utilizar o **switch case**;
2. Na linha 21, a mensagem de entrada inválida é exibida somente se existe texto dentro da variável **"mensagemEntradaInválida"** a partir do resultado de uma condição realizada pelo operador ternário dentro do **Console.WriteLine**, o que só acontece se o usuário digitar uma opção fora das indicadas no default do **switch case** (linha 41);
      * Ainda sobre a mensagem de entrada inválida: a variável tem que ser "limpa", atribuida um valor vazio, em todos os cases funcionais para que ela não seja exibida se o usuário digitar uma opção válida;
3. A função **MostrarCabecalho** é a responsável por sempre limpar a tela utilizando o comando **Clear** do console e informar ao usuário em qual parte do sistema ele está através do parâmetro **subCabecalho** que recebe. Por isso ela deve ser chamada em todas as funções que representam uma operação escolhida pelo usuário e está na primeira linha dentro do laço do while que representa o menu principal;
4. No final das funções **CadastrarUsuario** e **MostrarUsuarios** pode-se perceber um **Console.ReadLine()** sem atribuição, isso foi feito para que o usuário possa ver as informações exibidas naquela tela durante o tempo que quiser e ao decidir que já verificou tudo que queria, pode sair da função apertando qualquer tecla (a mensagem para apertar o Enter é simplesmente procedimento padrão);
5. Para utilizar o **new string** com o valor de caracteres corretos, foi sempre adicionado o tamanho da palavra que está sendo inserida na mensagem mais os caracteres extras de espaços em branco e barras no começo e fim da mensagem (por isso o + 4);
  
# Atenção!
O código implementado não possui as verificações normalmente exigidas para uma avaliação criteriosa e deve ser utilizado apenas como base para uma implementação mais completa.

