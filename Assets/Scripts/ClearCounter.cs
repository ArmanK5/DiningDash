using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;



    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //No kitchen object
            if (player.HasKitchenObject())
            {
                //player is carrying something
                player.GetKitchenObject().setKitchenObjectParent(this);
            }
            else
            {
                //player not carrying
            }
        }
        else
        {
            //there is kitchen object
            if (player.HasKitchenObject())
            {
                //player is carrying
            }
            else
            {
                //player is not carrying
                GetKitchenObject().setKitchenObjectParent(player);
            }
        }

    }


}
