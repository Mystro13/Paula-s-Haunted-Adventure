using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnteringCouncil : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneLoader.Load(SceneLoader.Scene.CouncilRoom);
    }
}