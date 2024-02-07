using UnityEngine;
using YG;

public class CMobileElement : MonoBehaviour
{
    public static bool develop = false;

    string Device
    {
        get => YandexGame.EnvironmentData.deviceType.ToLower();
    }

    private void Awake()
    {

        if ((Device != "mobile" && Device != "tablet") && develop == false)
        {
            this.gameObject.SetActive(false);
        }
    }
}
