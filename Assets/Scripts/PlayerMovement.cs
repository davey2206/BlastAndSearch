using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController Player;
    [SerializeField] GameObject LHand;
    [SerializeField] GameObject RHand;
    [SerializeField] float Speed = 2;

    [SerializeField] TextMeshProUGUI text;

    bool move = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = RHand.transform.position - LHand.transform.position;
        dir.Normalize();
        dir = new Vector3(dir.x, 0, dir.z);

        text.text = dir.ToString();
        
        if (move)
        {
            //Vector3 dir = Hand.transform.position - Body.transform.position;
            //dir.Normalize();
            //dir = new Vector3(dir.x, Player.transform.position.y, dir.z);

            Player.Move(dir * Time.deltaTime * Speed);
        }
    }

    public void EnableMove()
    {
        move = true;
    }

    public void DisableMove()
    {
        move = false;
    }
}
