using UnityEngine;
using UnityEngine.SceneManagement;
public class CalledMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
