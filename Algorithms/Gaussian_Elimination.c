/******************************************************************************************************/
/* Devin Rataiczak ************************************************************************************/
/* Assignment 1 ***************************************************************************************/
/******************************************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

void help(char *prog);
void solve(int row);

int main(int argc, char *argv[])
{
    if(argc != 2)
	help(argv[0]);

    int row = atoi(argv[1]);
    if(row == 0)
	help(argv[0]);

    int flag = 0;
    while((flag = getopt(argc, argv, "h")) != -1)
    {
	switch(flag) {
 		case 'h':
			help(argv[0]);
			break;
		case ':':
		case '?':
			fprintf(stderr, "Try -h for more information.\n");
			break;
		default:
			fprintf(stderr, "Invalid option.\n");
			fprintf(stderr, "Try -h for more information.\n");
			
			exit(-1);
	}
    }

    solve(row); 
    return(0);
}

void help(char *prog) {
    printf("Use: %s <Rows>\n", prog);
    printf("This application will use Gaussian Elimination to provide the solutions for an augmented matrix.\n");
    printf("You must supply a nonzero number for the number of rows.\n");

    exit(0);
}

void solve(int row) {
    int i = 0;
    int j = 0;
    int k = 0;
    float matrix[row][row + 1];
    float elem = 0.0;
    float vector[10];
    float sum = 0.0;

    printf("Please enter the elements of your augmented matrix:\n");
    for(i = 1; i <= row; i++)
        for(j = 1; j <= (row + 1); j++)
        {
            printf("Location [%d][%d] : ", i -1, j - 1 );
            scanf("%f", &matrix[i][j]);
        }

    for(j = 1; j <= row; j++)
        for(i = 1; i <= row; i++)
            if(i > j)
            {
                elem = matrix[i][j] / matrix[j][j];
                for(k = 1; k <= row + 1; k++)
                    matrix[i][k] = matrix[i][k] - elem * matrix[j][k];
            }
    
    vector[row] = matrix[row][row + 1] / matrix[row][row];
    
    for(i = row - 1; i >= 1; i--)
    {
        sum = 0;

        for(j = i + 1; j <= row; j++)
            sum = sum + matrix[i][j] * vector[j];

        vector[i] = (matrix[i][row + 1] - sum) / matrix[i][i];
    }

    printf("\nYour results are: \n");
    for(i = 1; i <= row; i++)
        printf("x%d = %f\n", i - 1, vector[i]);

    exit(0);
}