#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int n;
	
	printf("\nEntre com um número inteiro: ");
	scanf("%d", &n);
	
	if(n%2 == 0){
		
		printf("\nO número é par.");
	}
	else{
		
		printf("\nO número é impar.");
	}
	
	return 0;
	}
