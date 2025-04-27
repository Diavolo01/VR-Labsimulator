using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
  public GameObject Door_UV;

  private void ExecuteTrigger(string trigger)
    {
        if (Door_UV != null)
        {
            var animator = Door_UV.GetComponent<Animator>();
            if (animator != null )
            {
                animator.SetTrigger(trigger);
            }
        }
    }
    public void OnOpenButtonClick()
    {
        ExecuteTrigger("TrOpen");
    }
    public void OnCloseButtonClick()
    {
        ExecuteTrigger("TrClose");
    }
}
