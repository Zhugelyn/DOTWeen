using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    void Start()
    {
        _text.DOText("��-�� ��� ��������, ��������� 5000 ����� � �� ������...", _duration, true, ScrambleMode.All);
        _text.DOColor(Color.red, _duration);
    }
}
