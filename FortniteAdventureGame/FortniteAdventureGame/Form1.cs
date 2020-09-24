using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/*
Created By: Deo Narayan (and Nolan)
Date: November 8, 2018
Description: This is a program for a Fortnite simulator choose your own adventure game.
The program will first show a loading screen. Then the program will present two or more
options depending on the current scene. Depending on the option you pick, a different 
scene will be presented. The game will end when you have either won or been eliminated. 
At this point in time, you can either restart the game or exit the program.
*/

namespace DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame
{
    public partial class Form1 : Form
    {
        //Global Variables
        //annoucing sound variables
        SoundPlayer takeTheLSoundPlayer = new SoundPlayer(Properties.Resources.takeTheLSound);
        SoundPlayer shotSoundPlayer = new SoundPlayer(Properties.Resources.snipeShotgunSound);
        SoundPlayer machineGunSoundPlayer = new SoundPlayer(Properties.Resources.snipeShotgunSound);
        SoundPlayer runningSoundPlayer = new SoundPlayer(Properties.Resources.runningSound);
        SoundPlayer riftSoundPlayer = new SoundPlayer(Properties.Resources.riftSound);
        SoundPlayer eliminationSoundPlayer = new SoundPlayer(Properties.Resources.eliminatedSound);
        SoundPlayer explosionSoundPlayer = new SoundPlayer(Properties.Resources.explosionSound);
        SoundPlayer OGSongPlayer = new SoundPlayer(Properties.Resources.OGSong);

        //announcing scene integer variable (preset to scene 0)
        int scene = 0;

        // creating random number generator
        Random randGen = new Random();
        //integer values to hold random numbers
        int randomNumberHolder1;
        int randomNumberHolder2;

