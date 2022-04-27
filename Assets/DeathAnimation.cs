using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    public GameObject gameObject;
    void BOOOOM()
    {
        Instantiate(gameObject, transform);
    }
}
