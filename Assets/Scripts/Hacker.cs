using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Hacker : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    void Start()
    {
        _text.DOText("Хе-хе вас взломали, заплатите 5000 шишек и вы будете...", _duration, true, ScrambleMode.All);
        _text.DOColor(Color.red, _duration);
    }
}
