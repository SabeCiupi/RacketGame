# RacketGame

![Gameplay Demo](gif/gif3.gif)

## Description
I've started working on a new game. :D It's a recreation of a simple project I made in C++ around 5 years ago. In the original version, the idea was to control a racket and avoid asteroids, with each asteroid giving 10 points. In this new version, I'm turning it into a shooter-style game, where the enemies are alien cats. The main goal is to learn by practicing.

### Controls
- **Movement:** W/A/S/D or Arrow Keys  
- **Shoot:** Spacebar

## Used Technologies
- Unity + C#
- Visual Studio

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/SabeCiupi/RacketGame.git
2. Open the project in Unity
3. Run the main scene from the `Scenes` folder

---

## Development Log

| Update Description                                                                                                                          | Release Date  |
|---------------------------------------------------------------------------------------------------------------------------------------------|---------------|
| Implemented basic player mechanics, including top-down movement and shooting a horizontal projectile. Learned how to use Unity's Input System and Rigidbody2D for smooth directional control and how to instantiate objects using simple scripting. This serves as the core control scheme for the future game interactions. | July 4, 2025  |
| Added the game background, implemented player collision with enemies, as well as bullet collision with enemies. Introduced enemies moving horizontally, with randomized spawning points to enhance gameplay variability.                                                                                     | July 5, 2025  |
| Added a moving background featuring planets acting as tangible obstacles that move synchronously with the background. These obstacles are spawned randomly to increase gameplay complexity and visual interest. | July 12, 2025 |

## Development Demos

### July 4, 2025 — Basic Player Mechanics

![Player Movement and Shooting](gif/gif1.gif)

### July 5, 2025 — Enemies and Collision Mechanics
![Enemies Movement and Collision](gif/gif2.gif)

---

## Bibliography / Tutorials Used

- [BMo - 2D Top Down Movement UNITY Tutorial](https://www.youtube.com/watch?v=u8tot-X_RBI)
- [Distorted Pixel Studios - 2D Bullet / Projectiles in Unity / 2023](https://www.youtube.com/watch?v=8TqY6p-PRcs)
- [ChronoABI - Simple Wave spawner in Unity 2D](https://www.youtube.com/watch?v=pKN8jVnSKyM)
- [Root Games - Unity 2D: Scrolling Background](https://www.youtube.com/watch?v=Wz3nbQPYwss)

> These tutorials were essential in mastering core gameplay mechanics such as character movement, projectile behavior, and enemy wave spawning in Unity.
