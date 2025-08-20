using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public PlayerCore SetupPlayerCore(int playerID)
    {
        return new PlayerCore(playerID);
    }

    public InputProvider SetupInputProvider(IControllable controllable, SOKeyConfig keyConfig)
    {
        return new InputProvider(controllable, keyConfig);
    }
}
