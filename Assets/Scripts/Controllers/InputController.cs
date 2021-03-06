using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    public class InputController : MonoBehaviour
    {
        public Button DirectionButton;
        private Vector3 initialDirectionButtonPosition;
        bool canMovePlayer;

        private void Start()
        {
            initialDirectionButtonPosition = DirectionButton.transform.position;
            DirectionButton.onClick.AddListener(delegate { canMovePlayer = true; });
            Debug.Log("Loaded");
        }


        private void Update()
        {
     

        }

        private void OnMouseUp()
        {
            Debug.Log("Moue Upd");
            canMovePlayer = false;
        }

        private void OnMouseDrag()
        {
            
            float distanceOfDirectionButtonFromOrigin = Vector2.Distance(DirectionButton.transform.position, initialDirectionButtonPosition);
            Debug.Log(distanceOfDirectionButtonFromOrigin);
            if ((distanceOfDirectionButtonFromOrigin < 1000) && canMovePlayer)
            {
                DirectionButton.transform.position = Input.mousePosition;
            }
            else
            {
                // DirectionButton.transform.position = initialDirectionButtonPosition;
            }
        }

    }
}
