using System.Collections.Generic;
using UnityEngine;

public class CSlider : MonoBehaviour
{
    [SerializeField] private List<GameObject> slides;

    [SerializeField] private GameObject ButtonLeft;
    [SerializeField] private GameObject ButtonRight;

    [SerializeField] private float speed = 5f;

    private int currentSlide = 0;
    private float startWidth = 0;

    private RectTransform rect;

    private enum State { Left, None, Right };
    private State state = State.None;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
        startWidth = rect.rect.size.x;
        
        rect.sizeDelta = new Vector2(
            startWidth * slides.Count, 
            rect.sizeDelta.y
        );
    }

    private void OnEnable()
    {
        CheckButtons();
    }

    public void MoveLeft()
    {
        if (currentSlide > 0)
        {
            currentSlide--;
            state = State.Left;
        }

        CheckButtons();
    }

    public void MoveRight()
    {
        if (currentSlide < slides.Count - 1)
        {
            currentSlide++;
            state = State.Right;
        }

        CheckButtons();
    }

    private void FixedUpdate()
    {
        if (state == State.Right)
        {
            if (rect.localPosition.x + startWidth * currentSlide > 0)
            {
                rect.localPosition = new Vector2(rect.localPosition.x - speed, rect.localPosition.y);
            }
            else
            {
                rect.localPosition = new Vector2(-startWidth * currentSlide, rect.localPosition.y);
                state = State.None;
            }
        }

        if (state == State.Left)
        {
            if (rect.localPosition.x < -startWidth * currentSlide)
            {
                rect.localPosition = new Vector2(rect.localPosition.x + speed, rect.localPosition.y);
            }
            else
            {
                rect.localPosition = new Vector2(-startWidth * currentSlide, rect.localPosition.y);
                state = State.None;
            }
        }
    }

    private void CheckButtons()
    {
        ButtonLeft.SetActive(currentSlide > 0);
        ButtonRight.SetActive(currentSlide < slides.Count - 1);
    }
}
