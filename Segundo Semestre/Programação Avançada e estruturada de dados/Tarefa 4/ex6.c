#include <stdio.h>

int main(){

	int	x[10], i;
	
	for(i = 0; i < 10; i++){
		
		printf("Digite os valores:");
		scanf("%d", &x[i]);
		
		if(x[i]%2 == 0){
			
			x[i] = 99;
		}
	}
	
	for(i = 0; i < 10; i++){
		
		printf("\n%d", x[i]);
	}
}
