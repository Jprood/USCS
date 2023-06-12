#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int n_copias;
	double total = 0;
	
	printf("\nDigite o número de copias desejado: ");
	scanf("%d", &n_copias);
	
	if(n_copias < 200){
		
		total = n_copias * 0.50;
	}
	else{
		
		total = n_copias * 0.30;
	}
	
	printf("\nO valor a ser pago é: %.2lf", total);
	
	return 0;
}
