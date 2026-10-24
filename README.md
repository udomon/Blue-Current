# Blue-Current
A 2D fishing game I made in Unity. Move the hook up and down with the arrow keys (or W/S) to catch the fish as they swim past. Each fish you catch is a point, and each one that gets away costs you a life. You start with 5 lives.

## Running it
Open the project in Unity 6 (6000.3.10f1), open Assets/Scenes/SampleScene.unity and press Play.

## Scripts
- Anchor/AnchorMovement.cs - moves the hook
- Fish/FishSpawner.cs - spawns the fish
- Fish/FishMovement.cs - moves the fish and checks if they're caught or missed
- Fish/ScoreManager.cs - keeps track of the score and lives
- Fish/GameManager.cs - game over screen and restarting
