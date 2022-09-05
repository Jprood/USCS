#include <stdio.h>
#include <locale.h>

int main (){
		setlocale(LC_ALL, "Portuguese");
	
	double lado, area;
	
	printf("Escreva o valor do lado do quadrado:");
	scanf("%lf", &lado);
	
	area = lado * lado;
	
	printf("\n O perimetro é: %.3f", area);
	
	return 0;
}
