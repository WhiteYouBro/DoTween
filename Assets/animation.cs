using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 1)][SerializeField] private int choice;
    void Start()
    {
        if (choice == 0)
        {
            DOTween.Sequence()
                .Append(transform.DOMove(new Vector2(10, 0), duration: 2))
                .AppendInterval(0.5f)
                .Append(transform.DOScale(new Vector2(1, 5), duration: 2))
                .AppendInterval(0.5f)
                .Append(transform.DOScale(new Vector2(1, 1), duration: 2))
                .AppendCallback(EndAnimation0);
        }
        else
        {
            DOTween.Sequence()
                .Append(transform.DOMove(new Vector2(-10, 0), duration: 2))
                .AppendInterval(0.5f)
                .Append(transform.DOScale(new Vector2(1, 5), duration: 2))
                .AppendInterval(0.5f)
                .Append(transform.DOScale(new Vector2(1, 1), duration: 2))
                .AppendCallback(EndAnimation1);
        }
    }
    private void EndAnimation0()
    {
        transform.DOMove(new Vector2(-15, 0), duration: 1.5f);
    }
    private void EndAnimation1()
    {
        transform.DOMove(new Vector2(15, 0), duration: 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
