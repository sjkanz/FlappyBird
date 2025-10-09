using UnityEngine;
using UnityEngine.UI; //adds UI stuff! allows us to make the reference to text
using UnityEngine.SceneManagement; //needed since we are managing scenes

public class LogicScript : MonoBehaviour
{
    //we've deleted start and update from this script because we don't need them
    public int playerScore;
    //Text isn't a thing?
    //well, by default, a script only loads in things that you need for basic Unity functionality
    //however, we can import it!
    public Text scoreText;
    public GameObject gameOverScreen;

    //this one is public void bc we will run this func from other scripts

    //context menu allows us to run our function from unity
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        //sceneManager.LoadScene(); - this on its own is looking for a scene, quite literally a filename
        //however, since we want the current scene, our code can look like below:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true); //turns on the visibility of the game over screen
    }
}
