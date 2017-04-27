#include <stdio.h>
#include <stdlib.h>

void help(char *prog) {
	printf("Usage: %s <Base>\n", prog);
	exit(0);
}

int main(int argc, char *argv[]) {
	if(argc != 2) 
		help(argv[0]);

	int base = atoi(argv[1]);
	int res = 1;

	for(base = base; base > 0; base--) 
		res *= base;

	printf("Result: %s! = %d\n", argv[1], res);

	return 0;
}
	
