using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializableDictionaryWaypoint : MonoBehaviour
{
    public StringObjectDictionary m_stringObjectDictionary;
    public IDictionary<string, UnityEngine.Object> StringObjectDictionary
    {
        get { return m_stringObjectDictionary; }
        set { m_stringObjectDictionary.CopyFrom(value); }
    }

    void Reset()
    {
        StringObjectDictionary = new Dictionary<string,UnityEngine.Object>() { { "Up", gameObject }, { "Down", gameObject }, { "Left", gameObject }, { "Right", gameObject } };
    }
}
