using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    
    void Update()
    {
        bool isGameEnded = FindObjectOfType<GameManager>().getIsEnded();
        //update score if the game is not ended
        if (!isGameEnded)
            scoreText.text =  player.position.z.ToString("0");
    }
}
