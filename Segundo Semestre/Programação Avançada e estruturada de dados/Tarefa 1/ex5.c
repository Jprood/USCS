#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int n1, n2;
	
	printf("\nEntre com o primeio valor: ");
	scanf("%d", &n1);
	
	printf("\nEntre com o segundo valor: ");
	scanf("%d", &n2);
	
	if(n1 == n2){
		
		printf("\nOs valores s�o iguais.");
	}
	else if(n1 > n2){
		
		printf("\nO maior valor �: %d", n1);
	}
	else{
		
		printf("\nO maior valor �: %d", n2);
	}
	
	return 0;
	}
