#include <stdio.h>

int main(){

float num[15], cubo[15];
int i;

for(i = 0; i < 15; i++){
	
	printf("Digite um valor: ");
	scanf("%f", &num[i]);
	
	cubo[i] = num[i] * num[i] * num[i];
}

printf("\nVetores:\n");
for(i = 0; i < 15; i++){
	
	printf("Numero digitado: %.2f  --> cubo do numero: %.2f\n", num[i], cubo[i]);
}

return 0;
}
