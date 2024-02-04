using UnityEngine;

public class CFailPlatform : MonoBehaviour
{
    [SerializeField] private float speed = 6.0f;
    
    private bool IsActive 
    { 
        get; 
        set; 
    }
    
    public void Run()
    {
        IsActive = true;
    }

    private void Update()
    {
        if (IsActive == false)
        {
            return;
        }

        transform.position = new Vector2(
            transform.position.x,    
            transform.position.y - speed * Time.deltaTime    
        );
    }
}
