#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double c, f;
	
	printf("\nEntre com o valor da temperatura em Celsius: ");
	scanf("%lf", &c);
	
	f = (9 * c + 160)/5;
	
	printf("A temperatura em fahrenheit é: %.2lf", f);
	
	return 0;
	}
