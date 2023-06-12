#include <stdio.h>

int main(){
	
	float num[15], media, soma = 0;
	int i, cont = 0;
	
	for(i = 0; i < 15; i++){
		
		printf("Digite as notas: ");
		scanf("%f", &num[i]);
		
		soma = soma + num[i];
	}
	
	media = soma/i;
	
	for(i = 0; i < 15; i++){
		
		if(num[i] < media) cont++;
	}
	
	printf("media: %.2f\n", media);
	printf("Numero de alunos abaixo da media: %d", cont);
	return 0;
}
