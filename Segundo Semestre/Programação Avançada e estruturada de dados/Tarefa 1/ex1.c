#include<stdio.h>
#include<locale.h>

int main (){
	setlocale(LC_ALL, "Portuguese");
	
	double b, h, area;
	
	printf("Digite a base do tri�ngulo: ");
		scanf("%lf", &b);
	
	printf("Digite a altura do tri�ngulo: ");
		scanf("%lf", &h);
		
	area = (b*h)/2;
	
	printf("\nA �rea do tri�ngulo �: %.3f", area);
	
	return 0;
}
