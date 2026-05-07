# GDIM 33 In-Class Activities
## W1
### Activity 1
![alt text](<Mind board game.jpg>)

1. Looking at my board, alot of the games have a very futuristic y2k aesthetic. Between Jetset radio Sonic Rider, the visual design of the games corelate heavily with a sci fi theme with the use of older technology. Simliary, many of the games i have dark tones with bright colors. Games like Hades 2 and Sonic adventure 2 have really bright colors contrasting with dark settings and spaces.  Additonally, most of the games have mechanics where fast movement is priotized, like bombrush cyberfunk's different traversal styles.

2. Looking at Evrin lee's board, we both like bright colors with a bit darker tones, where the colors of the characters and elements within a scene is contrasted with the overall dark backgrounds and settings. For example, we both really like Hades design and bonded over the characters and sceneic pieces. 

3. One of the LA's at my table that came up to see my board really and liked Twilight princess. We talked about how we both have not completed Twilight princess but have a very fond apperication of the game. Futhurmore, he also regonized the bleach drawing and was familiar with the anime but hadn't really watched the show.


### Activity 2  
![alt text](<Game project test.png>)

## W2


## W3
### Activity 1
![alt text](<Boostpads Collider.png>)

### Activity 2
1. Saving the event names for state transition as scene variables is useful because it makes the events triggable throughout every graph. Since the names of the graphs are saved as scene variables, that name and event is accesible through every graph of the scene. 

2. While testing if the onMouseDown event work, the debug tool message tool was useful to know at an early stage if the interaction worked correctly. For instance, when i first made the graph, i got an error message first, and after debugging, the debug message i created notified me that the code was working correctly. 

3. My game I need a break will be using a Set Cursor Lock State. Since my game is a first person that will also have a dialogue system similar to the demo, i will defeintely be using a cursor lock state to switch between the UI and gameplay.

4. My game I need a break may have a use to have a game state. When the player spawns in, i want there to be a small area they can interact with NPC's or just walk around, and then start the obstacle course once they finish there interaction with the NPC is finished. For this, i could implement 2 states, one where the player is wandering, and another where the player is actively locked in the obstacle course.

## W4
### Activity 1
Currently, my playtest has:
-First person movement with a jump, dash, and sprint
-a sample obstacle course 
-Sceneic game objedcts 

My playtest goal is to see if the players can:
-Complete the sample obstacle
-stress test my movement mechanics

Playtest members
Evrin Lee, Nicole Yang

Notes:
-Jumping is very inconsistent (will be higher sometimes than others)
-Like the city assets 
-Not able to know how sprint and dash work 
-Can complete the obstacle course, but VERY hard

### Activity 2
Since the main functionality of the graph uses scriptable objects, a writer would be able to add more dialogue lines to the setup without worrying about the backend code. Since the graph automatically creates buttons and uses scriptable objects to generate the dialogue UI, the writer can create the dialogue scriptable objects and only have to hook them up in the inspector.

The writer could make an infinte number of dialogue nodes as long as there is 4 or less reply options. Since the graph is built to keep generating buttons and reply options from each dialogue new node, the writer would be able to keep making dialogue nodes as long as there setup up properly.


Regenrate nodes is a project function that will look for any missing or new nodes added to the unity project and will restore/add them to the project. Since the programmer can make there own events and other nodes on top of the preset unity nodes, unity accounts for this by having a designated button to add any more nodes that are not apart of the base unity nodes. Additonally, if the unity project has any missing nodes from errors or bugs, the regenerate node button will restore them. 

## W5
### Activity 1
feature: NPC interaction

1. When the NPC is clicked, a dialogue box appears
    1. Grab the game object that hold the Dialogue UI
    2. Use OnMouseDown() to see when the player clicks on the NPC
    3. Freeze the movement of the player rigidbody and Open the Dialogue UI box
2. When the player clicks the dialogue button, a new prompt appears
    1. Create a scriptable object that holds the lines of the NPC
    2. Grab a button on the Dialogue UI box
    3. Everytime the player clicks on the Button, new text appear.
3. When the player finishes all of the text, The player is teleported to the beginning of the level
    1. Get the length of the scriptable object to see how big the list of lines are
    2. Once the player gets to the last piece of text, Send an event to the game controller telling the game started
    3. Spawn the player at the beginning of the level

### Activity 2
Today, i was able to get a majority of the NPC interaction done. I was able to get the dialogue box to open when the player clicks on the Object with the NPC interactino script, as well as unlock the mouse and show the cursor. Futhurmore, the player can advance the dialogue by pressing the button on the dialogue box. Finally, i created my GameController locator and invoked an event that will activate once the dialogue is finished.


## W6
### Activity 1 
New: 
-Added NPC (Not anims yet) and functinoality to spawn player into spawn level 
-Readjusted grouded detection that makes the game run smoother 
-changed the movement feeling to a more "slippery" style

[Itch Link](https://romarick-a.itch.io/i-need-a-break-milestone-2)

Playtest Goals:
-See if players like the improved movement 
-See if players can understand what to do with little on screen guidance
-See if player can complete the course with a little difficulty

Notes:
-Movement functinoality is alot better compared to last week
-The slippery effect makes the game very very hard
-jumping is still a bit wonky but alot better
-Change the grounded drag to slip
-Player noticed to talk to the npc without any help


### Activity 2
When applying the mutiplier setting on the blend node, all of RGB values are mutiplied with each other. Since all of the RGB values are values between 0.0 and 1.0, that means when mutiplying the very small decimal number with each other, the resulting value will become smaller, making the final color darker as a result.

Since the mutiply setting mutiplies the small values from 0.0 to 1.0, by adding the alpha channel, the material will become more translucent since the alpha value will become smaller.

Since the sample2D is grabbing another texture2D, the node is pulling the coordinates from the game object that our texture2D is applied to.

I do find the concept of manipulating colors with numbers since I can fine tune saturation and the brigtness of colors without having to check and guess with a premade slider.





