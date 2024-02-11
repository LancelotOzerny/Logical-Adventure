using UnityEngine;

public class CHMovePlatform : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;

    [SerializeField] private float start = 0.0f;
    [SerializeField] private float end = 1.0f;

    [SerializeField] private float target;

    private Vector2 Target
    {
        get => new Vector2(target, transform.position.y);
    }

    private void Start()
    {
        transform.position = Target;
    }

    private void FixedUpdate ()
    {
        float distance = Vector2.Distance(transform.position, Target);

        if (distance < 0.01f)
        {
            target = target == start ? end : start;
        }

        Vector2 newPos = Vector2.Lerp(transform.position, Target, speed * Time.deltaTime);
        transform.position = newPos;
    }
}