using UnityEngine;

public class CMobileElement : MonoBehaviour
{
    public static bool develop = true;

    private void Awake()
    {
        if (Application.isMobilePlatform == false && develop == false)
        {
            this.gameObject.SetActive(false);
        }
    }
}
