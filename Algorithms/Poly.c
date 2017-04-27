/******************************************************************************************************/
/* Devin Rataiczak ************************************************************************************/
/* Assignment 3 ***************************************************************************************/
/******************************************************************************************************/

#include <stdio.h>

double poly_eval(double coeff[], int x, int degree);

int main() {
	int x = 0;
	int num_coeff = 0;
	int i = 0;
	int degree = 0;
	double result = 0.0;

	printf("Please enter the point at which you'd like to solve for: ");
	scanf("%d", &x);

	printf("Please enter the amount of coefficients in your polynomial: ");
	scanf("%d", &num_coeff);

	double coeff[num_coeff];

	printf("Please enter your coefficients: \n");
	for(i = 0; i < num_coeff; i++) {
		printf("Location [%d]: ", i);
		scanf("%lf", &coeff[i]);
	}

	printf("Please enter the degree of your polynomial: ");
	scanf("%d", &degree);

	result = poly_eval(coeff, x, degree);
	printf("Result: %f\n", result);

	return 0;
}

double poly_eval(double coeff[], int x, int degree) {
	double val = coeff[0];
	int pow = 1;
	int i = 0;

	for(i = 1; i <= degree; i++) {
		pow = pow * x;
		val = val + coeff[i] * pow;
	}

	return val;
}