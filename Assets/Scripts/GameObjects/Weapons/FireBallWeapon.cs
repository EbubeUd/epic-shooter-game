using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallWeapon : MonoBehaviour, IWeapon
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    #region Methods
    public void Setup()
    {
        Debug.Log("Fire ball has been setup");
    }
    public void Upgrade()
    {
        Debug.Log("Fire ball has been upgraded");
    }
    public void Fire()
    {
        Debug.Log("Fire ball has been fired");
    }
    #endregion

}
