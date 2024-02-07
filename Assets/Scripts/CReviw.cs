using UnityEngine;
using YG;

public class CReviw : MonoBehaviour
{
    public void ShowReview()
    {
        if (YandexGame.EnvironmentData.reviewCanShow)
        {
            YandexGame.ReviewShow(true);
        }
    }
}
