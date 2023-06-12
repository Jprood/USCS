#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double n1, n2, n3, media;
	
		printf("\nEntre com o primeio valor: ");
	scanf("%lf", &n1);
	
	printf("\nEntre com o segundo valor: ");
	scanf("%lf", &n2);
	
		printf("\nEntre com o terceiro valor: ");
	scanf("%lf", &n3);
	
	media = (n1 + n2 + n3)/3;
	
	printf("A media dos números é: %.3lf", media);
	
	return 0;
	}
