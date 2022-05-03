using UnityEngine;

public class EndTrgger : MonoBehaviour
{
    public GameManager gameManager;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Win"))
        {
            gameManager.CompleteLevel();
        }
    }
}
