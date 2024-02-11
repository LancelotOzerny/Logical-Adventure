using UnityEngine;

public class CCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField][Range(0, 1)] private float speed = 0.025f;
    [SerializeField] private bool freezeX;
    [SerializeField] private bool freezeY;

    [SerializeField] private float minX = -100;
    [SerializeField] private float maxX = 100;

    private Vector3 Pos 
    { 
        get => transform.position; 
        set => transform.position = value; 
    }

    private Vector3 TargetPos
    {
        get
        {
            Vector3 result = new Vector3(
                freezeX ? Pos.x : target.transform.position.x,
                freezeY ? Pos.y : target.transform.position.y,
                Pos.z
            );

            if (result.x < minX)
            {
                result.x = minX;
            }

            if (result.x > maxX)
            {
                result.x = maxX;
            }

            return result;
        }
        set => target.transform.position = value;
    }

    private void Awake()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }

        Pos = TargetPos;
    }

    private void FixedUpdate()
    {
        if (target == null)
        {
            return;
        }

        Pos = Vector3.Lerp(Pos, TargetPos, speed);
    }
}
