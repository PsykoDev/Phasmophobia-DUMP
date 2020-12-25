﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class SaltSpot : MonoBehaviour // TypeDefIndex: 7090
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject normalSalt; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject flatSalt; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Evidence evidence; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PhotonView view; // 0x30
	private bool u091Bu0922u0926u0928u0927u0927u0924u091Eu0923u091Bu091B; // 0x38

	// Constructors
	public SaltSpot() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	private void u0921u0928u0924u091Fu0929u091Du0928u0921u091Fu0927u0926() {} // 0x0000000181658B00-0x0000000181658C00
	private void u0922u0920u0921u091Cu0920u0926u0928u0921u091Eu091Cu0922(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816593A0-0x00000001816594C0
	private void u0924u091Du091Eu091Fu091Eu091Bu0922u091Du0921u091Eu091F(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659A40-0x0000000181659B60
	private void u091Bu0922u0929u0923u0923u091Cu0923u0925u0923u091Bu0929() {} // 0x0000000181656E40-0x0000000181656F40
	private void u0927u091Cu0920u091Du0925u0924u091Du091Eu0920u0929u0922(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165A940-0x000000018165AA60
	private void u091Du091Eu0922u091Bu0921u0925u091Eu091Eu0922u0928u091A() {} // 0x00000001816574C0-0x00000001816575C0
	private void u0929u091Fu091Cu0928u091Eu0927u0920u0927u0929u0926u091F() {} // 0x000000018165B640-0x000000018165B740
	private void u0928u091Eu091Cu091Eu0927u091Bu091Fu0927u091Au0922u091C(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165AD80-0x000000018165AEA0
	private void u0928u0927u0921u0920u091Bu0924u091Fu0921u091Cu091Eu091B(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B0C0-0x000000018165B1E0
	private void u0920u0920u091Cu0921u091Au091Fu091Cu091Bu091Bu0922u0929(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657E60-0x0000000181657F80
	private void u0922u091Bu0926u091Eu091Au091Cu0926u091Bu0926u091Fu091A() {} // 0x0000000181658F40-0x0000000181659040
	private void u0927u0920u091Du0921u091Du0921u0924u0923u0922u0924u0923(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165AB60-0x000000018165AC80
	private void u0921u0929u091Eu0920u0921u091Au091Au0920u0927u0928u0922(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181658C00-0x0000000181658D20
	private void u0926u0923u0924u091Eu0927u0924u091Au0924u0927u0927u0924() {} // 0x000000018165A3E0-0x000000018165A4E0
	private void u0921u0923u091Du0922u091Du0922u0921u0922u091Du0928u0923(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816587A0-0x00000001816588C0
	private void u091Bu091Bu0922u0923u0923u091Au0925u091Du091Au0923u091A() {} // 0x0000000181656C40-0x0000000181656D40
	private void u0926u0925u0927u0929u0925u091Cu0926u0929u091Cu0926u0925(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165A4E0-0x000000018165A600
	private void u091Cu0928u0922u0922u0923u0920u0923u0929u0924u0923u091B(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816573A0-0x00000001816574C0
	private void u091Bu0926u0921u0926u0921u0928u0929u0929u091Eu0924u091C(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181656F40-0x0000000181657060
	private void u0925u091Cu0929u0923u0921u0924u0923u091Eu091Bu0920u091B(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659FA0-0x000000018165A0C0
	private void u091Eu0929u091Bu0925u091Au0929u0924u0929u0922u0925u0925() {} // 0x0000000181657B20-0x0000000181657C20
	private void OnTriggerEnter(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181656900-0x0000000181656A20
	private void u091Du0924u0929u0928u0929u0922u0924u0925u0922u091Du0923(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816575C0-0x00000001816576E0
	private void u0925u0924u0926u0929u0929u091Au091Cu0921u0925u0920u091F() {} // 0x000000018165A1E0-0x000000018165A2E0
	private void u0924u091Du0928u091Du091Eu091Fu0921u0921u091Du0927u0921() {} // 0x0000000181659B60-0x0000000181659C60
	private void u0928u091Fu091Au0922u0925u091Du0927u0927u0924u0925u091B() {} // 0x000000018165AEA0-0x000000018165AFA0
	private void u091Eu0922u091Du091Fu0928u0926u0928u0926u0925u0920u091C() {} // 0x0000000181657800-0x0000000181657900
	private void u0928u0929u091Au0925u091Du0923u0921u0921u0927u0920u0925(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B1E0-0x000000018165B300
	private void u0927u091Bu0922u0924u0929u0927u0921u0922u0923u0924u091F(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165A820-0x000000018165A940
	private void u0925u0920u0924u091Eu091Eu0927u091Au091Eu0928u0926u0923(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165A0C0-0x000000018165A1E0
	private void u0922u091Cu0926u091Au0926u091Eu0929u091Au091Cu0921u0927(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659160-0x0000000181659280
	private void u091Au091Du091Fu0929u091Eu0924u091Fu0921u0923u0928u0920(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181656B20-0x0000000181656C40
	private void u091Eu0927u0925u0928u0928u0929u0926u0926u0924u091Bu0920() {} // 0x0000000181657A20-0x0000000181657B20
	private void u0924u0923u0920u091Fu0922u0922u0923u091Au0923u0929u091B() {} // 0x0000000181659C60-0x0000000181659D60
	private void u0927u0926u0925u0925u091Du0929u0927u0926u091Bu0928u0921() {} // 0x000000018165AC80-0x000000018165AD80
	private void u0924u0925u091Eu0923u0929u091Bu0924u0929u0929u0926u091F(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659D60-0x0000000181659E80
	private void u0924u091Cu0922u0926u091Au091Eu091Bu0928u0925u091Au0924(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659920-0x0000000181659A40
	private void u0922u0925u0922u0928u0926u0924u0921u0920u0929u091Du091D(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816594C0-0x00000001816595E0
	private void u0929u0928u0925u0924u0929u0923u091Eu0927u0922u091Au0929(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165BA80-0x000000018165BBA0
	private void u0927u091Du0920u091Fu0925u091Du091Bu091Fu0920u0922u0927() {} // 0x000000018165AA60-0x000000018165AB60
	private void u0921u0921u091Fu0924u0927u091Au091Du091Cu091Eu0920u0921() {} // 0x00000001816585A0-0x00000001816586A0
	private void u0929u0926u0924u0920u0925u0928u091Bu091Fu091Fu0923u0928() {} // 0x000000018165B860-0x000000018165B960
	private void u0920u0920u091Eu0929u0925u0922u0929u091Cu0925u0926u0920() {} // 0x0000000181657F80-0x0000000181658080
	private void u091Cu0921u091Fu0924u091Au091Du0927u091Bu091Au091Au0927() {} // 0x0000000181657060-0x0000000181657160
	private void u0920u0922u091Du0924u0925u091Bu091Bu0925u091Eu0927u0920() {} // 0x0000000181658080-0x0000000181658180
	private void u0922u091Au091Fu0921u0921u0925u0920u0924u091Bu0928u0929() {} // 0x0000000181658D20-0x0000000181658E20
	private void u091Bu091Bu0923u0921u091Bu0920u091Du0925u0925u091Cu0920() {} // 0x0000000181656D40-0x0000000181656E40
	private void u0928u0923u0928u0923u0923u0923u091Eu091Fu0925u0929u0929(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165AFA0-0x000000018165B0C0
	private void u0929u091Eu091Eu091Eu091Eu0922u0929u091Au0922u0923u0926(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B520-0x000000018165B640
	private void u0922u091Au0922u091Au0923u091Eu0922u0921u0927u091Cu0920(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181658E20-0x0000000181658F40
	private void u0929u0926u091Du0926u0920u0924u0920u0920u0920u0920u0924(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B740-0x000000018165B860
	private void u0929u091Bu0920u0923u0923u091Du0927u091Bu0928u0924u0921(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B300-0x000000018165B420
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void SyncSalt() {} // 0x0000000181656A20-0x0000000181656B20
	private void u0923u0924u0928u0922u0927u091Au0920u091Bu091Cu0921u0922(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659700-0x0000000181659820
	private void u091Fu0921u091Du0927u091Bu0925u091Cu0924u0925u0926u0921(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657C20-0x0000000181657D40
	private void u0927u091Au0923u091Au0927u091Du0924u091Bu0925u0921u091B(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165A700-0x000000018165A820
	private void u0924u0926u0920u091Cu0927u091Bu0920u0924u0927u0925u0920(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659E80-0x0000000181659FA0
	private void u0922u091Eu091Bu0928u091Cu0929u0923u091Au091Au091Au0925(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659280-0x00000001816593A0
	private void u0929u091Du0929u0926u0921u091Eu091Fu0922u091Bu0926u091C() {} // 0x000000018165B420-0x000000018165B520
	private void u0921u0925u0926u091Du091Au0928u091Cu091Bu0928u0929u0924(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816589E0-0x0000000181658B00
	private void u0921u091Fu091Bu0923u0928u0928u0920u091Du091Au091Bu0921() {} // 0x00000001816582A0-0x00000001816583A0
	private void u091Eu0925u0920u091Bu0923u091Bu0925u0927u091Bu091Au091C(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657900-0x0000000181657A20
	private void u0922u091Cu091Bu0923u0921u0921u0925u0925u0922u0921u091C(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181659040-0x0000000181659160
	private void u0920u091Du0928u0926u091Au0924u091Au0926u0921u0929u0923(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657D40-0x0000000181657E60
	private void u0920u0924u0923u0922u091Cu0928u091Cu091Au0925u0927u0921(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181658180-0x00000001816582A0
	private void u0929u0926u0924u0924u0926u091Eu091Bu0922u0920u091Bu0926(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x000000018165B960-0x000000018165BA80
	private void u091Cu0924u0924u091Du091Cu0927u0922u0920u0927u0927u0925(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657280-0x00000001816573A0
	private void u091Cu0922u0929u091Bu0925u0926u091Bu0928u0922u0929u0924(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x0000000181657160-0x0000000181657280
	private void u0926u091Du091Cu091Du091Eu0920u091Cu0928u0924u091Eu091A() {} // 0x000000018165A2E0-0x000000018165A3E0
	private void u0926u0927u0924u091Fu0929u091Au0923u0924u0920u091Cu091D() {} // 0x000000018165A600-0x000000018165A700
	private void u0921u0920u0923u0929u091Du0921u0929u091Fu0926u0927u091A() {} // 0x00000001816584A0-0x00000001816585A0
	private void u0923u0926u0929u0928u0925u091Eu091Bu091Eu091Eu0921u091B() {} // 0x0000000181659820-0x0000000181659920
	private void u0921u0923u091Du0922u0926u0925u0921u0929u0923u0921u0927(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816588C0-0x00000001816589E0
	private void u0921u091Fu0926u091Du091Au091Du0929u091Eu091Au0929u091B() {} // 0x00000001816583A0-0x00000001816584A0
	private void u091Du0925u091Fu091Bu0925u0928u0927u091Au091Du0929u0922(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816576E0-0x0000000181657800
	private void u0921u0922u0927u0923u0929u0920u0920u0926u0920u0923u0923() {} // 0x00000001816586A0-0x00000001816587A0
	private void u0922u0928u0928u091Fu091Au0925u0920u091Cu091Au091Au0927(Collider u0923u0924u0927u091Au0921u091Au091Bu0920u091Bu0926u0923) {} // 0x00000001816595E0-0x0000000181659700
}
