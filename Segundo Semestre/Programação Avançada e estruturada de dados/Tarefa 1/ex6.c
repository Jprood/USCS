#include<stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	double n1;
	
	printf("\nEntre com o valor:");
	scanf("%lf", &n1);
	
	if(n1 > 200 && n1 < 300){
		
		printf("\nO valor %lf est� entre 200 e 300", n1);
	}
	else{
		
		printf("\nO valor %lf n�o est� entre 200 e 300", n1);
	}


	return 0;
	}
