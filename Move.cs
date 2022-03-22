using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    private void Start()
    {
        OnMoveXAxis();
        //OnMove();
    }
    
    private void OnMoveXAxis()
    {
        transform.DOMoveX(5.0f, 2.0f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
    
    private void OnMove()
    {
        Vector3 position = new Vector3(5.0f, 4.0f, 3.0f);
        transform.DOMove(position, 2.0f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
}
