#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int n1, n2;
	
		printf("\nEntre com o primeio valor: ");
	scanf("%d", &n1);
	
	printf("\nEntre com o segundo valor: ");
	scanf("%d", &n2);
	
	if(n1 < n2){
		
		printf("\nO menor valor é: %d", n1);
	}
	else if(n2 < n1){
		
		printf("\nO menor valor é: %d", n2);
	}
	else{
		
		printf("\nOs valores são iguais.");
	}
	
	return 0;
	}
