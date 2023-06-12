#include<stdio.h>

int main(){
	int i;
	float num[10], soma = 0, media;
	
	for(i = 0; i < 10 ; i++){
		
		printf("Digite o valor: ");
		scanf("%f", &num[i]);
		
		if(num[i] < 0){
			
			soma = soma + num[i];
		}
	}
	
	printf("Numeros negativos digitados:\n");
	for(i = 0; i < 10; i++){
		
		if(num[i] < 0){
			
			printf("\n%.2f", num[i]);
		}
	}
	
	media = soma/i;
	printf("\nMedia dos numeros negativos: %.2f", media);
	return 0;
}
