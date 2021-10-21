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

    [SerializeField]
    float vectorRotateX;

    [SerializeField]
    float vectorRotateY;

    [SerializeField]
    float vectorRotateZ;

    void OnEnable()
    {
        transform.DOLocalMoveY(targetYPosition, animationTime);
        transform.DOScale(targetScale, animationTime);
        transform.DORotate(new Vector3(vectorRotateX, vectorRotateY, vectorRotateZ), animationTime, RotateMode.LocalAxisAdd)
        .SetDelay(animationTime)
        .OnComplete(() => transform.DORotate(new Vector3(vectorRotateX, vectorRotateY, vectorRotateZ), animationTime, RotateMode.LocalAxisAdd)
            .SetDelay(animationTime)
            .Play())
        .Play();
    }
}
