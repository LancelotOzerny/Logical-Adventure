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
        if (LangIndex == -1)
        {
            LangIndex = 0;

            for (int i = 0; i < language.Length; i++)
            {
                if (language[i].ToLower() == YandexGame.lang.ToLower())
                {
                    LangIndex = i;
                }
            }
        }

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
