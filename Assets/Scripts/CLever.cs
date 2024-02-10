using UnityEngine;
using UnityEngine.Events;

public class CLever :   MonoBehaviour
{
    [SerializeField] private bool singleClick;
    public UnityEvent onEvent;
    public UnityEvent offEvent;
    private Animator animator = null;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void On()
    {
        onEvent.Invoke();
    }

    public void Off()
    {
        offEvent.Invoke();
    }

    public bool Active
    {
        get => animator.GetBool("IsOn");
        protected set => animator.SetBool("IsOn", value);
    }

    private void OnMouseDown()
    {
        if (singleClick)
        {
            Active = true;
            return;   
        }
        Active = !Active;
    }
}