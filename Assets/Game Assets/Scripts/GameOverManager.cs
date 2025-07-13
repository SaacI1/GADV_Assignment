using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    public void TriggerGameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Astrosurvivor");
    }
}