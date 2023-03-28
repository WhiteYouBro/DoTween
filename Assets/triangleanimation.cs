using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleanimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Sequence()
                .Append(transform.DOScale(new Vector2(1, 5), duration: 1))
                .Append(transform.DOMove(new Vector2(0,0), duration: 1))
                .Append(transform.DORotate(new Vector3(0, 0, 360), duration: 2))
                .AppendInterval(0.5f)
                .Append(transform.DOScale(new Vector2(1, 1), duration: 2))
                .AppendCallback(EndAnimation);
    }
    private void EndAnimation()
    {
        transform.DOMove(new Vector2(0, -6), duration: 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
