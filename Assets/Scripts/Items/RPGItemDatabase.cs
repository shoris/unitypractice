﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;


public class RPGItemDatabase : MonoBehaviour {

//	public TextAsset itemInventory;  //bc XML file is just a text file
//	public static List<BaseItem> inventoryItems = new List<BaseItem>();
//
//	private List<Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>> ();
//	private Dictionary<string, string> inventoryDictionary;
//
//	void Awake(){
//		ReadItemsFromDatabase ();
//		for (int i = 0; i < inventoryItemsDictionary.Count; i++) {
//			inventoryItems.Add (new BaseItem (inventoryItemsDictionary [i]));
//		}
//	}
//
//	public void ReadItemsFromDatabase(){
//		XmlDocument xmlDocument = new XmlDocument ();
//		xmlDocument.LoadXml (itemInventory.text);
//		XmlNodeList itemList = xmlDocument.GetElementsByTagName ("Item");
//
//		//will create dict for each tag in the xml doc.
//		foreach (XmlNode itemInfo in itemList) {
//			XmlNodeList itemContent = itemInfo.ChildNodes;
//			inventoryDictionary = new Dictionary<string, string> ();  //ItemName: TestItem
//
//			foreach (XmlNode content in itemContent) {
//				switch (content.Name) {
//				case "ItemName":
//					inventoryDictionary.Add ("ItemName", content.InnerText);
//					break;
//				case "ItemID":
//					inventoryDictionary.Add ("ItemID", content.InnerText);
//					break;
//				case "ItemType":
//					inventoryDictionary.Add ("ItemType", content.InnerText);
//					break;
//
//				}
//			}
//
//			inventoryItemsDictionary.Add(inventoryDictionary);
//		}
//	}

}
