#include<stdio.h>
#include<locale.h>

int main (){
	setlocale(LC_ALL, "Portuguese");
	
	int A, B, C;
	
	printf("\nEntre com o valor de A:");
	scanf("%d",&A);
	
	printf("\nEntre com o valor de B:");
	scanf("%d",&B);
	
	printf("\nEntre com o valor de C:");
	scanf("%d",&C);
	
	if(A >= B && B >= C){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", A, B, C);
	}
	else if(A >= C && C >= B){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", A, C, B);
	}
	else if(B >= A && A >= C){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", B, A, C);
	}
	else if(B >= C && C >= A){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", B, C, A);
	}
	else if(C >= A && A >= B){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", C, A, B);
	}
	else if(C >= B && B >= A){
		
		printf("\nA ordem do maior para o menor é: %d, %d, %d", C, B, A);
	}
	
	return 0;
	}
