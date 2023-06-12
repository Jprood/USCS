#include<stdio.h>
#include<locale.h>

int main (){
	setlocale(LC_ALL, "Portuguese");
	
	double b, h, area;
	
	printf("Digite a base do triângulo: ");
		scanf("%lf", &b);
	
	printf("Digite a altura do triângulo: ");
		scanf("%lf", &h);
		
	area = (b*h)/2;
	
	printf("\nA área do triângulo é: %.3f", area);
	
	return 0;
}
