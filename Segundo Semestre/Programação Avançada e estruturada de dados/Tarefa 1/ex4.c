#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	char nome[30];
	double n1, n2, n3, media;
	
	printf("\nEntre com o nome do aluno:");
	scanf("%s",&nome);
	
	printf("\nEntre com o valor da primeira nota:");
	scanf("%lf",&n1);
	
	printf("\nEntre com o valor da segunda nota:");
	scanf("%lf",&n2);
	
	printf("\nEntre com o valor da terceira nota:");
	scanf("%lf",&n3);
	
	media = (n1*2 + n2*4 + n3*6)/12;
	
	printf("\nNome do Aluno: %s", nome);
	printf("\nMédia: %.2f", media);
	
	return 0;
	}
