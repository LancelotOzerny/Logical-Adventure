using UnityEngine;
using UnityEngine.UI;
using YG;

public class CDevelop : MonoBehaviour
{
    [SerializeField] private Text promptCanShow = null;
    [SerializeField] private Text reviewCanShow = null;
    [SerializeField] private Text authorised = null;
    [SerializeField] private Text deviceType = null;
    [SerializeField] private Text language = null;
    [SerializeField] private Text desktop = null;
    [SerializeField] private Text mobile = null;
    [SerializeField] private Text tablet = null;
    [SerializeField] private Text tv = null;
    [SerializeField] private Text lastLevel = null;

    private void OnEnable()
    {
        Display();
    }
    public void Reset()
    {
        YandexGame.savesData.lastScene = 1;
        YandexGame.savesData.musicOn = true;

        YandexGame.SaveProgress();
    }

    public void Display()
    {
        if (mobile != null)
        {
            mobile.text = YandexGame.EnvironmentData.isMobile ? "Yes" : "No";
        }
        if (desktop != null)
        {
            desktop.text = YandexGame.EnvironmentData.isDesktop ? "Yes" : "No";
        }
        if (tablet != null)
        {
            tablet.text = YandexGame.EnvironmentData.isTablet ? "Yes" : "No";
        }
        if (tv != null)
        {
            tv.text = YandexGame.EnvironmentData.isTV ? "Yes" : "No";
        }
        if (authorised != null)
        {
            authorised.text = YandexGame.auth ? "Yes" : "No";
        }

        if (language != null)
        {
            language.text = YandexGame.EnvironmentData.language;
        }
        if (deviceType != null)
        {
            deviceType.text = YandexGame.EnvironmentData.deviceType;
        }
        if (promptCanShow != null)
        {
            promptCanShow.text = YandexGame.EnvironmentData.promptCanShow ? "Yes" : "No";
        }
        if (reviewCanShow != null)
        {
            reviewCanShow.text = YandexGame.EnvironmentData.reviewCanShow ? "Yes" : "No";
        }
        if (lastLevel != null)
        {
            lastLevel.text = YandexGame.savesData.lastScene.ToString();
        }
    }
}
