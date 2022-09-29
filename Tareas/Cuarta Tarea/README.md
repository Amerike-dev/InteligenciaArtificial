Entrega: 3-Octubre-2022
# Instrucciones
Realizar un script en .cs que implemente el metodo recursivo para realizar:
    
1. El calculo de la serie fibbonacci.
2. Contador de elementos en un array.
3. Suma del contenido de una lista.

Todas deben estar en un mismo script, deben de ser funciones que puedan modificar sus entradas desde variables publicas y mostrarse con `Debug.Log();`

## Calculo de la serie fibbonacci.
Pueden buscar en google como es la serie o en este enlace https://quantdare.com/numeros-de-fibonacci/ 

La formula para calcularla es:
```
fn = f(n-1) + f(n-2)
``` 


## Contador de elementos en un array
Debe regresar la cantidad de elementos, es decir, si hay un 
```
int[] numeros = new int[] {1,2,3,4,5,6...n}
```
El codigo al tener un:
```
Debug.Log(conteo(numeros));
```
Deberia ser `n`

Otro ejemplo: para `{2,343,234,0,2}` el resultado es `5`

## Suma del contenido de una lista
Parecido al ejercicion anterior, solamente que este sera de contenido flotante o entero y debe regresar el valor total.
```
List<int> numeros = new List<int>() {1,2,3,4,5,6}
```
El resultado seria `21`

## Entrega de tarea
1. Crear una carpeta con su nombre en **Cuarta Tarea** 
2. Agregar el archivo .css con todos los ejercicios.
3. Hacer un push a la rama **stagging**
4. Realizar el pull request a master.
5. Resolver las dudas pendientes.