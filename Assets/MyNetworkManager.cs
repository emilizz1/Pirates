﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost()
    {
        Debug.Log("Starting Host");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("Host started");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log("Client start requested");
        InvokeRepeating("PrintDots", 1f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        CancelInvoke();
        Debug.Log("Client connected to " + conn.address);
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
