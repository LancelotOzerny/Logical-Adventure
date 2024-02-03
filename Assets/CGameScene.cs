using Lancy.Tools;
using YG;

public class CGameScene : CSceneManager
{
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
