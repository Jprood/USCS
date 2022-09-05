#include <stdio.h>
#include <locale.h>

int main () {
	setlocale(LC_ALL, "Portuguese");
	double n;
	
	printf("Entre com um valor númerico double: ");
	scanf("%lf", &n);
	
	printf("O valor entrado foi: %.2f", n);
	
	return 0;
	
}
