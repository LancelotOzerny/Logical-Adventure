using UnityEngine;
using YG;

public class CMobilePlayer : CUnit
{
    private new void Awake()
    {
        if (Application.isMobilePlatform == false)
        {
            Destroy(this);
        }

        base.Awake();
    }

    public void SetMovementX(float value)
    {
        MoveDirection = new Vector2(value, MoveDirection.y);
    }

    public void SetMovementY(float value)
    {
        MoveDirection = new Vector2(MoveDirection.x, value);
    }
}
