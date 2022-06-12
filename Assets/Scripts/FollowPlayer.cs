using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerModel;

    void Update()
    {
        PlayerModel.transform.position = Player.transform.position;
    }
}
