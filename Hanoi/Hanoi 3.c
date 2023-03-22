#include <stdio.h>

void hanoi (char from,char to,char other,int n)
{
    if (n>0)
    {
        hanoi (from, other, to, n-1);
        printf("%c -> %c\n", from,to);
        hanoi (other, to, from, n-1);
    }
}
int main()
{
    int n;
    printf ("Ingrese un valor: ");
    scanf("%d", &n);
    hanoi('1','2','3', n);
    return 0;
}
