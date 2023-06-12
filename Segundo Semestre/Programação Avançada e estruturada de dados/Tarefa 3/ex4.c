#include <stdio.h>

int main(){
	int num[10], i;
	
	for(i = 0; i < 10; i++){
		
		printf("Digite o valores: ");
		scanf("%d", &num[i]);
	}
	
	printf("\nValores digitados do ultimo ao primeiro:\n");
	for(i = 9; i >= 0; i--){
		
		printf("\n%d", num[i]);
	}
	return 0;
}
