using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode)
        .SetLoops(_loopsCount, _loopType)
        .SetEase(_ease);
    }
}
