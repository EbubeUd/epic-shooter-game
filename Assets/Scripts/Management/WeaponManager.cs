using Assets.Scripts.Interfaces;
using UnityEngine;


namespace Assets.Scripts.Management
{
    public class WeaponManager : MonoBehaviour
    {
        public static WeaponManager _weaponManager = new WeaponManager();
        public FireBallWeapon Fireball;
        public HandSanitizerWeapon HandSanitizerWeapon;
        void Start()
        {

        }
        void Update()
        {

        }
        void Awake()
        {
            _weaponManager = this;
        }
        #region Methods
        public IWeapon GetWeapon(WeaponType weaponType)
        {
            IWeapon _weapon;
            switch (weaponType)
            {
                case WeaponType.FireBall:
                    _weapon = Fireball;
                    return _weapon;
                case WeaponType.HandSanitizer:
                    _weapon = HandSanitizerWeapon;
                    return _weapon;
            }
            _weapon = null;
            return _weapon;
        }
        #endregion
    }
}
