# Instrucciones
Realizar una escena en donde se integren Steering behaviors a un juego sencillo (2D o 3D)

## Requerimientos Funcionales
1. El jugador debe poder controlar a un sprite mediante clicks para que se mueva. El Click dará la nueva target del jugador para el movimiento Seek() que tendrá.

<p align="center">
<img src="https://github.com/Amerike-dev/InteligenciaArtificial/blob/stagging/Tareas/Tercer%20Tarea/Referencias/img1.png" width="40%" height="40%">
</p>

2. Se deberán crear en el mapa de [20, 40] elementos que el jugador podrá recolectar.

4. Los objetos se recolectan cuando el jugador colisiona con ellos y deberán tener un comportamiento Follow Leader hacia el jugador. El último objeto tomado estará detrás del jugador.

<p align="center">
<img src="https://github.com/Amerike-dev/InteligenciaArtificial/blob/stagging/Tareas/Tercer%20Tarea/Referencias/img2.png" width="40%" height="40%">
</p>

5. Cuando el jugador objenga una tercera parte del total de los elementos el restante tendrá un comportamiento de flee con la mitad de la velocidad (speed) del jugador.

<p align="center">
<img src="https://github.com/Amerike-dev/InteligenciaArtificial/blob/stagging/Tareas/Tercer%20Tarea/Referencias/img3.png" width="40%" height="40%">
</p>

7. Cuando el jugador obtenga 2/3 de la totalidad de los objetos, el restante tendrá un comportamiento avoid con un 80% de la velocidad del jugador y los primeros 3 objetos que había capturado se desprenderan de el, cambiarán de color y tendrán un comportamiento Pursuit.

<p align="center">
<img src="https://github.com/Amerike-dev/InteligenciaArtificial/blob/stagging/Tareas/Tercer%20Tarea/Referencias/img4.png" width="40%" height="40%">
</p>

8. Si un objeto alcanza al player, este deberá soltar al ultimo que lo estaba siguiendo.

## Requerimientos Técnicos
- Usar Listas para los elementos en el mapa.
- Usar un Queue para los elementos que salgan al llegar a los 2/3 de jugadores.
- Usar una clase Steering Behaviors en donde estén todos los comportamientos a usar. 
- El jugador y objetivos deberán heredar de la clase Steering Behaviors.
