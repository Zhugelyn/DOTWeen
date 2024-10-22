using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_loopsCount, _loopType).SetEase(_ease);
    }
}
