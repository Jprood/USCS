#include <stdio.h>

int main(){
	float x[20], media, soma = 0, maior = 0;
	int i;
	for(i = 0; i < 20; i++){
		
		printf("Digite as notas:");
		scanf("%f", &x[i]);
		
		soma = soma + x[i];
		
		if(x[i] > maior){
		
		maior = x[i];
	}
	}
	
	media = soma/i;
	
	printf("\nmedia geral: %.2f", media);
	printf("\nMaior nota: %.2f", maior);
}

