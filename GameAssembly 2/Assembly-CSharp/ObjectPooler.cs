﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class ObjectPooler : MonoBehaviour, IMatchmakingCallbacks // TypeDefIndex: 6978
{
	// Fields
	public static ObjectPooler u0925u091Fu0920u091Cu0925u091Fu0927u091Cu091Au0925u0927; // 0x00
	public List<Pool> u091Eu0929u091Du0926u0927u0925u0929u0925u0925u0928u0922; // 0x18
	public Dictionary<string, Queue<GameObject>> u0920u0920u0923u0926u0922u0927u091Eu0926u091Cu0927u0929; // 0x20

	// Nested types
	[Serializable]
	public class Pool // TypeDefIndex: 6979
	{
		// Fields
		public string tag; // 0x10
		public GameObject prefab; // 0x18
		public int size; // 0x20

		// Constructors
		public Pool() {} // 0x00000001802466A0-0x00000001802466B0
	}

	// Constructors
	public ObjectPooler() {} // 0x000000018100DD60-0x000000018100DDD0

	// Methods
	public void u0927u0927u0922u0923u0923u0927u0920u0920u0920u0920u0922(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u0928u0922u0925u0927u0929u0922u0923u0925u0922u0927() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0927u0920u0927u091Cu091Au0924u091Eu091Au0924u0921u091B() {} // 0x000000018100DD10-0x000000018100DD60
	public void u0928u0926u0929u0924u0929u091Fu0924u091Au091Fu0921u0925(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0926u0922u0920u0922u091Au0926u0928u0920u091Bu0928u0922() {} // 0x000000018100D830-0x000000018100DB50
	public void u0925u0928u091Cu091Bu0929u0922u0921u0921u0923u0922u0920() {} // 0x0000000180246DB0-0x0000000180246DC0
	public GameObject SpawnFromPool(string u0920u091Bu091Eu0923u091Bu091Du0921u0925u091Cu0928u0921, Vector3 u0928u0924u091Au0921u091Du0925u0929u0921u0924u0926u0924, Quaternion u0923u0923u0923u091Cu091Du0926u091Au0921u0923u0923u0929) => default; // 0x000000018100D520-0x000000018100D6E0
	private void u0926u091Bu091Cu0922u0928u0923u091Fu0924u091Bu091Bu0923() {} // 0x000000018100D6E0-0x000000018100D6F0
	public void u0924u0922u0923u091Au0929u0923u091Fu0928u0926u091Au0929(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Cu091Du091Bu0926u091Bu0921u091Fu091Au0928u0925u091B() {} // 0x000000018100D6E0-0x000000018100D6F0
	private void u091Du091Eu091Cu0929u091Fu0921u091Du0929u0929u091Eu0928() {} // 0x000000018100D6E0-0x000000018100D6F0
	public void u091Du0928u0920u091Fu0928u091Bu0920u091Du0926u0925u091F() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du091Eu091Au0929u0923u091Fu091Fu0925u091Eu0925u0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0927u091Bu0925u091Fu091Au091Du0923u091Au0929u0927u0921() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0927u091Eu0928u0920u0922u0921u091Du091Eu0928u091Du091D() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u091Eu0921u091Bu091Du0924u0924u091Cu0929u0920u091B(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0921u0926u0929u091Au0929u091Fu091Au091Fu0928u0929u0922(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Au091Au091Du0924u0922u091Cu0924u0925u0922u091Au0923() {} // 0x000000018100D6E0-0x000000018100D6F0
	private void u0924u0929u091Bu0923u0922u091Fu0920u091Du0927u091Au0921() {} // 0x000000018100D6E0-0x000000018100D6F0
	public void u091Fu091Bu091Eu0921u091Cu091Au0922u091Du0922u0922u0929(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0921u0925u091Au0920u0922u091Cu091Eu091Du0925u091Au0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u0926u091Bu0926u0921u0922u091Bu0924u091Cu091Fu091F(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0921u091Cu0928u0928u0929u0929u0922u0924u091Cu091Eu0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0923u0926u0924u0920u0920u091Cu0922u0921u091Du091Bu0923() {} // 0x000000018100D740-0x000000018100D790
	private void Awake() {} // 0x000000018100D4D0-0x000000018100D520
	private void Start() {} // 0x000000018100D6E0-0x000000018100D6F0
	public GameObject u0927u091Cu0928u0921u0929u0920u0929u0921u0920u0925u091A(string u0920u091Bu091Eu0923u091Bu091Du0921u0925u091Cu0928u0921, Vector3 u0928u0924u091Au0921u091Du0925u0929u0921u0924u0926u0924, Quaternion u0923u0923u0923u091Cu091Du0926u091Au0921u0923u0923u0929) => default; // 0x000000018100DB50-0x000000018100DD10
	public void u0929u0924u0925u0924u091Du091Au0926u0929u0922u0922u0928(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0927u091Au0923u0920u091Eu091Eu091Au0920u0925u0920(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Fu0928u0929u0920u0923u0927u0920u091Bu0920u091Du0924() {} // 0x000000018100D6E0-0x000000018100D6F0
	public void u0928u0925u0925u0921u0928u0920u091Cu0925u0921u091Bu0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnJoinRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnCreateRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0924u091Fu091Bu0923u091Au091Eu0923u091Bu0922u0928u0923(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0924u091Fu0927u0927u091Cu0922u0925u0926u091Au091E() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0925u0925u0921u0927u0922u091Eu0922u0923u091Eu0927u0924() {} // 0x000000018100D7E0-0x000000018100D830
	public void u0926u0928u091Bu0920u091Cu0928u0921u0921u0923u0923u0925(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Au0922u0925u091Bu0924u091Du0921u0920u0926u0928u0929() {} // 0x000000018100D6E0-0x000000018100D6F0
	private void u091Cu0924u0923u091Eu091Du091Fu0922u0920u0922u0923u091B() {} // 0x000000018100D6E0-0x000000018100D6F0
	private void u0924u091Bu091Cu091Du0928u091Cu091Au091Fu0928u0922u0929() {} // 0x000000018100D790-0x000000018100D7E0
	public void u0927u0925u0920u0925u0921u091Eu0924u091Au0921u091Fu0925(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnFriendListUpdate(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0925u091Cu091Bu091Fu091Eu0929u091Eu0924u0927u0927u091C() {} // 0x000000018100D6E0-0x000000018100D6F0
	private void u0921u0926u0927u0927u091Bu0929u0929u0928u0926u091Au0921() {} // 0x000000018100D6E0-0x000000018100D6F0
	public void OnJoinRandomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Eu0922u0926u091Eu091Au091Fu091Bu091Au0927u091Cu0924() {} // 0x000000018100D6F0-0x000000018100D740
}

