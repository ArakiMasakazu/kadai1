using UnityEngine;

public class MoveSpeedItem : ItemBase2D
{
    /// <summary>スピードを増幅させる値</summary>
    [SerializeField] int moveSpeed = 10;

    public override void Activate()
    {
        FindObjectOfType<PlayerController2D>()._moveSpeed += moveSpeed;
    }
}

