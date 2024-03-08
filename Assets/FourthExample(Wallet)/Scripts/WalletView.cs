using TMPro;
using UnityEngine;
using Zenject;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TMP_Text _value;

    private Wallet _wallet;

    [Inject]
    private void Construct(Wallet wallet) => _wallet = wallet;

    private void OnEnable()
    {
        _wallet.Changed += UpdateValue;

        UpdateValue(_wallet.Coins);
    }

    private void OnDisable()
    {
        _wallet.Changed -= UpdateValue;
    }

    private void UpdateValue(int value) => _value.text = value.ToString();
}
