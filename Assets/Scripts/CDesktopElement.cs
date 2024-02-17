using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CDesktopElement : MonoBehaviour
{
    public static bool develop = false;

    string Device
    {
        get => YandexGame.EnvironmentData.deviceType.ToLower();
    }

    private void Awake()
    {

        if (Device == "desktop" && develop == false)
        {
            this.gameObject.SetActive(false);
        }
    }
}
