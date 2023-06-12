#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double c, f;
	
	printf("\nEntre com o valor da temperatura em fahrenheit: ");
	scanf("%lf", &f);
	
	 c = ((f - 32)* 5)/9;
	
	printf("A temperatura em celsius é: %.2lf", c);
	
	return 0;
	}
