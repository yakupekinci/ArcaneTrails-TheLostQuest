using Fusion;
using Fusion.Sockets;
using UnityEngine;
using System.Collections.Generic;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public NetworkObject PlayerPrefab; // Oyuncu prefab'ını buraya atayacağız


    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
        {
            Vector3 spawnPosition = new Vector3(0, 1, 0); // İstediğiniz spawn konumu
            Runner.Spawn(PlayerPrefab, spawnPosition, Quaternion.identity, player);
        }
    }


}
