using UnityEngine;

public class CDesktopPlayer : CUnit
{
    private new void Awake()
    {
        if (Application.isMobilePlatform)
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
