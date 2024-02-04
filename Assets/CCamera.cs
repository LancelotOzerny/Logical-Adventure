using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 4f;
    [SerializeField] private bool freezeX;
    [SerializeField] private bool freezeY;

    private Vector3 Pos 
    { 
        get => transform.position; 
        set => transform.position = value; 
    }

    private Vector3 TargetPos
    {
        get => new Vector3(
            freezeX ? Pos.x : target.transform.position.x,
            freezeY ? Pos.y: target.transform.position.y,
            Pos.z
        );
        set => target.transform.position = value;
    }

    private void Awake()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }

        Pos = TargetPos;
    }

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        Pos = Vector3.Lerp(Pos, TargetPos, speed * Time.deltaTime);
    }
}
