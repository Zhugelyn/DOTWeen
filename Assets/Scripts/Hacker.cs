using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _defaultMessage;
    [SerializeField] private string _newMessage;

    private void Start()
    {
        _text.text = _defaultMessage;
        _text.DOText(_newMessage, _duration, true, ScrambleMode.All);
        _text.DOColor(Color.red, _duration);
    }

    private void Update()
    {
        if (_text.text == _newMessage)
            _text.text = string.Empty;
    }
}
