using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IEnemyTarget
{
    private int _maxHealth;
    private int _health;

    public Vector3 Position => transform.position;

    [Inject]
    private void Construct(PlayerStatsConfig playerStatsConfig)
    {
        _health = _maxHealth = playerStatsConfig.MaxHealth;
        Debug.Log($"� ���� {_health}��");
    }

    public void TakeDamage(int damage)
    {
        //�������� �����
        //��������� �����
    }
}
