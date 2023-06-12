#include <stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
    int a,b;
    
    printf("\nDigite um número: ");
    scanf("%d",&a);
    
    printf("\nDigite um número: ");
    scanf("%d",&b);

    if(a > b){
    	
    a = a - b;
    
    printf ("\nA diferenca dos números digitados é: %d",a);
    }
	else{
		
    a = b - a;
    printf("\nA diferenca dos números digitados: %d",a);

    }

	return (0);
	}
