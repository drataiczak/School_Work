#include <stdio.h>
#include <stdlib.h>

void help(char *prog) {
	printf("Usage: %s <Base> <Power>\n", prog);
	exit(0);
}

int main(int argc, char *argv[]) {
	if(argc != 3) 
		help(argv[0]);

	int base = atoi(argv[1]);
	int pow = atoi(argv[2]);
	double res = 1.0;
	int i = 0;
	double t = 1.0;

	if(pow < 0) { 
		pow *= -1;

		for(i = 0; i < pow; i++)
			t *= base;
	
		res = (1.0 / t);
	}
	else 
		for(i = 0; i < pow; i++) 
			res *= base;

	printf("Result: %s^%s = %f\n", argv[1], argv[2], res);

	return 0;
}
