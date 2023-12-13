using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public event EventHandler OnPlayerGrabbedObject;
    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            // player is not carrying
            Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);// instantiate kitchen object
            KitchenObjectTransform.GetComponent<KitchenObject>().setKitchenObjectParent(player);// sets the object to the parent counter
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            //player is carrying
        }

    }

}
