using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _distanceZ;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(new Vector3(transform.position.x, transform.position.y, _distanceZ), _duration);
    }
}
