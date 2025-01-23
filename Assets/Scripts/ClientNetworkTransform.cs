using Unity.Netcode.Components;
using UnityEngine;

namespace Unity.Multiplayer.Center.NetcodeForGameObjectsExample
{
    [DisallowMultipleComponent]
    public class ClientNetworkTransform : NetworkTransform
    {
        protected override bool OnIsServerAuthoritative()
        {
            return false;
        }
    }
}