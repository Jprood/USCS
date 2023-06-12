#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double n1;
	
	printf("\nEntre com o valor:");
	scanf("%lf", &n1);
	
	if(n1 > 100 && n1 < 200){
		
		printf("\nO valor %.2lf está entre 100 e 200.", n1);
	}
	else{
		
		printf("\nO valor %.2lf não está entre 100 e 200.", n1);
	}

	return 0;
	}
