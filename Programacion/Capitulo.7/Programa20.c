#include <stdio.h>
#include <string.h>

int longitud(char cad); // Prototipo de funci�n.
void main(void)

{
    int i, n, l = -1, p, t;
    char cad[50], FRA[20][50];
    printf("\nIngrese el numero de filas del arreglo: ");
    scanf("%d", &n);
    for (i=0; i<n; i++)
    {
        printf("Ingrese la linea %d de texto. Maximo 50 caracteres: ", i+1);
        fflush(stdin);
        gets(FRA[i]); // Se lee la cadena de caracteres dentro del ciclo.
    }
    printf("\n");
    for (i=0; i<n; i++)
    {
        strcpy(cad, FRA[i]);
        t = longitu (cad);
        if (t > l)
        {
            l = t;
            p = i;
        }
    }
    printf("\nLa cadena con mayor longitud es: ");
    puts(FRA[p]);
    printf("\nLongitud: %d", l);
}
int longitu(char *cadena)
/* Esta funci�n calcula la longitud de la cadena. Es id�ntica a la funci�n
cuenta del programa 7.13. */
{
    int cue = 0;
    while (! cadena[cue] == '\0')
        cue++;
    return (cue);
}
