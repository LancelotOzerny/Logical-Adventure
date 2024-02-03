using Lancy.Tools;
using YG;

public class CGameScene : CSceneManager
{
    public int lastScene = 0;

    private void Awake()
    {
        LoadLast();

        if (lastScene < Current)
        {
            lastScene = Current;
            SaveLast();
        }
    }

    public void SaveLast()
    {
        YandexGame.savesData.lastScene = lastScene;
        YandexGame.SaveProgress();
    }

    public void LoadLast()
    {
        lastScene = YandexGame.savesData.lastScene;
    }
}
