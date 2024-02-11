using UnityEngine;

public class CTeleport : MonoBehaviour
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private GameObject player;

    private void Awake()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void Teleport()
    {
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.transform.position = targetPosition.position;
    }
}
