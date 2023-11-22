using TMPro;
using UnityEngine;

public class FinishView : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private Canvas _finishCanvas;
    [SerializeField] private TMP_Text _resultText;

    public void Enable()
    {
        _finishCanvas.gameObject.SetActive(true);
        _resultText.text = "Collected:\n" + _wallet.Money;
    }
}
