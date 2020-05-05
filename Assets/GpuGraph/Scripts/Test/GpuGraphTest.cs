﻿// © 2016 BRANISLV GRUJIC ALL RIGHTS RESERVED
// Provided AS IS
// For any official support, please use the contact on the unity asset store

using System.Collections;

public class GpuGraphTest : MonoBehaviour
        GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("Normal").Length, Color.blue, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));
        //if (GameObject.FindGameObjectsWithTag("cured").Length > 0) { GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("cured").Length, Color.green, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale)); }
        //if (GameObject.FindGameObjectsWithTag("Normal").Length > 3f) { GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("Normal").Length, Color.blue, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale)); }
        GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("cured").Length, Color.green, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));
        GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("infected").Length, Color.red, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));
        if (GraphManager.Graph != null && currentDeltaTime < 100.0f)
            //GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("Normal").Length, Color.blue, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));
            //GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("cured").Length, Color.green, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));
            //GraphManager.Graph.Plot("Test_WorldSpace", GameObject.FindGameObjectsWithTag("infected").Length, Color.red, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));