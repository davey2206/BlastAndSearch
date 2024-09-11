using UnityEngine;

public class SpellToggler : MonoBehaviour
{
    [SerializeField] private GameObject _spell;

    private bool _isActive = false;

    public bool IsActive => _isActive;

    public void EnableSpell()
    {
        if (!_spell.activeSelf)
        {
            _isActive = true;
            _spell.SetActive(true);
        }
    }

    public void DisableSpell()
    {
        if (_spell.activeSelf)
            _spell.SetActive(false);
    }

    public void SetIsActive(bool active)
    {
        _isActive = active;
    }
}
