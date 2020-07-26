using Assets.Scripts.Interfaces;
using Assets.Scripts.Management;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rigidBody;
    private Vector2 moveAmount;
    private Animator animator;
    private PlayerModel player;
    WeaponManager weaponManager;
    IWeapon currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player = GetComponent<PlayerModel>();
        weaponManager = WeaponManager._weaponManager;
        SwitchWeapon(WeaponType.FireBall);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * Speed;

        //Changing the MotionState on Key held down
        if (moveInput != Vector2.zero)
        {
            animator.SetInteger("MotionState", (int)PlayMotionState.Run);
        }
        else
        {
            animator.SetInteger("MotionState", (int)PlayMotionState.Idle);
        }

        //Switching Weapons
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentWeapon.Fire();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            SwitchWeapon(WeaponType.FireBall);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SwitchWeapon(WeaponType.HandSanitizer);
        }
    }
    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + moveAmount * Time.fixedDeltaTime);
    }

    #region Method
    void SwitchWeapon(WeaponType weaponType)
    {
        currentWeapon = weaponManager.GetWeapon(weaponType);
        currentWeapon.Setup();
    }
    #endregion
}
