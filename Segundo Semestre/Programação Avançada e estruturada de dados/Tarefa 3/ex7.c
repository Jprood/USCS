#include <stdio.h>

int main(){
	int i, num[9];
	
	for(i = 0; i < 10; i++){
		
		printf("Digite os valores: ");
		scanf("%d", &num[i]);
		
		if(num[i] < 0){
			
			num[i] = 0;
		}
	}
	
	for(i = 0; i < 10; i++){
		
		printf("\n%d", num[i]);
	}
	
	return 0;
}
