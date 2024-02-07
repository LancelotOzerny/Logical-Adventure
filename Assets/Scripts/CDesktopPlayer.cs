using UnityEngine;
using YG;

public class CDesktopPlayer : CUnit
{
    string Device
    {
        get => YandexGame.EnvironmentData.deviceType.ToLower();
    }

    private new void Awake()
    {
        if (Device != "desktop" && Device != "tv")
        {
            Destroy(this);
        }

        base.Awake();
    }

    private void Update()
    {
        MoveDirection = new Vector2
        (
            Input.GetAxisRaw("Horizontal"),    
            Input.GetAxisRaw("Vertical")
        );
    }
}
