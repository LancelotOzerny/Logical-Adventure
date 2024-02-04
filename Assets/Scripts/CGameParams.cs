using UnityEngine;

public class CGameParams : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1.0f;        
    }

    public void Pause(bool value)
    {
        Time.timeScale = value ? 0.0f : 1.0f;
    }
}
