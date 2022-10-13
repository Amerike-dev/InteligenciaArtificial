# INSTRUCCIONES
Realizar un juego RTS que tenga una vista isometrica, se deben seleccionar tropas(iniciales) que se enfrentaran en un mapa controlado.
- El mapa debe generarse automaticamente. (incluyendo obstaculos)
- Debe haber diferentes tipos de campos (fields), estos afectaran en el movimiento.
- El movimiento sera mediante click, como en lol.
- Si se encuentran tropas, se deberan enfrentar.

### Mapa
- Se usara un algoritmo de path finding para caminar
- Usar tiles isometricas, referencia: https://assetstore.unity.com/packages/3d/environments/2d-pixelart-isometric-blocks-115039
- Se movera solo en 4 direcciones.
- Tendra tesoros: Tropa extra, recuperar vida, mayor ataque. Que solo podra ser aplicable al jugador.
- Solo tendra campo, no habra edificios ni otros elementos.
- El tamaño minimo debera de ser de 100 x 60.
- La camara seguira al mouse cuando salga de escena.

### Tropas
- Deben tener una cantidad de tropas y vida.
- Se pueden sumar o juntar.
- Tienen una tasa de ataque por tiempo. Cada sierto tiempo acertan un ataque.
- Tienen probabilidad de critico.
- Pueden usar assets creados o crear nuevos, referencia: https://www.youtube.com/watch?v=45gueF62t1Q&t=1049s

### Mecanica ataque
- Los enemigos se mueven random, poco en el mapa. Tienen un rango de vision.
- Al entrar en el rango de vision, se mueven directamente hacia el enemigo.
- Si la velocidad de los enemigos es menor, puedes escapar de los enemigos


El juego acaba cuando un equipo se quede sin tropas.

# Ejercicios de recuperacion
- Agregar niebla de guerra.
- Agregar steering behaviors para efectos de particulas: Referencia https://www.youtube.com/watch?v=_bOXhhjRK8Q.
    - Ejemplo: Ataque a distancia de magia, viento random de hojas, particulas de lava saliendo de tiles de lava, polvo en el aire de bosque. 
- Agregar 3 niveles de dificultad, se reduciran tropas para el jugador en cada uno de ellos.
- El mapa debe tener la capacidad de ser mas grande, minimo 10 veces mas grande.
