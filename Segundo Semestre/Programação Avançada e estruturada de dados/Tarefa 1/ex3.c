#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	char nome[30];
	double salario, vendas, por, salario_f;
	
	printf("\nEntre com o nome do vendedor:");
	scanf("%s",&nome);
	
	printf("\nEntre com o sal�rio do vendedor:");
	scanf("%lf",&salario);
	
	printf("\nEntre com o valol total de vendas:");
	scanf("%lf",&vendas);
	
	por = vendas*0.20;
	salario_f = salario + por;
	
	printf("\nNome do vendedor: %s", nome);
	printf("\nSal�rio fixo: %.3f", salario);
	printf("\nSal�rio final: %.3f", salario_f);
	
	return 0;
}
