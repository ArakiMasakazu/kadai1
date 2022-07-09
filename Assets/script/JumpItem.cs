using UnityEngine;

public class JumpItem : ItemBase2D
{
    /// <summary>ジャンプパワーを増幅させる値</summary>
    [SerializeField] int Jump = 10;

    public override void Activate()
    {
        FindObjectOfType<PlayerController2D>()._jumpSpeed += Jump;
    }
}