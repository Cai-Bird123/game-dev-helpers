# game-dev-helpers
Useful snippets of code and modular systems that could be reused or iteratively improved. 
first change

<h1> Utility map </h1> 
<h2> Card Games </h2>
<h3> CardRotation.cs </h3>
Based on class by Vladimir Limarchenko in his udemy course - main alteration is allowing an assigned camera to be used instead of searching for camera main due to performance issues 
uses raycast from assigned camera to hit a gameobject in front of the card. 
If ray hits the object first then card is face up 
If ray has to cross the card collider then card is rotated to be face down, and therefore disable the front of the card graphics and show the back of the card graphics. 

<h1> Gotchas </h1> 

<h1> Useful techniques and resources </h1> 