        public Form1()
        {
            InitializeComponent();
        }
            public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B) //Blue Button Press
            {
                //if the blue button (B key) is pressed, depending on the current scene, the program will move to the according scene
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 5) { scene = 13; }
                else if (scene == 6) { scene = 15; }
                else if (scene == 7) { scene = 17; }
                else if (scene == 8) { scene = 22; }
                else if (scene == 9) { scene = 1; }
                else if (scene == 10) { scene = 1; }
                else if (scene == 11) { scene = 20; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 14) { scene = 27; }
                else if (scene == 15) { scene = 1; }
                else if (scene == 16) { scene = 1; }
                else if (scene == 17) { scene = 1; }
                else if (scene == 18) { scene = 1; }
                else if (scene == 20) { scene = 25; }
                else if (scene == 22) { scene = 1; }
                else if (scene == 23) { scene = 38; }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { scene = 1; }
                else if (scene == 26) { scene = 1; }
                else if (scene == 27) { scene = 36; }
                else if (scene == 28) { scene = 32; }
                else if (scene == 32) { scene = 1; }
                else if (scene == 33) { scene = 1; }
                else if (scene == 34) { scene = 1; }
                else if (scene == 36) { scene = 1; }
                else if (scene == 37) { scene = 1; }
                else if (scene == 38) { scene = 1; }
                else if (scene == 39) { scene = 1; }
                Refresh();
            }
            else if (e.KeyCode == Keys.M)  //Red Button Press
            {
                //holds random number from 1-10
                randomNumberHolder1 = randGen.Next(1, 11);
                //holds random number from 1-2
                randomNumberHolder2 = randGen.Next(1, 3);

                //if the blue button (B key) is pressed, depending on the current scene, the program will move to the according scene
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2)
                {
                    //50% of success (1 in 2 chance program will be set to scene 5)
                    if (randomNumberHolder2 < 2) { scene = 5; }
                    else { scene = 6; }
                }
                else if (scene == 3) { scene = 8; }
                else if (scene == 4)
                {
                    //20% of success (2 in 10 chance program will be set to scene 11)
                    if (randomNumberHolder1 < 3) { scene = 11; }
                    else { scene = 12; }
                }
                else if (scene == 5) { scene = 14; }
                else if (scene == 6) { scene = 16; }
                else if (scene == 7) { scene = 18; }
                else if (scene == 8) { scene = 23; }
                else if (scene == 9) { this.Close(); }
                else if (scene == 10) { this.Close(); }
                else if (scene == 11) { scene = 24; }
                else if (scene == 12) { this.Close(); }
                else if (scene == 13) { this.Close(); }
                else if (scene == 14) { scene = 28; }
                else if (scene == 15) { this.Close(); }
                else if (scene == 16) { this.Close(); }
                else if (scene == 17) { this.Close(); }
                else if (scene == 18) { this.Close(); }
                else if (scene == 20) { scene = 26; }
                else if (scene == 22) { this.Close(); }
                else if (scene == 23) { scene = 39; }
                else if (scene == 35) { scene = 39; }
                else if (scene == 24) { scene = 26; }
                else if (scene == 25) { this.Close(); }
                else if (scene == 26) { this.Close(); }
                else if (scene == 27) { scene = 37; }
                else if (scene == 28) { scene = 34; }
                else if (scene == 32) { this.Close(); }
                else if (scene == 33) { this.Close(); }
                else if (scene == 34) { this.Close(); }
                else if (scene == 36) { this.Close(); }
                else if (scene == 37) { this.Close(); }
                else if (scene == 38) { this.Close(); }
                else if (scene == 39) { this.Close(); }
                Refresh();
            }

            else if (e.KeyCode == Keys.N) //Yellow Button Press
            {
                //if the blue button (B key) is pressed, depending on the current scene, the program will move to the according scene
                if (scene == 0) { scene = 1; }
                if (scene == 4) { scene = 10; }
                else if (scene == 28) { scene = 33; }
                Refresh();
            }

            switch (scene)
            {
                //Different screen shown depending on 'scene' value
                case 1:
                    //loading screen visible
                    loadingScreenLabel.Visible = true;

                    //dark blue background colour
                    this.BackColor = Color.MidnightBlue;

                    //plays Fortnite loading sound
                    OGSongPlayer.Play();

                    //old text is removed
                    loadingScreenLabel.Text = "";

                    //Different pictures make it appear as if the loading bar is gradually increasing
                    loadingScreenLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.LoadingScreen0;
                    Refresh();
                    Thread.Sleep(1000);
                    loadingScreenLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.loadingSceen1;
                    Refresh();
                    Thread.Sleep(4000);
                    loadingScreenLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.LoadingScreen2;
                    Refresh();
                    Thread.Sleep(4000);
                    loadingScreenLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.LoadingScreen3;
                    Refresh();
                    Thread.Sleep(4000);

                    //Fortnite song stops once 'loading' is complete
                    OGSongPlayer.Stop();

                    //loading screen disapears
                    loadingScreenLabel.Visible = false;

                    //Pictures associated with options are shown (middle picture is Fortnite logo if only two options)
                    leftImageLabel.Visible = true;
                    rightImageLabel.Visible = true;
                    middleImageLabel.Visible = true;
                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.johnWick;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.defaultSkin;
                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;

                    //so viewer knows the current situation in the game
                    outputLabel.Text = "You are in a Fortnite Battle Royale. Pick a skin.";

                    //the two options
                    redLabel.Text = "John Wick";
                    blueLabel.Text = "Default";

                    //because current scenario only has two options
                    yellowLabel.Visible = false;

                    break;
                case 2:
                    //changes output label to describe the specific scenario
                    outputLabel.Text = "Another player sees you and is trying to trap kill you!";

                    //shows the two new options
                    redLabel.Text = "Fight the player"; 
                    blueLabel.Text = "Rift-To-Go away";

                    //shows the two new pictures associated with the options
                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.rift;
                    break;
                case 3:
                    outputLabel.Text = "Where you drop, you only see one other player.";
                    redLabel.Text = "Shoot at the player"; 
                    blueLabel.Text = "Hide in a bush";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;
                    break;
                case 4:
                    //machine gun sound to imitate shooting
                    machineGunSoundPlayer.Play();

                    //because current scenario had three options
                    yellowLabel.Visible = true;

                    outputLabel.Text = "The other player rips through your shield and you are left with 80 health.";
                    redLabel.Text = "Shoot your rocket launcher";
                    blueLabel.Text = "Shoot your AR";
                    yellowLabel.Text = "Build walls around you";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.RPG;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.coward;
                    break;
                case 5:
                    //Successful Outcome
                    //to imitate sound of a rift in Fortnite
                    riftSoundPlayer.Play();

                    outputLabel.Text = "You escape safely.";
                    redLabel.Text = "Hide in a bush";
                    blueLabel.Text = "Farm materials";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.wood;
                    break;
                case 6:
                    //Unsuccessful Outcome
                    riftSoundPlayer.Play();

                    outputLabel.Text = "The other player uses the rift and follows you!";
                    redLabel.Text = "Build battle the player";
                    blueLabel.Text = "Run away";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.buildBattle;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.runningCharacter;
                    yellowLabel.Visible = false;
                    break;
                case 7:
                    riftSoundPlayer.Play();

                    outputLabel.Text = "The other player rifts away";
                    redLabel.Text = "Rift after the player";
                    blueLabel.Text = "Don't bother";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.rift;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.coward;
                    yellowLabel.Visible = false;
                    break;
                case 8:
                    machineGunSoundPlayer.Play();

                    //First output
                    outputLabel.Text = "The player sees you in the bush and start shooting!";

                    //Removes labels (all information has not been presented yet)
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    //pause
                    Refresh();
                    Thread.Sleep(3000);


                    outputLabel.Text = "Uh Oh! Mr. T sees you playing Fortnite in class";

                    //option are visible
                    leftImageLabel.Visible = true;
                    rightImageLabel.Visible = true;
                    redLabel.Text = "Stop playing like a good child";
                    blueLabel.Text = "Explain to Mr. T that you're being shot at";
                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.happyTeacher;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.muchDisapointment;
                    Refresh();
                    break;
                case 9:
                    outputLabel.Text = "You accidently rocket launch the ground below you and you eliminate yourself";

                    //elimination sound is played
                    eliminationSoundPlayer.Play();

                    //red background colour to represent you being eliminated
                    this.BackColor = Color.Red;

                    //reel3 is switched back to Fortnite logo
                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;

                    //if play again, the program will go back to scene 1
                    redLabel.Text = "Play again";

                    //if exiting the game, the program will close
                    blueLabel.Text = "Exit the game";

                    //necesary because was visible in the previous scene
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    //because there are no pictures required to go with the options (the game is over)
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;
                    break;
                case 10:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "You accidently build floors instead of walls. Player shoots you easily.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    Thread.Sleep(1000);
                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 11:
                    shotSoundPlayer.Play();
                    Thread.Sleep(1000);

                    outputLabel.Text = "You get a head shot dealing 170 damage to the opponent. You get the elimination!";
                    redLabel.Text = "Start dancing";
                    blueLabel.Text = "Don't bother";

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "Your shot deals 1 damage to the opponent. The other player kills you easily. ";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 13:
                    outputLabel.Text = "A player sees you in the bush. You get sniped.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 14:
                    outputLabel.Text = "You are safe... ...for now!";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();

                    leftImageLabel.Visible = true;
                    rightImageLabel.Visible = true;
                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.stormCircle;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.coward;

                    outputLabel.Text = "There are 10 people left in the match and you are not in the next circle.";
                    redLabel.Text = "Move to a bush in the next circle";
                    blueLabel.Text = "Build a 1 by 1 in the circle";
                    break;
                case 15:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Your Fortnite lags and you die of fall damage!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    eliminationSoundPlayer.Play();
                    this.BackColor = Color.Red;

                    break;
                case 16:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "The other player easily shoots you";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 17:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Someone snipes you as you are gliding through the air!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 18:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Another player that you did not see snipes you from behind";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 20:
                    takeTheLSoundPlayer.Play();

                    outputLabel.Text = "There are 3 people left in the match";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;
                    break;
                case 22:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Bad choice! You lost.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    this.BackColor = Color.Red;
                    eliminationSoundPlayer.Play();
                    break;
                case 23:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Mr. T is very understanding and allows you to keep playing.";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Refresh();
                    Thread.Sleep(3000);

                    outputLabel.Text = "You shoot back at your opponent and get the elimination";

                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();

                    leftImageLabel.Visible = true;
                    rightImageLabel.Visible = true;
                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;

                    outputLabel.Text = "There is only one other player left in the match and it's a noob.";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";
                    break;
                case 24:
                    outputLabel.Text = "There are only 3 people left in the match";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;
                    break;
                case 25:
                    outputLabel.Text = "You snipe a player! There are only 2 people left";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "The school wifi cuts out and your screen freezes. " +
                        "You don't know what happened, but it's safe to say you died.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    this.BackColor = Color.Red;
                    eliminationSoundPlayer.Play();
                    break;
                case 26:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Someone sees you get into the bush and snipes you.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 27:
                    outputLabel.Text = "You successfully make it to the next bush";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();

                    outputLabel.Text = "A player is killed. There are only 2 people left.";
                    redLabel.Text = "Stay in your bush";
                    blueLabel.Text = "Engage";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.bush;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.gun;
                    break;
                case 28:
                    yellowLabel.Visible = true;

                    outputLabel.Text = "What material do you use?";
                    redLabel.Text = "Wood";
                    blueLabel.Text = "Metal";
                    yellowLabel.Text = "Stone";

                    leftImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.wood;
                    rightImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.metal;
                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.brick;
                    break;
                case 32:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Someone rocket launches you!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    explosionSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();               
                    break;
                case 33:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "A grenade is thrown into your base!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    explosionSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 34:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "You get sniped";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    middleImageLabel.Image = DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.battleRoyal;
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;

                    shotSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    Thread.Sleep(1500);
                    eliminationSoundPlayer.Play();
                    break;
                case 36:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "The other player dies in the storm. You won!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    //music because of the successful attempt
                    takeTheLSoundPlayer.Play();
                    //Green background representing the success
                    this.BackColor = Color.Green;
                    break;
                case 37:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Because you're trash, the other player kills you instantly!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    eliminationSoundPlayer.Play();
                    this.BackColor = Color.Red;
                    break;
                case 38:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "Your Fortnite crashes. What a shame!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    this.BackColor = Color.Red;
                    eliminationSoundPlayer.Play();
                    break;
                case 39:
                    leftImageLabel.Visible = false;
                    rightImageLabel.Visible = false;

                    outputLabel.Text = "The other player dies of fall damage. You won!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";

                    takeTheLSoundPlayer.Play();
                    this.BackColor = Color.Green;
                    break;

            }
        }
    }
}