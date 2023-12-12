using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private ClearCounter secondClearCounter;
    [SerializeField] private bool testing;

    private KitchenObject kitchenObject;

    private void Update()
    {
        if (testing && Input.GetKeyDown(KeyCode.T))
        {
            if (kitchenObject != null)
            {
                kitchenObject.setKitchenObjectParent(secondClearCounter);
            }
        }
    }
    public void Interact(Player player)//Player player)
    {
        if (kitchenObject == null)
        {
            Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);// instantiate kitchen object
            KitchenObjectTransform.GetComponent<KitchenObject>().setKitchenObjectParent(this);// sets the object to the parent counter
        }
        else
        {
            // give the object to the player
            //Debug.Log(kitchenObject.GetClearCounter());
        }

    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void setKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
