using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    public interface IWeapon
    {
        void Setup();
        void Upgrade();
        void Fire();
    }
}
