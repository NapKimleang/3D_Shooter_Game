using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    private PlayerWeaponVisuals visualcontroller;

    private void Start()
    {
        visualcontroller = GetComponentInParent<PlayerWeaponVisuals>();
    }

    public void ReloadIsOver()
    {
        visualcontroller.MaximizeRigWeight();

        //refill-bullets
    }

    public void ReturnRig()
    {
        visualcontroller.MaximizeRigWeight();
        visualcontroller.MaximizeLeftHandWeight();
    }

    public void WeaponGrabIsOver()
    {
        visualcontroller.SetBusyGrabbingWeaponTo(false);
    }
}
