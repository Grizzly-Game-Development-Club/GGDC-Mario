using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializableDictionaryExample : MonoBehaviour {
	// The dictionaries can be accessed throught a property
	[SerializeField]
	StringStringDictionary m_stringStringDictionary;
	public IDictionary<string, string> StringStringDictionary
	{
		get { return m_stringStringDictionary; }
		set { m_stringStringDictionary.CopyFrom (value); }
	}

	public ObjectColorDictionary m_objectColorDictionary;

    [SerializeField]
    StringObjectDictionary m_stringObjectDictionary;
    public IDictionary<string, UnityEngine.Object> StringObjectDictionary
    {
        get { return m_stringObjectDictionary; }
        set { m_stringObjectDictionary.CopyFrom(value); }
    }

    void Reset ()
	{
		// access by property
		StringStringDictionary = new Dictionary<string, string>() { {"first key", "value A"}, {"second key", "value B"}, {"third key", "value C"} };
		m_objectColorDictionary = new ObjectColorDictionary() { {gameObject, Color.blue}, {this, Color.red} };
        StringObjectDictionary = new Dictionary<string, UnityEngine.Object>() { { "Up", gameObject }, { "Down", gameObject }, { "Left", gameObject }, { "Right", gameObject } };
    }
}
