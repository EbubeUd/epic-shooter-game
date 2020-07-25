using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSanitizerWeapon : MonoBehaviour , IWeapon
{
    HandSanitizerWeapon _handSanitizerWeapon = new HandSanitizerWeapon();
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #region Methods
    public void Setup()
    {
        Debug.Log("Hand sanitizer has been setup");
    }
    public void Upgrade()
    {
        Debug.Log("Hand sanitizer has been upgraded");
    }
    public void Fire()
    {
        Debug.Log("Hand sanitizer has been fired");
    }
    #endregion
}
