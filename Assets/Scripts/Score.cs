using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // transform type is responsible for position/rotation/scale
    public Transform player;
    public Text scoreText;

    public 
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
