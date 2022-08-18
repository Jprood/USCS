#include <stdio.h>
#include <locale.h>

int main () {
	setlocale(LC_ALL, "Portugues");
	int n;
	
	printf("Entre com um valor numerico inteiro: ");
	scanf("%d", &n);
	
	printf("O valor entrado foi: %d", n);
	
	return 0;
}
