using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNumberView : MonoBehaviour
{
    public TMP_Text text;
    private void Start()
    {
        int levelNumber= SceneManager.GetActiveScene().buildIndex;
        text.text ="Level "+levelNumber;
    }
}
