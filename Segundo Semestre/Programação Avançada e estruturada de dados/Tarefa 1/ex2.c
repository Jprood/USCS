#include<stdio.h>
#include<locale.h>

int main (){
	setlocale(LC_ALL, "Portuguese");
	
	int v1, v2;
	double soma, sub, div, mul;
	
	printf("\nEntre com o primeio valor: ");
	scanf("%d", &v1);
	
	printf("\nEntre com o segundo valor: ");
	scanf("%d", &v2);
	
	soma = v1 + v2;
	sub = v1 - v2;
	div = v1 / v2;
	mul = v1 * v2;
	
	printf("\nO Valor da soma �: %3f", soma);
	printf("\nO Valor da subtra��o �: %3f", sub);
	printf("\nO Valor da divis�o �: %3f", div);
	printf("\nO Valor da multiplica��o �: %3f", mul);
	
	return 0;
	
	}
