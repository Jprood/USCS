#include <stdio.h>

int main(){
	
	float num[10], num2[10];
	int i;
	
	for(i = 0; i < 10; i++){
		
		printf("Digite os valores: ");
		scanf("%f", &num[i]);
		
		num2[i] = num[i] * num[i];
	}
	
	for(i = 0; i < 10; i++){
		
		printf("\nQuadrado dos numeros digitados: %.2f", num2[i]);
	}
	return 0;
}
