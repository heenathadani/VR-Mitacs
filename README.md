# Collaborative VR Project - Mitacs Globallink Research Internship Program

### This project describes the progress of connected players in a Virtual Reality Game to a disconnected player once it relogs in the room. Unity Photon Pun is to create the server settings of the game. It allows unlimited number of player to get connected to the server. 

## To Run this on your PC / Desktop - 
* Import Unity Photon Pun 2 from the Asset Store. 
* After Importing Photon Pun will ask for an APP ID. Click on Create using Email ID. Photon Pun Project Dashboard will open once email ID is entered. 
* On the Photon Pun Project Dashboard: Create a new application of Photon type PUN and give a name to your application. Click on Create and Copy the generated APP ID.
* Head back to Unity and Paste APP ID through : Window > Photon Unity Networking > Highlight Server Setting
#### Your Unity Client is now connected to the Unity Photon Server

## Build Settings over VR Headset -
* Head to File > Build Settings (CTRL + SHIFT + B) > Android Tab > Texture Compression (ASTC) > Run Device (Oculus Quest 2 / All Compatible Devices) > Max Texture Size (Max 2048) > Switch Platform
* Build and Run (CTRL + B) 

#### You can now view a player connected to the server. 
