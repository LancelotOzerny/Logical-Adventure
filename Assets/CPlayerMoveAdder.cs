using UnityEngine;

public class CPlayerMoveAdder : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private Vector2 difference;
    [SerializeField] private Vector2 lastPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lastPos = transform.position;
            player = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player = null;
        }
    }

    private void FixedUpdate()
    {
        if (player == null)
        {
            return;
        }

        difference = new Vector2(
            transform.position.x - lastPos.x,
            transform.position.y - lastPos.y
        );

        player.transform.position = new Vector2(
            player.transform.position.x + difference.x,    
            player.transform.position.y + difference.y    
        );

        lastPos = transform.position;
    }
}
