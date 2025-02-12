
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GAmeManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }

}
