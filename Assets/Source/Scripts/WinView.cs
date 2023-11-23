using TMPro;
using UnityEngine;

public class WinView : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private TMP_Text _resultText;
    [SerializeField] private EndPanelAnimation _animation;

    public void Enable()
    {
        gameObject.SetActive(true);
        _resultText.text = "Collected:\n" + _wallet.Money;
        _animation.Play();
    }
}
