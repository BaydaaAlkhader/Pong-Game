using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartGM()
    {
        SceneManager.LoadScene(0);
    }
}
