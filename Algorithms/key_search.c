#include <stdio.h>
#include <stdlib.h>

int main() {
	int size = 0;
	int i = 0;
	int search = 0;

	printf("Please state the size of your list: ");
	scanf("%d", &size);

	int array[size];

	printf("Please enter the elements of your array: \n");
	for(i = 0; i < size; i++) {
		printf("Location [%d]: ", i);
		scanf("%d", &array[i]);
	}

	printf("What are you searching for? ");
	scanf("%d", &search);

	printf("Searching...\n");

	for(i = 0; i < size; i++)
		if(search == array[i]) {
			printf("Found! Your desired item is at location [%d]\n", i);
			exit(0);
		}

	printf("Unable to find your item.\n");

	return 0;
}
