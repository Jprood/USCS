#include <stdio.h>
#include <locale.h>

int main () {
	setlocale(LC_ALL, "Portugues");
	float n;;
	
	printf("Entre com um valor númerico float: ");
	scanf("%f", &n);
	
	printf("O valor entrado foi: %.3f", n);
	
	return 0;
	
}
