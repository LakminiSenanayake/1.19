using System;
using UnityEngine;
using System.Collections;
using SimpleJSON;

namespace AssemblyCSharpfirstpass
{
	public class DecodeJson
	{
		public DecodeJson ()
		{
		}

		string jsonData; 

		// Use this for initialization
		IEnumerator Start () {
			// implememt WWW to get json data from any url
			string url = "https://api.myjson.com/bins/1fhwyh";
			WWW www = new WWW (url);
			yield return www;

			// store text in www to json string
			if (string.IsNullOrEmpty(www.error)) {
				jsonData = www.text;
			}

			// use simpleJSON to get values stored in JSON data for different key value pair
			JSONNode jsonNode = SimpleJSON.JSON.Parse(jsonData);

			Debug.Log (jsonNode[0].ToString());

			JSONNode jsonNode2 = SimpleJSON.JSON.Parse(jsonNode[0].ToString());
			Debug.Log (jsonNode2[0].ToString());
		}
	}
}

