using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageGame : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject levelComplete;

    public void CompleteLevel() {
        levelComplete.SetActive(true);
    }

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("End Game!");
            //RestartGame();
            Invoke("RestartGame", restartDelay);
        }
    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
