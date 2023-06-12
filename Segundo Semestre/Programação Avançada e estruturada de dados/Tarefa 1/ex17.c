#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double n1, n2, n3, n4, media;
	
	printf("\nEntre com o valor da primeira nota:");
	scanf("%lf",&n1);
	
	printf("\nEntre com o valor da segunda nota:");
	scanf("%lf",&n2);
	
	printf("\nEntre com o valor da terceira nota:");
	scanf("%lf",&n3);
	
	printf("\nEntre com o valor da quarta nota:");
	scanf("%lf",&n4);
	
	media = (n1 + n2 + n3 + n4)/4;
	
	if(media >= 5){
		
		printf("Aluno aprovado!");
	}
	else{
		
		printf("Aluno reprovado!");
	}
	
	printf("\nMédia: %.2f", media);
	
	return 0;
	}
