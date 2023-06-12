#include <stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int num[8], i, x, y, soma;
	
	for(i = 0; i < 8; i++){
		
		printf("Digite os valores: ");
		scanf("%d", &num[i]);
	}
	
	printf("Digite o valor de x: ");
	scanf("%d", &x);
	
	printf("Digite o valor de y: ");
	scanf("%d", &y);
	
	num[0] = x;
	num[7] = y;
	
	soma = num[0] + num[7];
	
	printf("Soma dos valores na posição x e y: %d", soma);
	return 0;
}