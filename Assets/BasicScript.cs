using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BasicScript : MonoBehaviour
{
    [SerializeField]
    float targetYPosition;

    [SerializeField]
    float targetScale;

    [SerializeField]
    float animationTime;

    void OnEnable()
    {
        transform.DOLocalMoveY(targetYPosition, animationTime);
        transform.DOScale(targetScale, animationTime);
    }
}
