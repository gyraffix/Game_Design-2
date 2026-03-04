using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject levelCompleteScreen;
    private void OnTriggerEnter(Collider other)
    {
        levelCompleteScreen.SetActive(true);
    }
}
