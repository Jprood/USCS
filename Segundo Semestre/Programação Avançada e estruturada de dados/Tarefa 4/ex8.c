#include <stdio.h>

int main(){

    int  v[500], i, c1 = 0, c2 = 0, b = 0, n = 0, cv = 0, t = 0;

    for(i = 0; i < 500; i++){

    printf(" Escolha seu voto: \n1 - Primeiro Candidato \n2 - Segundo Candidato \n3 - Voto branco \n4- Voto nulo\n\n->");
    scanf("%d", &v[i]);

    if (v[i] == 1){
    	
        printf("\nPrimeiro Candidato selecionado");
        c1++;
    }
    else if(v[i] == 2){
    	
        printf("\nSegundo Candidato selecionado");
        c2++;
    }
    else if(v[i] == 3){
    	
        printf("\nVoto branco selecionado");
        b++;
    }
    else if(v[i] == 4){
    	
        printf("\nVoto Nulo selecionado");
        n++;
    }
}

    t = c1 + c2 + b + n;

    printf("\nTotal candidato 1: %d", c1);

    printf("\nTotal candidato 2: %d", c2);

    printf("\nTotal votos brancos: %d ",b );

    printf("\nTotal votos brancos: %d ",n );

    printf("\nTotal votos lidos: %d ",t );

    if (c1 > c2){
        printf("\nO candidato 1 venceu");
    }
    else{
        printf("\nO candidato 2 venceu");
    }
}
