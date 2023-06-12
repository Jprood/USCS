#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	int idade;
	
	printf("\nInforme sua idade: ");
	scanf("%d", &idade);
	
	if(idade > 0 && idade <= 13){
		
		printf("\nCategoria infantil");
	}
	else if(idade > 13 && idade <= 17){
		
		printf("\nCategoria juvenil");
	}
	else if(idade >17 && idade <=100){
		
		printf("\nCategoria sênior");
	}
	else{
		
		printf("idade invalida");
	}
	
	return 0;
	}
