<h1> Instrucciones de uso </h1>

<li>Cree un archivo 3D de Unity</li>

<li>Colocar un (player)</li>

<li>Colocar el numero de enemigos deseados.</li>

<li>Colocar a los NPC asustados.</li>

<strong>* NOTA: </strong> Se recomienda poner una serca de cubos que funjan como muros, no es necesario, pero evitara que el jugador huya de la escena.
<strong>Esta nota solo es valida si se desactiva el modo mous y se queda con el modo de persecusión</strong>

<h4>player</h4>
<li>Coloque al player el script de Flee y el script de Move by Mouse.</li>
    <ol>
    <li>Si quiere que el jugador se mueva de manera automatica desactive el script Move by Mouse y active el script Flee.</li>

    <li>Si quiere que el jugador siga el Mouse active el script Mouse by Mouse y desactive Flee</li>
    <ol>
<strong>* NOTA: </strong> Se recomienda para tener una mejor experiencia, al Flee del jugador coloque lo siguiente:
    <ol>
    <li> Speed: 25 </li>
    <li> enemies: 5 </li>
    <li> Walls: 32 u opcional </li>
    </ol>

<h4>Enemies</h4>

<li>Coloque al enemie el script de Flee y el script de seeking.</li>
<strong>* NOTA: </strong> Se recomienda para tener una mejor experiencia, al seeking de enemy coloque lo siguiente:
    <ol>
    <li> Speed: 13 </li>
    <li> Enemy:Enemy </li>
    <li> Target: player </li>
    <li> Mass: <strong>Para esta prueba se colocarón 5 enemigos, con masa de 1, 2, 4, 8 y 16 respectivamente. pero este este punto a su gusto. </storng></li>
    </ol>

<strong>* NOTA: </strong> Se recomienda para tener una mejor experiencia, al Flee de enemy coloque lo siguiente:
    <ol>
    <li> Speed: 10 </li>
    <li> Enemy: n(Enemies)  <strong> asegurese que no huya de sí mismo, solo del resto </strong></li>
    <li> Walls: 32 u opcional </li>
    <li> Player: player </li>
    </ol>

<h4>Scared NPCs</h4>

<li>Coloque al NPC el script de Flee.</li>
<strong>* NOTA: </strong> Se recomienda para tener una mejor experiencia, al Flee de Scared NPC coloque lo siguiente:
    <ol>
    <li> Speed: 18 y 20 </li>
    <li> Enemy: n(Enemies) y player </li>
    <li> Walls: 32 u opcional </li>
    <li> Target: npc </li>
    </ol>

Se dejara una imagen de ejemplo en la carpeta.