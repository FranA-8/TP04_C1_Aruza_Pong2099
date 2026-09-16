#Pong2099#
#Español#
##Descripción##

Pong es un videojuego arcade de dos jugadores inspirado en el clásico juego de tenis de mesa. El objetivo es utilizar la paleta para devolver la pelota y evitar que llegue al lado propio de la cancha.

Este proyecto fue desarrollado en Unity utilizando C#, implementando sistemas de movimiento, colisiones, puntuación, temporizador y personalización de los jugadores.

Características
 Modo de juego para 2 jugadores.
 Movimiento independiente de cada jugador.
Pelota con rebotes y colisiones.
Sistema de puntuación.
 Partidas con una duración limitada.
 Personalización del color de los jugadores.
Reinicio y regreso al menú principal al finalizar la partida.
Interfaz de usuario para mostrar la puntuación.

#Controles#

Jugador 1
Tecla	Acción
W	Mover hacia arriba
S	Mover hacia abajo
A Mover izquierda
D Mover derecha
E Girar derecha
Q Girar izquierda
R Color random

Jugador 2
Tecla	Acción
↑	Mover hacia arriba
↓	Mover hacia abajo
→ Mover derecha
← Mover izquierda
N Girar izquierda
M Girar derecha
B Color random

##Sistema de juego##

Durante la partida, los jugadores deben intentar devolver la pelota hacia el campo contrario.

Cada vez que la pelota atraviesa el límite de un jugador, se registra un punto para el jugador contrario.

La partida tiene un temporizador de 20 segundos. Cuando el tiempo termina, se determina el resultado según las reglas establecidas por el juego y posteriormente se regresa al menú principal.

Personalización

El juego permite modificar el color de los jugadores mediante controles RGB.

Cada componente de color puede modificarse independientemente:

Rojo
Verde 
Azul 

Los valores de estos componentes se combinan para generar el color final del jugador.

Developer: Franco Aruza

#English#

Description

Pong is a two-player arcade video game inspired by the classic table tennis game. The objective is to use your paddle to return the ball and prevent it from reaching your side of the court.

This project was developed in Unity using C#, implementing movement, collision, scoring, timer, and player customization systems.

Features
Two-player game mode.
Independent movement for each player.
Ball bouncing and collisions.
Scoring system.
Matches with a limited duration.
Player color customization.
Game restart and return to the main menu when the match ends.
User interface to display the score.
Controls
Player 1
Key	Action
W	Move up
S	Move down
A	Move left
D	Move right
E	Rotate right
Q	Rotate left
R	Random color
Player 2
Key	Action
↑	Move up
↓	Move down
→	Move right
←	Move left
N	Rotate left
M	Rotate right
B	Random color
Game System

During the match, players must try to return the ball toward the opponent's side of the court.

Whenever the ball crosses a player's boundary, a point is awarded to the opposing player.

The match has a 20-second timer. When the time runs out, the result is determined according to the game's rules, and the game then returns to the main menu.

Customization

The game allows players to customize their color using RGB controls.

Each color component can be adjusted independently:

Red
Green
Blue

The values of these components are combined to create the player's final color.

Developer

Franco Aruza
