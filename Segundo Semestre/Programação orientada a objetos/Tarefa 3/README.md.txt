1. Construir uma classe para representar um Empregado com os seguintes dados:
nome, endereço, valor da hora trabalhada e quantidade de horas trabalhadas
no mês. Considerando encapsulamento de dados, defina os construtores
(padrão com passagem de parâmetros e sem passagem de parâmetros). Defina
um método chamado ImprimeEmpregado() que imprime os dados do
empregado. Defina também um método chamado CalculaSalario() que
retorna o salário do empregado (basta multiplicar o valor da hora pela
quantidade de horas trabalhadas). Defina por último um método
ImprimeSalario() que imprime o nome e salário do empregado.

2. Definir uma classe para representar um Gerente que obviamente é um
empregado. Considere que o Gerente tenha uma secretária (considerar o
nome dela) e um valor de bônus que deve ser acrescido ao salário.
Considerando encapsulamento de dados, defina os construtores (padrão com
passagem de parâmetros e sem passagem de parâmetros). Defina uma função
chamada ImprimeGerente() para imprimir todos os dados do gerente
(inclusive os da classe Empregado). Reescreva o método CalculaSalario() para
imprimir o salário do Gerente acrescido do bônus.

3. Definir uma classe chamada TesteGerente() com o método main() e criar um
empregado de nome “Antonio”, endereço: “Rua Brasil, 130”, valor hora =
R$50,00 , 230 horas trabalhadas. Imprimir os dados do empregado. Imprimir o
salário do empregado. Criar um gerente chamado “Carlos”, endereço: “Rua
Silvio Torres, 36”, valor hora = R$ 50,00, quantidade de horas trabalhadas =
230, secretária “Ana” e bônus = R2.000,00. Imprimir os dados do gerente e seu
salário.
Observações:
a) Considerar que todas as classes estão em um único package chamado uscs.
b) USAR herança.