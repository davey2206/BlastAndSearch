using UnityEngine;

public class SpellToggler : MonoBehaviour
{
    [SerializeField] private GameObject _spell;

    public void EnableSpell()
    {
        if (!_spell.activeSelf)
            _spell.SetActive(true);
    }
    
    public void DisableSpell()
    {
        if (_spell.activeSelf)
            _spell.SetActive(false);
    }
}
