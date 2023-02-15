#include <stdio.h>

int main(){
	int N=0,M=0,i,j,aux=0;
	
	do{
		printf("nuemero de datos arreglo 1: ");
	    scanf("%d",&N);
	}while(N<=0 || N>=101);
	
	do{
		printf("nuemero de datos arreglo 2: ");
	    scanf("%d",&M);
	}while(M<=0 || M>=101);
	
	int VEN1[N];
	int VEN2[M];
	int aux1[N];
	int aux2[M];
	
	printf("introduzca los datos de la primera matriz\n");
	
	for(i=0;i<N;i++){
		printf("%d- ",i+1);
		scanf("%d",&VEN1[i]);
	}
	/*
	for(i=0;i<N;i++){
		printf("%d ,",VEN1[i]);
	}*/
	printf("\n");
	for(i=1;i<N;i++){
		for(j=0;j<N-i;j++){
			if(VEN1[j]>VEN1[j+1]){
				aux=VEN1[j];
				VEN1[j]=VEN1[j+1];
				VEN1[j+1]=aux;
			}
		}
	}
	for(i=0;i<N;i++){
		printf("%d ,",VEN1[i]);
	}
	
	printf("\n\n");
	
	for(i=0;i<M;i++){
		printf("%d- ",i+1);
		scanf("%d",&VEN2[i]);
	}
	
	for(i=1;i<M;i++){
		for(j=0;j<M-i;j++){
			if(VEN2[j]>VEN2[j+1]){
				aux=VEN2[j];
				VEN2[j]=VEN2[j+1];
				VEN2[j+1]=aux;
			}
		}
	}
	for(i=0;i<M;i++){
		printf("%d ,",VEN2[i]);
	}
	
	printf("\n\n");
	
	for(i=0;i<100;i++){
		if(N<M){
			aux1[i]=VEN1[i]+VEN2[i];
			if(i==N-1){
				break;
			}
		}else if(M<N){
			aux2[i]=VEN1[i]+VEN2[i];
			if(i==M-1){
				break;
			}
		}else if(N=M){
			aux1[i]=VEN1[i]+VEN2[i];
			if(i==N-1){
				break;
			}
		}
	}
	
	for(i=0;i<100;i++){
		if(N<M){
			printf("%d, ",aux1[i]);
			if(i==N-1){
				for(j=i+1;j<M;j++){
					printf("%d, ",VEN2[j]);
				}
				break;
			}
		}else if(M<N){
			printf("%d, ",aux2[i]);
			if(i==M-1){
				for(j=i+1;j<N;j++){
					printf("%d, ",VEN1[j]);
				}
				break;
			}
		}else if(N=M){
			printf("%d, ",aux1[i]);
			if(i==N-1){
				break;
			}
		}
	}
	
	return 0;
}
