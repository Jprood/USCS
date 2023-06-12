#include <stdio.h>

int main(){
	int x[20], A, B, i, media;
	
	for(i = 0; i < 20; i++){
		
		printf("Digite o valor:");
		scanf("%d", &x[i]);
	}
	
	printf("\nDigite o valor de A:");
	scanf("%d", &A);
	
	printf("\nDigite o valor de B:");
	scanf("%d", &B);
	
	x[0] = A;
	x[19] = B;
	
	media = (x[0] + x[19])/i;
		
		printf("\nMedia dos valores: %d, %d", media, i);
}
