using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoin : ItemCollectableBase
{
    public Collider coinCollider;

    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoin();
        coinCollider.enabled = false;
    }
}
