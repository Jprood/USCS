#include<stdio.h>

int main(){

int num, soma = 0, par = 0, maior = 0;     
   
   do{
   	printf("Informe um numero: ");
        scanf("%d", &num);
        
        if(num != 999){
        	
        	soma = soma + num;
		}
		
		if(num%2 == 0 && num != 999){
			
			par = par + num;
		}
		
		if(num > maior && num != 999){
			
			maior = num;
		}
        
   }while(num != 999);
   
   printf("\nsoma dos numeros: %d", soma);
   printf("\nsoma dos numeros pares: %d", par);
   printf("\nmaior numero: %d", maior);
   return 0;
}
