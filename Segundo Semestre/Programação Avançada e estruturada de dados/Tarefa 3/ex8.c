#include <stdio.h>

int main(){
	int i, num[10], soma = 0;
	
	for(i = 0; i < 10; i++){
		
		printf("Digite os valores inteiros e positivos: ");
		scanf("%d", &num[i]);
		
		if(num[i]%2 == 0){
			
			soma = soma + num[i];
		}
	}
		
		printf("\nSoma dos numeros pares: %d", soma);
	
	return 0;
}
