#include <stdio.h>

int main(){
	int i, num[10];
	
	for(i = 0; i < 10; i++){
		
		printf("Digite os valores inteiros: ");
		scanf("%d", &num[i]);
		
		if(num[i] < 0){
			
			num[i] = 99;
		}
		else if(num[i]%2 == 0){
			
			num[i] = 33;
		}
		
	}
		
		for(i = 0; i < 10; i++){
			
			printf("\n%d", num[i]);
		}
	
	return 0;
}
