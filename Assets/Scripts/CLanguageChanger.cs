using UnityEngine;
using YG;

public class CLanguageChanger : MonoBehaviour
{
    [SerializeField] private string[] language;

    private int LangIndex
    {
        get => YandexGame.savesData.langIndex;
        set
        {
            YandexGame.savesData.langIndex = value;
            YandexGame.SaveProgress();
        }
    }

    private void Start()
    {
        YandexGame.SwitchLanguage(language[YandexGame.savesData.langIndex]);
    }

    public void ChangeLanguage()
    {
        if (++LangIndex >= language.Length)
        {
            LangIndex = 0;
        }

        YandexGame.SwitchLanguage(language[LangIndex]);
        Debug.Log(language[LangIndex]);
    }
}
