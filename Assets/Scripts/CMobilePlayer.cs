using UnityEngine;
using YG;

public class CMobilePlayer : CUnit
{
    string Device
    {
        get => YandexGame.EnvironmentData.deviceType.ToLower();
    }

    private new void Awake()
    {
        if (Device != "mobile" && Device != "tablet")
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
