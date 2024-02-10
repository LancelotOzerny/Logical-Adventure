using UnityEngine;

public class CDestroyTimer : MonoBehaviour
{
    [SerializeField] private float timer = 0.5f;

    public void Drop()
    {
        Destroy(this.gameObject, timer);
    }
}
