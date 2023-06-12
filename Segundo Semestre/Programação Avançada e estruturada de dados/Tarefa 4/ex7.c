#include <stdio.h>

int main(){
	
	float x[300], t;
	int i, o, c = 0, ca = 0, d = 0;
	
	for(i = 0; i < 300; i++){
		
		printf("Digite o valor gasto: ");
		scanf("%f", &x[i]);
		
		t = t + x[i];
		
		printf("Digite a forma de pagamento: \n1-cheque\n2-cartao\n3-dinheiro\n\n->");
		scanf("%d", &o);
		
		if(o == 1){
			
		c++;	
		}
		else if(o == 2){
			
			ca++;
		}
		else if(o == 3){
			
			d++;
		}
	}
	
	printf("\nTotal de ganhos: %.2f\n", t);
	printf("\nTotal de pessoas que utilizaram: \nCheque: %d \nCartao: %d \nDinheiro: %d", c, ca, d);
}
