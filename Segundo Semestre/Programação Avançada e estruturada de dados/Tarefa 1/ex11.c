#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int n;
	
	printf("\nEntre com um n�mero inteiro: ");
	scanf("%d", &n);
	
	if(n%2 == 0){
		
		printf("\nO n�mero � par.");
	}
	else{
		
		printf("\nO n�mero � impar.");
	}
	
	return 0;
	}
