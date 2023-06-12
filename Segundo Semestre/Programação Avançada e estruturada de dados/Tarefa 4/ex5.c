#include <stdio.h>

int main(){
    int a=0,i,j,w,f;
    int num[20],iguais[20];
    
    for(i = 0; i < 20; i++){
    	
        printf("Entre com os valores : ");
        scanf("%d",&num[i]);
    }
    for(i = 0; i < 20; i++){
        for(j = 0; j < 20; j++){
           
            f=0;
            if(num[i] == num[j] && i != j){
                for(w = 0; w < 20; w++){
                    if(iguais[w] == num[j])
					
                        f=1;
                }
                
                if(f == 0){
                    iguais[a]=num[i];
                    a++;
                }
            }
        }
     }
     
     printf("\nNumeros repetidos:\n");
     for(i=0; i<a; i++){
        printf("\n%d ",iguais[i]);
     }
     getch();
     return 0;
}
