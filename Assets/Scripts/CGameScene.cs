using Lancy.Tools;
using YG;

public class CGameScene : CSceneManager
{
    private void Start()
    {
        if (Last < Current)
        {
            Last = Current;
        }
    }

    public int Last
    {
        get
        {
            return YandexGame.savesData.lastScene;
        }
        set
        {
            YandexGame.savesData.lastScene = value;
            YandexGame.SaveProgress();
        }
    }

    public void OpenLast()
    {
        if (Current != Last)
        {
            OpenSceneByIndex(Last);
        }
    }
}
