#include <stdio.h>

int main(){
	
	int x[99], i;
	
	for(i = 0; i < 99; i++){
		
		printf("Digite os valores: ");
		scanf("%d", &x[i]);
	}
	
	for(i = 98; i >= 0; i--){
		
		printf("\n%d", x[i]);
	}
}
