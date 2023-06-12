#include<stdio.h>

int main(){
	double P1, P2, P3, media ;
	
	printf("Digite a nota 1: ");
	scanf("%lf", &P1);
	
	printf("Digite a nota 2: ");
	scanf("%lf", &P2);
	
	printf("Digite a nota 3: ");
	scanf("%lf", &P3);
	
	media = (P1*1 + P2*2 + P3*3)/6;
	
	printf("%f", media);
	if(media >= 5){
		
		printf("Primeira nota: %.2f\n", P1);
		printf("Segunda nota: %.2f\n", P2);
		printf("Terceira nota: %.2f\n", P3);
		printf("media: %.2f\n", media);
		printf("Aprovado!");
	}
	else{
		
		printf("Primeira nota: %.2f\n", P1);
		printf("Segunda nota: %.2f\n", P2);
		printf("Terceira nota: %.2f\n", P3);
		printf("media: %.2f\n", media);
		printf("Reprovado!");
	}
	return 0;
}
