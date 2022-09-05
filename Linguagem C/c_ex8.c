#include <stdio.h>
#include <locale.h>

int main (){
		setlocale(LC_ALL, "Portuguese");
	
	double lado, perimetro;
	
	printf("Escreva o valor do lado do quadrado:");
	scanf("%lf", &lado);
	
	perimetro = lado * 4;
	
	printf("\n O perimetro é: %.3f", perimetro);
	
	return 0;
}

