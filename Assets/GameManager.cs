using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool isGameEnded = false;
    public void GameOver(){
        if (!isGameEnded)
        {
            Debug.Log("game over");
            isGameEnded = true;
            GameOverMsg();
        }
    }

    private void Update() {
        if (Input.GetKey("space") && isGameEnded)
            {
                Restart();
            }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GameOverMsg(){
        string scoreText = FindObjectOfType<score>().scoreText.text.ToString();
        FindObjectOfType<GameOver>().msg.text = "GAME OVER! \n Press 'space' to restart.";
        Debug.Log(scoreText);
    }

    public bool getIsEnded(){
        return isGameEnded;
    } 
}
