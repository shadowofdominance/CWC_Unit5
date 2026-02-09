# Create With Code Unit - 5 | Unity Version 6000.3.4f1

### _What things did I learn in this unit!?_

- This unit was all about handling the _UI_ through the good old _Canvas_!
- Learned how to title screen and end screen!
- Also learned how to loop the game, basically stopping after its over and restarting it if the player presses restart.

### Major Programming Concepts Learned

- Learned how to again use `Co-Routines`.
- Was mostly focused on Text and Buttons.
- Learned how to call an event if the a `Button` is clicked. We can do it 2 ways. Using the Unity Editor to add an event or just use a script. Implemented in [DifficultyButton.cs](Assets/Scripts/DifficultyButton.cs#L-12).
- Learned how to update the text over time. Implemented in [GameManager.cs](Assets/Scripts/GameManager.cs#L-37).
- Learned about `RayCast` because I was using the new Input System, I couldn't use the `OnMouseDown`. Implemented in [Target.cs](Assets/Scripts/Target.cs#L-63).
- Learned how and when to call the _Title screen_ and the _End Screen_. Implemented in [GameManager.cs](Assets/Scripts/GameManager.cs#L-42)

# Completed the Challenge!

#### The difficulty buttons look messy

- **Solution:** In the unity editor select the text of the buttons and adjust their position individually!

#### The food is being destroyed too soon

- **Solution:** In [TargetX.cs](Assets/Challenge%205/Scripts/TargetX.cs#L-30), change `OnMouseEnter()` to `OnMouseDown`.

#### The Score is being replaced by the word “score”

- **Solution:** In [GameManagerX.cs](Assets/Challenge%205/Scripts/GameManagerX.cs#L-73), write this `score += scoreToAdd; scoreText.text = "Score:" + score;`

#### When you lose, there’s no way to Restart

- **Solution:** In [GameManagerX.cs](Assets/Challenge%205/Scripts/GameManagerX.cs#L-80), change the boolean value to true

#### The difficulty buttons don’t change the difficulty

- **Solution:** In [GameManagerX.cs](Assets/Challenge%205/Scripts/GameManagerX.cs#L-26), we have to add a new parameter `int difficulty` to `StartGame()` method.
- Also change the `spawnRate` variable to this `spawnRate /= diffulty;`
