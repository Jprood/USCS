#include <stdio.h>
#include<locale.h>

int main(){
	setlocale(LC_ALL, "Portuguese");
	
    int a,b;
    
    printf("\nDigite um n�mero: ");
    scanf("%d",&a);
    
    printf("\nDigite um n�mero: ");
    scanf("%d",&b);

    if(a > b){
    	
    a = a - b;
    
    printf ("\nA diferenca dos n�meros digitados �: %d",a);
    }
	else{
		
    a = b - a;
    printf("\nA diferenca dos n�meros digitados: %d",a);

    }

	return (0);
	}
