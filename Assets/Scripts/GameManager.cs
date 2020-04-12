using UnityEngine;
// use this if we need to change or renew a scene
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    // Start is called before the first frame update
    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("Game over");
            // a timer on calling a function
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);

    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
