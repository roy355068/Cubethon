using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // NEED to use this method name to make the trigger works as expected
    private void OnTriggerEnter(Collider other) {
         gameManager.CompleteLevel();
    }
}
