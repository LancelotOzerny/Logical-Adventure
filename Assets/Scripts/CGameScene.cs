using Lancy.Tools;
using System;
using YG;

public class CGameScene : CSceneManager
{
    private static string board = "scores";

    private void Start()
    {
        if (Last < Current)
        {
            Last = Current;
            YandexGame.NewLeaderboardScores(board, Last);
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
