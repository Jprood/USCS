#include <stdio.h>
#include <locale.h>

int main (){
		setlocale(LC_ALL, "Portuguese");
	
	double lado, lado2, perimetro;
	
	printf("Escreva o valor do primeiro lado do ret�ngulo:");
	scanf("%lf", &lado);
	
	printf("Escreva o valor do primeiro lado do ret�ngulo:");
	scanf("%lf", &lado2);
	
	perimetro = (lado * 2)+(lado2 * 2);
	
	printf("\n O perimetro �: %.3f", perimetro);
	
	return 0;
}
