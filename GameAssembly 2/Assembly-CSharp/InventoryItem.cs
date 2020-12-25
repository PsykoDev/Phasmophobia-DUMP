﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class InventoryItem : MonoBehaviour // TypeDefIndex: 7127
{
	// Fields
	public string u0925u0925u0925u0925u091Bu0923u091Eu0922u0927u0922u0928; // 0x18
	public string u0920u091Bu0924u091Fu091Eu0921u0926u0925u0925u0926u0926; // 0x20
	public int u0921u091Eu0920u0922u0926u0928u0927u091Du0923u091Cu0929; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private int defaultAmount; // 0x2C
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public int u0929u091Fu0927u0929u0922u0928u0925u0927u0925u091Du0921; // 0x30
	public int u0922u0928u091Cu091Bu091Cu0923u091Cu0924u091Fu0926u0926; // 0x34
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text totalText; // 0x38
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x40
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u0927u091Du0921u091Fu091Du091Au091Bu091Fu091Eu0927u091F; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private InventoryManager inventoryManager; // 0x50
	public List<u091Du0920u0924u0923u091Cu0922u0922u0928u0928u0927u091D> u0920u091Au0927u0929u091Eu091Bu0928u0928u0922u091Bu091A; // 0x58

	// Nested types
	public class u091Du0920u0924u0923u091Cu0922u0922u0928u0928u0927u091D // TypeDefIndex: 7128
	{
		// Fields
		public bool u091Au0927u091Eu0925u091Eu0921u091Au091Eu0924u0921u091D; // 0x10
		public Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929; // 0x18
		public int u091Cu0923u0924u091Bu091Cu0921u0929u0920u091Cu091Au0921; // 0x20

		// Constructors
		public u091Du0920u0924u0923u091Cu0922u0922u0928u0928u0927u091D() {} // 0x00000001802466A0-0x00000001802466B0
	}

	// Constructors
	public InventoryItem() {} // 0x0000000181920300-0x0000000181920370

	// Methods
	private void u0928u0927u0925u091Eu0927u091Bu091Cu0924u0920u0920u0927() {} // 0x000000018191FB50-0x000000018191FD00
	public void u0927u0922u091Au0926u091Bu091Bu0923u091Fu0926u0926u091C() {} // 0x000000018191F0E0-0x000000018191F230
	public void u0925u0928u0924u091Bu091Bu0922u0921u0924u0922u0929u0927() {} // 0x000000018191EA60-0x000000018191EBC0
	public void u0922u0924u0923u091Fu0924u0926u091Bu0925u0926u0925u0923(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191D6F0-0x000000018191D820
	private void u0922u0925u0922u0924u0928u091Bu0929u091Du0929u0926u091D() {} // 0x000000018191D820-0x000000018191D870
	public void u0926u091Cu0923u091Du091Fu0927u0927u0928u0922u091Fu091F() {} // 0x000000018191EBC0-0x000000018191EDA0
	public void LeftRoom(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x0000000181918B20-0x0000000181918C70
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void RemovePlayer(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x0000000181918C70-0x0000000181918E50
	private void u091Fu0928u0920u091Bu0924u0928u091Cu0927u0928u091Fu091A(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191BDF0-0x000000018191BF50
	public void u0928u091Eu0923u091Eu091Du0924u091Du0920u0925u091Au0923(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191F490-0x000000018191F660
	public void u0928u0927u091Bu091Bu0927u0921u0923u091Eu091Bu091Fu091E() {} // 0x000000018191F970-0x000000018191FB50
	private void u0928u091Du0922u091Du0923u0925u0925u0924u0921u0920u0920(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191F370-0x000000018191F490
	private void u091Eu0921u091Du091Eu0921u091Eu0922u0924u0920u091Du0929() {} // 0x000000018191B3A0-0x000000018191B460
	public void u0924u0924u0927u0925u091Cu0927u091Fu091Bu0928u091Bu0927() {} // 0x000000018191E000-0x000000018191E1E0
	private void u0920u0928u0927u0928u0929u0929u0924u0929u0925u091Fu0926(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191C8B0-0x000000018191CB40
	public void u091Cu0924u0926u091Eu0929u091Fu0927u091Bu091Fu0926u091F(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191A960-0x000000018191AB30
	public void u091Bu0924u0923u091Au0921u0920u0920u091Fu0927u091Eu0927() {} // 0x0000000181919D10-0x0000000181919EE0
	private void u0922u091Fu091Cu0926u0925u0920u091Fu091Au0920u0929u091D() {} // 0x000000018191D450-0x000000018191D510
	private void Start() {} // 0x0000000181919030-0x00000001819191E0
	private void u0923u0928u0921u0928u091Fu091Fu0925u091Du091Du0928u0924() {} // 0x000000018191DC00-0x000000018191DC90
	public void u091Cu0921u091Bu0927u0924u0926u091Cu091Au0920u0929u091C() {} // 0x000000018191A800-0x000000018191A960
	private void u091Au0925u0925u091Du091Cu091Au091Cu0927u0929u0925u0929() {} // 0x00000001819193C0-0x00000001819196A0
	private void u091Bu0925u0926u0926u0926u0924u0920u0922u091Cu091Fu0923(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x0000000181919EE0-0x000000018191A010
	private void u0920u091Cu091Bu0926u0920u0923u0927u091Bu091Du0925u091E() {} // 0x000000018191BF50-0x000000018191C230
	private void u0920u091Cu0926u091Au0929u0924u0922u0920u0920u091Cu091D() {} // 0x000000018191C230-0x000000018191C2C0
	public void u0926u091Fu0925u0924u0923u091Du0927u0929u0920u091Eu0924(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191EDA0-0x000000018191EEF0
	private void u091Fu091Bu0925u0929u0927u0926u0926u091Eu091Bu0925u0927(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191B730-0x000000018191B8F0
	public void u0924u0929u0924u091Au0920u091Bu091Fu091Bu0920u0926u091A() {} // 0x000000018191E350-0x000000018191E4C0
	private void u091Eu091Bu0928u0924u0925u0920u0921u0926u0920u0925u0925() {} // 0x000000018191B1F0-0x000000018191B3A0
	private void u0923u0921u0926u091Fu0928u0928u0927u091Fu0928u0920u0928(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191D870-0x000000018191DA30
	public void u0920u0920u0926u0927u0920u0923u0925u091Fu091Au0929u0921() {} // 0x000000018191C4A0-0x000000018191C600
	public void u0924u091Cu091Fu091Eu0927u0928u0924u091Du091Fu0922u091F(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191DED0-0x000000018191E000
	private void u0925u091Fu091Fu0929u091Fu0921u0929u091Cu0926u0929u0924(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191E600-0x000000018191E760
	public void u0920u091Fu0923u0921u0922u0926u0922u0929u091Au0924u0922() {} // 0x000000018191C2C0-0x000000018191C4A0
	public void SaveItem() {} // 0x0000000181918E50-0x0000000181919030
	private void u0927u0920u0927u091Cu091Au0924u091Eu091Au0924u0921u091B() {} // 0x000000018191EEF0-0x000000018191EFB0
	private void u091Fu0923u0924u0928u0920u0927u0924u0929u0928u0920u0923() {} // 0x000000018191BBA0-0x000000018191BC30
	private void u0928u091Eu0925u0927u0921u0920u091Au0923u0929u0929u0924(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191F660-0x000000018191F7C0
	public void u091Du0928u0925u091Bu091Eu091Au0920u0922u0922u0925u0927(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191B020-0x000000018191B1F0
	public void u0927u0922u0927u0926u0924u091Au091Bu091Fu0923u0925u0920(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191F230-0x000000018191F370
	private void u0925u0926u0920u0926u091Cu0920u0926u0929u0920u0921u0920(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191E940-0x000000018191EA60
	public void u0929u0928u091Au091Au0920u0925u091Du0925u091Fu091Au0927() {} // 0x0000000181920020-0x0000000181920190
	public void u091Du091Eu091Fu091Bu0925u091Bu091Fu091Cu0926u0923u091F() {} // 0x000000018191ACF0-0x000000018191AED0
	public void u0921u0929u091Du0925u0929u091Au091Cu091Au0922u0923u091A(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191D170-0x000000018191D2A0
	public void u091Fu091Bu0924u0928u091Eu0923u0924u0921u0925u091Du0929() {} // 0x000000018191B5D0-0x000000018191B730
	private void u0922u091Du0929u091Au0924u091Cu0926u091Au0926u091Du091F() {} // 0x000000018191D2A0-0x000000018191D450
	public void u0920u0926u0927u0928u091Eu0929u091Fu0923u0922u0922u0924(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191C600-0x000000018191C740
	public void u0921u0921u091Fu091Au0929u091Cu0922u0926u0928u0926u0927(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191CE70-0x000000018191D040
	private void u091Au0923u091Fu0922u091Fu0927u091Fu091Cu091Bu091Cu0924(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x00000001819191E0-0x00000001819193C0
	private void u0921u0924u0925u0922u091Bu091Cu091Eu0920u0923u0920u0922(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191D040-0x000000018191D170
	private void u091Bu0929u0928u091Cu091Cu0923u091Eu0923u0923u0927u0920(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191A010-0x000000018191A170
	public void ChangeTotalAmount(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x0000000181918960-0x0000000181918B20
	public void u0920u0926u0928u091Bu0920u0921u0928u0922u091Du091Eu0924() {} // 0x000000018191C740-0x000000018191C8B0
	public void u0922u0920u0928u0925u0929u0926u091Bu0921u0922u0923u0924() {} // 0x000000018191D510-0x000000018191D6F0
	private void Awake() {} // 0x0000000181918740-0x0000000181918800
	public void u091Cu091Cu091Au091Eu091Au091Du0924u0922u091Eu0925u0921(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191A480-0x000000018191A640
	private void u091Cu091Au0926u0927u0923u0920u0923u0925u0920u0926u0929(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191A170-0x000000018191A2A0
	private void u0928u0922u0925u091Fu091Cu0928u091Fu0925u091Cu091Du0929() {} // 0x000000018191F7C0-0x000000018191F970
	public void UpdateTotalText() {} // 0x0000000181920190-0x0000000181920300
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void AddPlayer(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x0000000181918610-0x0000000181918740
	public void u091Du091Cu091Du0923u0922u0921u091Au091Eu091Cu0927u0926(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191ABC0-0x000000018191ACF0
	private void u091Fu091Fu0925u091Au091Au0920u091Eu091Fu0920u0926u0929(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x000000018191B8F0-0x000000018191BBA0
	private void u091Au0929u091Au0928u0921u0925u0924u091Eu0922u091Fu091E() {} // 0x0000000181919A30-0x0000000181919D10
	public void u0921u091Bu091Cu0923u0925u0921u0921u0929u0922u091Fu091A() {} // 0x000000018191CB40-0x000000018191CCB0
	private void u0929u091Bu091Fu091Du0926u0929u0926u091Cu091Au0920u0920(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191FD00-0x000000018191FEC0
	private void u0924u091Bu091Cu091Du0928u091Cu091Au091Fu0928u0922u0929() {} // 0x000000018191DE40-0x000000018191DED0
	public void u0923u0923u0928u0925u091Au0929u091Cu0927u091Bu0928u091C() {} // 0x000000018191DA30-0x000000018191DC00
	public void u091Du0922u091Au091Bu0923u0920u091Du091Au0925u091Bu0927() {} // 0x000000018191AED0-0x000000018191B020
	public void u091Fu091Au0923u0924u0927u091Du0929u0924u0921u0922u0923() {} // 0x000000018191B460-0x000000018191B5D0
	public void u091Fu0927u0924u0922u091Bu091Du091Au091Fu091Du0922u0926(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191BC30-0x000000018191BDF0
	public void u091Au0928u0929u091Du0926u091Fu0929u0922u091Bu0926u0921(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x0000000181919870-0x0000000181919A30
	private void u0925u091Fu0923u0922u091Cu0925u0923u091Fu0920u0921u0920(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191E760-0x000000018191E940
	private void u091Cu091Bu0921u091Eu0928u0928u091Au0924u0928u0929u0927(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x000000018191A2A0-0x000000018191A480
	private void u091Cu0926u091Eu091Bu091Bu0922u091Eu0926u091Au0923u0924() {} // 0x000000018191AB30-0x000000018191ABC0
	public void u0921u091Eu0920u0925u091Fu0929u0925u091Au091Cu091Fu091F(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B) {} // 0x000000018191CCB0-0x000000018191CE70
	public void u0924u0928u0928u091Eu0922u0926u0927u0923u091Cu0924u091D() {} // 0x000000018191E1E0-0x000000018191E350
	public void u0927u0921u0926u0928u0921u0927u0923u091Bu0924u0927u0925(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191EFB0-0x000000018191F0E0
	public void u0929u0926u0924u091Bu0926u091Du0927u0924u0920u0922u0923() {} // 0x000000018191FEC0-0x0000000181920020
	public void u0925u091Du091Du0924u0927u0927u0924u0927u0920u0923u0926(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x000000018191E4C0-0x000000018191E600
	public void u091Cu091Du0925u0924u0928u0920u0923u091Bu091Cu091Au0920() {} // 0x000000018191A640-0x000000018191A800
	private void u0924u091Au091Au0922u0928u0924u091Bu091Au0923u0928u091A() {} // 0x000000018191DC90-0x000000018191DE40
	public void u091Au0926u0920u0926u0920u0923u0928u0928u0923u0929u0923() {} // 0x00000001819196A0-0x0000000181919870
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void ChangeTotalAmountNetworked(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u091Bu091Du0929u091Du091Au0921u0920u091Eu0922u0924u091B, bool u0925u091Eu0924u091Du091Au0924u0923u091Eu0925u0921u0922) {} // 0x0000000181918800-0x0000000181918960
}
