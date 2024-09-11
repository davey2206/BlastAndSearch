using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    [SerializeField] private GameObject _spell;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private SpellToggler _spellToggler;

    public void InstantiateProjectile()
    {
        if (_spellToggler.IsActive)
        {
            Instantiate(_projectile, _spell.transform.position, _spell.transform.rotation);
            _spellToggler.SetIsActive(false);
        }
    }
}
