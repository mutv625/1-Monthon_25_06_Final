using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Initializer : MonoBehaviour
{
    // ! プレイヤーの初期化 一連の流れ
    public PlayerCore SetupPlayerCore(int playerID)
    {
        return new PlayerCore(playerID);
    }

    public InputProvider SetupInputProvider(IControllable controllable, SOKeyConfig keyConfig)
    {
        return new InputProvider(controllable, keyConfig);
    }

    public void SetupPlayerMover(IControllable controllable, GameObject playerObject)
    {
        PlayerMover playerMover = playerObject.GetComponent<PlayerMover>();
        if (playerMover == null)
        {
            playerMover = playerObject.AddComponent<PlayerMover>();
        }

        // ここで必要な初期化を行う
        playerMover.MovementMultiplier = 1.0f;

        // プレイヤーの脳と体を結びつけ,動く命令(イベント)を体が受け取れるようにする
        controllable.EventWhenMoving
            .Subscribe(x => playerMover.MovementX = x)
            .AddTo(playerObject);
        
        controllable.EventOnJump
            .Subscribe(y =>
            {
                playerMover.ImpulseY(y);
            })
            .AddTo(playerObject);
    }
}
