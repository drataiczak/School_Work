#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	int row0 = 0;
	int col0 = 0;
	int row1 = 0;
	int col1 = 0;
	int i = 0;
	int j = 0;
	int k = 0;

	printf("Please enter the number of rows in the first matrix: ");
	scanf("%d", &row0);
	printf("Please enter the number of columns in the first matrix: ");
	scanf("%d", &col0);

	int a[row0][col0];

	printf("Please enter the number of rows in the second matrix: ");
	scanf("%d", &row1);
	printf("Please enter the number of columns in the second matrix: ");
	scanf("%d", &col1);

	if(col0 != row1) {
		printf("[!] The number of columns of your first matrix must be the same as the number of rows of your second matrix.\n");
		exit(-1);
	}

	int b[row1][col1];
	int result[col0][col1];

	printf("Please enter the elements of the first matrix: \n");
	for(i = 0; i < row0; i++) {
		for(j = 0; j < col0; j++) {
			printf("Location [%d][%d]: ", i, j);
			scanf("%d", &a[i][j]);
		}
	}

	printf("\nPlease enter the elements of the second matrix: \n");
	for(i = 0; i < row1; i++) {
		for(j = 0; j < col1; j++) {
			printf("Location [%d][%d]: ", i, j);
			scanf("%d", &b[i][j]);
		}
	}

	for(i = 0; i < row0; i++)
		for(j = 0; j < col1; j++)
			result[i][j] = 0;

	for(i = 0; i < row0; i++)
		for(j = 0; j < col1; j++)
			for(k = 0; k < col0; k++) 
				result[i][j] += a[i][k] * b[k][j];

	printf("Your result: \n");
	for(i = 0; i < row0; i++)
		for(j = 0; j < col1; j++) {
			printf("%d ", result[i][j]);
			if(j == col1 - 1)
				printf("\n\n");
		}

	return 0;

}
