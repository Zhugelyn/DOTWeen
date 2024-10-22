using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System.Linq;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private List<Color> _color;
    [SerializeField] private float _duration;

    private int _indexCurrentColor = 0;

    private void Start()
    {
        _spriteRenderer.DOColor(_color.First(), _duration);
    }

    private void Update()
    {
        if (_spriteRenderer.color.Equals(_color[_indexCurrentColor]))
        {
            if (_indexCurrentColor++ == _color.Count - 1)
                _indexCurrentColor = 0;

            _spriteRenderer.DOColor(_color[_indexCurrentColor], _duration);
        }
    }
}
