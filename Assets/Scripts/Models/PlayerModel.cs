using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public int Health;
    private PlayerModel player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerModel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealth(int value)
    {
        Health = value;
    }
}
