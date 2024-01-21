using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONManager : MonoBehaviour
{
    string jsonData;

    private void Start()
    {
        GetJSON();
        ApplyScale();
    }

    public void GetJSON()
    {
        // JSON'ın yolunu alma
        string jsonPath = "/dosyayolu/jsonDosyasi.json";

        // JSON'ı okuma
        jsonData = File.ReadAllText(jsonPath);

    }


    public void ApplyScale()
    {

        // Cismin scale değerlerine JSON verilerini enjekte etme
        var cisim = GameObject.Find("Cisim").GetComponent<MeshRenderer>();
        cisim.transform.localScale = JsonUtility.FromJson<Vector3>(jsonData);
    }


}