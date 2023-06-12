#include <stdio.h>

int main(){
	
	int p[800], i, f, m,idade_p = 0, id[800], soma_i = 0, soma_im = 0;
	float h[800], soma_hf = 0, media_hf, media_im, media_i, percentual;
	
	for(i = 0; i < 5; i++){
		
		printf("\nparticipante %d informe o sexo:\n0-Feminino\n1-Maculino\n\n->", i);
		scanf("%d", &p[i]);
		
		printf("\nInforme sua idade: ");
		scanf("%d", &id[i]);
		
		soma_i = soma_i + id[i];
		
		printf("\nInforme sua altura: ");
		scanf("%f", &h[i]);
		
		if(p[i] == 0){
		
		f++;	
		soma_hf = soma_hf + h[i];	
		}
		else if(p[i] == 1){
			
			m++;
			soma_im = soma_im + id[i];
		}
		
		if(id[i] >= 18 && id[i] <= 35){
			
			idade_p++;
		}			
	}
	
	media_hf = soma_hf/f;
	media_im = soma_im/m;
	media_i = soma_i/i;
	percentual = idade_p*i;
	
	printf("\nMedia de altura das mulheres: %.2f", media_hf);
	printf("\nMedia de idade  dos homens: %.2f", media_im);
	printf("\nMedia da idade: %.2f", media_i);
	printf("\nPercentual de idade entre 18 e 35 anos: %.2f", percentual);
}
