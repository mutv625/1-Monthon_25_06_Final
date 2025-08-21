using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movementMult = 1.0f;
    /// <summary>
    /// プレイヤーの移動速度の倍率。1が通常速度、0で停止。
    /// </summary>
    public float MovementMultiplier
    {
        get { return _movementMult; }
        set
        {
            if (value >= 0) _movementMult = value;
            else _movementMult = 0;
        }
    }

    /// プレイヤーに持たせたい速度みたいなイメージ
    public float MovementX { get; set; } = 0.0f;
    public float MovementY { get; set; } = 0.0f;
        
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // ! 外部に出す関数 ちゃんと考えて設計しろ!れ!!
    public void ImpulseY(float jumpForce)
    { 
        rb.linearVelocityY = rb.linearVelocityY * 0.5f + jumpForce;
    }

    void Update()
    {
        // * X軸移動
        float ComputedX = MovementX * MovementMultiplier;
        // * Y軸移動
        float ComputedY = rb.linearVelocityY + MovementY * MovementMultiplier;

        rb.linearVelocity = new Vector2(ComputedX, ComputedY);
    }
}
