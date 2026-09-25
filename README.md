# GameEngineSandbox

Created a super short and basic platformer in approximately an hour to demonstrate unity understanding and speed of development. There's a player that can jump and move in 4 directions, by touching the final cube you win. There's a win condition, lose condition, and player controller. It's in 3D with a over-the-shoulder camera. 

**Week 1 Checklist:**<br>
-Player that can be controlled<br>
-Platforms<br>
-Jumping and movement with rigidbody physics<br>
-Lose when falling off the platforms<br>
-Win when touching the last platform<br>
***
**Week 2 Checklist:**<br>
-Changed colours of platforms<br>
-Added a “redder” pickup that changes the floor colour to red to demonstrate an alternate use of pickuppable inheritance<br>
-Added coin pickups and a player money variable to demonstrate encapsulation<br>
-Pickuppable class demonstrates polymorphism and abstraction<br>
-Implemented all 4 OOP principles in code<br>
<br>
<br>
**OOP Principle Explanations:**

**Encapsulation** is used to edit the player’s money. Instead of directly interacting with a public variable of money, we use a setter called GiveMoney() that gets passed the value of the coin. This prevents us from potentially handling giving money in different ways in different areas of code, and also ensures we won’t accidentally miss that we actually subtract money instead of giving it due to an accidental minus sign. The method only increases money, and is passed the coin’s value, it’s that simple.

**Inheritance** is used to make the creation of various pickups much, much easier. Instead of checking for OnTriggerEnter and using CompareTag() in each pickup, each pickup inherits from Pickuppable, and is set up right out of the gate to very simply handle being picked up. When the item is touched by the player, PickedUp() is called, so we can create and play with pickuppable objects a lot easier and faster. Technically this is abstraction, but inheritance allows all pickuppable children to use the abstraction.

**Polymorphism** is used also within the Pickuppable class, as the PickedUp() method is called no matter what kind of object it’s attached to, no matter what the code will end up doing. Pickuppable has no idea what child code will be called, but calls the same method anyways. This allows us to avoid having a chain of if(coin), else if(redder), etc. Same method for any pickuppable object.

**Abstraction** is used to save repeated code in every pickuppable child, and make it simpler to manage the effects of pickups. Just like what was written for Inheritance, instead of checking for CompareTag() and OnTriggerEnter in each pickuppable child, the PickedUp() method is the abstraction. It hides these checks behind a simple method that gets automatically called on contact with the player.
***

**Week 3 Checklist:**<br>
-Made Player a singleton and access it from the Lose Plane and Win Cube to trigger win/loss. Also accessed by coins to give the player money, and for the Win Cube to check the player's money.<br>
-Instead of having prefabs put directly into the map, coins and powerups are spawned by a SpawnPoint factory that triggers the Spawn methods defined within children of Pickuppable
