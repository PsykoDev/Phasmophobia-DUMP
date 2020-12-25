﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class Drawer : MonoBehaviour // TypeDefIndex: 7032
{
	// Fields
	private Vector3 u0920u091Du0922u0920u091Bu0924u091Au091Du091Au091Au091B; // 0x18
	public bool u0926u0920u0921u0920u091Fu0928u0922u091Du0928u0926u091B; // 0x24
	public bool u0922u0920u091Bu0926u0924u0922u0921u091Du0924u091Fu0929; // 0x25
	public bool u091Au0928u0928u091Du091Eu0928u091Eu0925u0920u0921u0920; // 0x26
	private Vector3 u091Cu091Bu091Bu091Du0929u0924u0925u0928u0927u0926u0921; // 0x28
	private Rigidbody u0923u0924u091Fu0927u0920u0924u091Cu0926u0928u0927u0924; // 0x38
	private PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x40
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u0920u0925u091Cu0920u091Au091Bu0923u0929u0922u091Bu091A; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioClip[] doorClosedClips; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource loopSource; // 0x58
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource closedSource; // 0x60
	private Vector3 u0926u091Fu091Au0920u0926u0922u091Cu091Du0922u0928u0929; // 0x68
	private Vector3 u0923u0928u091Bu0929u0925u0924u0928u0923u091Cu0923u0922; // 0x74
	private float u0923u0925u0920u091Bu091Bu0921u0920u0929u091Eu091Bu091A; // 0x80

	// Constructors
	public Drawer() {} // 0x0000000180B0DE30-0x0000000180B0DE40

	// Methods
	private void u0921u0922u0924u0921u091Au091Du091Fu0923u0924u091Fu0929() {} // 0x0000000180B096C0-0x0000000180B09790
	private void u0928u0927u0923u0928u0928u0920u0926u091Cu0922u0923u091D() {} // 0x0000000180B0CBF0-0x0000000180B0CCC0
	private void u0922u091Fu0920u0924u0923u0929u091Au0927u091Fu0923u0927() {} // 0x0000000180B09B30-0x0000000180B09CB0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedPlayClosedSound() {} // 0x0000000180B05C20-0x0000000180B05D60
	public void u0929u091Fu0927u0921u0928u0927u0925u0928u0926u091Du0925() {} // 0x0000000180B0D670-0x0000000180B0D6E0
	public void u091Bu0926u0922u0928u0922u091Eu0925u0927u0920u091Cu0928() {} // 0x0000000180B06E70-0x0000000180B06EE0
	private void u0925u091Bu0923u0929u091Cu0923u091Au0925u091Bu0923u0927() {} // 0x0000000180B0B860-0x0000000180B0B9A0
	private void u0921u091Bu091Cu0925u0923u091Bu091Eu091Cu0922u091Eu0925() {} // 0x0000000180B05C10-0x0000000180B05C20
	public void u091Au091Au091Bu0928u0924u091Fu0926u091Eu0929u091Fu0922() {} // 0x0000000180B05EE0-0x0000000180B060D0
	private void u0924u0924u0925u091Du0924u091Cu091Fu0921u091Eu0928u0923() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u091Au0925u0925u091Du091Cu091Au091Cu0927u0929u0925u0929() {} // 0x0000000180B06C20-0x0000000180B06DA0
	public void UnGrab() {} // 0x0000000180B0D890-0x0000000180B0DA70
	private void u091Au091Cu0924u0921u0920u0929u0924u091Eu091Du091Fu0923() {} // 0x0000000180B06400-0x0000000180B064D0
	private void u0923u0924u0922u0921u0923u0926u0921u091Bu0920u091Eu0920() {} // 0x0000000180B0AD20-0x0000000180B0AEA0
	public void u091Au0922u0926u0929u0927u0922u0922u091Bu0925u0923u0923() {} // 0x0000000180B06680-0x0000000180B06870
	private void u091Du091Bu0928u091Eu0924u091Bu091Bu0928u0929u091Fu091E() {} // 0x0000000180B07F10-0x0000000180B08090
	private void u0929u091Cu091Eu0925u091Au0921u0922u0925u091Bu091Au091D() {} // 0x0000000180B0D420-0x0000000180B0D5A0
	private void u091Fu091Fu091Au091Cu0920u091Eu0929u0929u091Au091Au0921() {} // 0x0000000180B090E0-0x0000000180B09260
	private void u0920u091Bu0923u0927u0928u091Eu0922u0929u091Au0922u0920() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u0927u0922u0925u091Au091Bu0920u0928u0927u0923u0922u0923() {} // 0x0000000180B0C160-0x0000000180B0C2A0
	public void u0928u0921u091Au0920u0920u0929u0924u0927u0920u091Eu0928() {} // 0x0000000180B0C9D0-0x0000000180B0CA40
	private void u0922u0929u091Bu0921u0927u0928u091Bu0920u0921u0921u0925() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u0929u091Cu0924u0927u0921u0923u0927u0924u0927u0928u0924() {} // 0x0000000180B0D5A0-0x0000000180B0D670
	private void u091Eu0929u0929u091Fu0929u0929u0927u0920u0924u0927u0923() {} // 0x0000000180B08CD0-0x0000000180B08E10
	private void u091Cu0920u0929u0921u0922u0922u0921u0925u091Bu0926u091F() {} // 0x0000000180B07550-0x0000000180B078F0
	public void u091Cu0923u0925u0922u0921u091Au0924u0924u0920u0929u091F() {} // 0x0000000180B07CB0-0x0000000180B07EA0
	private void u0924u091Fu0920u0929u0920u0922u091Eu091Cu0927u0927u0920() {} // 0x0000000180B0B330-0x0000000180B0B4B0
	private void Awake() {} // 0x0000000180B05AD0-0x0000000180B05BA0
	public void u091Eu0926u0928u0921u0929u0927u091Eu091Cu091Au0921u0921() {} // 0x0000000180B08AE0-0x0000000180B08CD0
	public void u091Cu0929u091Au0926u0925u0923u0920u0928u0920u091Du0922() {} // 0x0000000180B07EA0-0x0000000180B07F10
	private void u0923u091Fu091Fu0925u0924u091Cu0925u091Fu0928u091Au0921() {} // 0x0000000180B0A750-0x0000000180B0AB10
	private void u0925u091Bu0928u091Fu0928u091Au0928u0921u0927u0923u0923() {} // 0x0000000180B0B9A0-0x0000000180B0BB20
	private void u0927u091Fu0924u0921u0929u0925u0925u0928u091Eu0927u0920() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u0920u0923u091Du091Eu0922u091Bu0927u0920u091Fu0928u0925() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u0924u0923u091Bu0927u091Eu0928u0926u0924u0924u091Bu091A() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u0924u0921u0928u0921u0926u091Au091Du0929u091Cu0920u091E() {} // 0x0000000180B0B4B0-0x0000000180B0B860
	private void u0925u0924u091Eu0927u091Bu091Cu0921u0929u091Du091Cu0921() {} // 0x0000000180B0BF50-0x0000000180B0C020
	public void u0922u0927u091Du0928u0923u0923u091Bu0929u0923u0927u0923() {} // 0x0000000180B09F70-0x0000000180B09FE0
	public void u091Du0923u091Bu0929u091Cu091Eu0921u0921u0925u0920u091B() {} // 0x0000000180B08280-0x0000000180B08470
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedGrab() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u091Au0921u091Cu0924u0929u091Au0920u091Au0923u091Bu0929() {} // 0x0000000180B064D0-0x0000000180B06610
	public void Grab() {} // 0x0000000180B05BA0-0x0000000180B05C10
	private void u091Au091Cu091Fu0924u091Au0922u0923u091Du091Bu091Bu091C() {} // 0x0000000180B060D0-0x0000000180B06210
	private void u0923u091Fu091Eu0926u091Cu0921u091Bu091Au091Au091Du091E() {} // 0x0000000180B0A390-0x0000000180B0A750
	public void u091Au091Cu0920u0929u0927u0926u091Fu0924u091Du0923u0929() {} // 0x0000000180B06210-0x0000000180B06400
	private void u091Fu091Du091Au0923u091Eu0927u0929u0928u0924u091Eu091B() {} // 0x0000000180B08E10-0x0000000180B08EE0
	private void u0920u091Cu091Bu0926u0920u0923u0927u091Bu091Du0925u091E() {} // 0x0000000180B093A0-0x0000000180B09520
	private void u091Bu091Au0929u091Au0923u091Au091Du0922u091Bu0928u0926() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u0923u0921u091Eu0924u0924u091Bu091Au0920u091Eu091Cu0923() {} // 0x0000000180B0AB10-0x0000000180B0ABE0
	private void u091Au0924u0920u091Au0929u0921u091Cu0927u0924u0924u0929() {} // 0x0000000180B06870-0x0000000180B06C20
	private void u0927u0926u0923u091Fu0927u091Cu0927u0921u0928u091Eu0921() {} // 0x0000000180B0C490-0x0000000180B0C610
	public void u0929u0920u091Du091Eu0923u091Du0924u091Fu091Du0922u091B() {} // 0x0000000180B0D6E0-0x0000000180B0D750
	private void u0922u0925u0922u0924u0928u091Bu0929u091Du0929u0926u091D() {} // 0x0000000180B09CB0-0x0000000180B09D80
	private void u091Bu0926u0927u091Fu091Au091Du0920u091Bu091Au091Bu0929() {} // 0x0000000180B06EE0-0x0000000180B07290
	public void u0927u091Fu0920u091Fu0923u0922u091Cu0922u0927u091Au0922() {} // 0x0000000180B0C0F0-0x0000000180B0C160
	public void u0928u0925u0924u0928u0925u091Du0928u0923u091Bu0923u0927() {} // 0x0000000180B0CAB0-0x0000000180B0CB20
	private void u0928u091Du091Bu0922u0928u0925u0929u0923u0926u091Eu0924() {} // 0x0000000180B0C610-0x0000000180B0C9D0
	private void u091Cu0920u0924u0923u0926u0927u0922u0925u0926u0928u091E() {} // 0x0000000180B07410-0x0000000180B07550
	private void u0929u0925u091Cu0924u091Fu0927u091Au091Au0920u0923u0922() {} // 0x0000000180B0D750-0x0000000180B0D890
	private void u0923u0928u0921u0928u091Fu091Fu0925u091Du091Du0928u0924() {} // 0x0000000180B0B260-0x0000000180B0B330
	private void u0922u091Cu091Eu0923u0929u0929u091Eu091Du0924u0928u0926() {} // 0x0000000180B09790-0x0000000180B09B30
	private void u091Cu0921u0921u091Au0928u0923u091Eu091Du091Du091Bu091A() {} // 0x0000000180B078F0-0x0000000180B07CB0
	private void u091Fu0927u091Fu0920u0921u091Fu0921u091Au091Eu091Du091A() {} // 0x0000000180B09260-0x0000000180B09330
	public void u091Fu0927u0922u091Fu091Du091Du0920u0926u091Au091Bu0925() {} // 0x0000000180B09330-0x0000000180B093A0
	private void u091Eu0922u0926u091Eu091Au091Fu091Bu091Au0927u091Cu0924() {} // 0x0000000180B08660-0x0000000180B08730
	public void u0928u0925u0920u091Fu0929u0926u091Au0927u091Eu0923u091B() {} // 0x0000000180B0CA40-0x0000000180B0CAB0
	private void u0925u0925u0921u0927u0922u091Eu0922u0923u091Eu0927u0924() {} // 0x0000000180B0C020-0x0000000180B0C0F0
	private void u091Bu091Fu0928u0920u091Bu091Au091Fu0923u0923u0928u0922() {} // 0x0000000180B06DA0-0x0000000180B06E70
	public void u0925u091Cu091Cu0926u091Bu091Cu0923u091Cu091Fu091Bu091C() {} // 0x0000000180B0BB20-0x0000000180B0BB90
	private void u0923u0922u0927u0926u0924u0923u0924u091Du0928u0929u0926() {} // 0x0000000180B0ABE0-0x0000000180B0AD20
	private void u091Du0924u0925u091Au0922u0929u0924u0929u0924u0929u091A() {} // 0x0000000180B08470-0x0000000180B085F0
	public void u0927u0923u0920u0920u0926u0920u091Cu0927u0926u091Du091D() {} // 0x0000000180B0C2A0-0x0000000180B0C490
	public void u091Fu091Du091Du0925u0923u0925u0922u0924u0924u091Bu0922() {} // 0x0000000180B08EE0-0x0000000180B090D0
	private void u0925u091Cu0921u091Bu091Bu0928u0920u0922u091Au0929u0925() {} // 0x0000000180B0BB90-0x0000000180B0BF50
	private void u091Cu091Cu0927u0924u0927u091Bu0920u0924u0923u091Du0924() {} // 0x0000000180B07290-0x0000000180B07410
	private void u0926u0928u091Du0924u091Fu091Cu091Au0921u091Au0921u091F() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u091Fu091Du091Eu091Cu0920u0928u0928u091Cu091Cu0929u091A() {} // 0x0000000180B090D0-0x0000000180B090E0
	public void u091Au0921u0926u091Du0922u091Bu0921u0921u0923u0922u0925() {} // 0x0000000180B06610-0x0000000180B06680
	public void u091Du091Fu0928u0922u0922u091Au0928u0923u0921u0924u0923() {} // 0x0000000180B08090-0x0000000180B08280
	private void u0923u0926u0921u091Eu091Bu091Cu091Au0925u091Au0920u091B() {} // 0x0000000180B0AEA0-0x0000000180B0B260
	private void u0921u091Eu0928u0927u0926u091Cu0929u0928u0926u0924u0923() {} // 0x0000000180B095F0-0x0000000180B096C0
	private void u091Fu091Eu0928u0927u0923u0925u0928u0927u0922u0926u091F() {} // 0x0000000180B05C10-0x0000000180B05C20
	private void u0921u091Cu0927u0923u0925u091Au0921u0929u0924u0920u0920() {} // 0x0000000180B09520-0x0000000180B095F0
	public void u0922u0925u0923u0927u091Bu0928u0924u091Fu0928u0926u091B() {} // 0x0000000180B09D80-0x0000000180B09F70
	private void u0927u091Au0924u091Eu0922u0926u091Bu091Cu091Cu091Cu0922() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u091Fu0922u0924u091Cu0925u091Fu0927u0926u0925u091Du0924() {} // 0x0000000180B090D0-0x0000000180B090E0
	private void u0928u0925u0928u091Cu0923u091Cu091Cu0923u0928u0922u0927() {} // 0x0000000180B0CB20-0x0000000180B0CBF0
	private void u0929u091Au0929u0922u091Bu0927u0921u0921u0922u091Cu0929() {} // 0x0000000180B0CCC0-0x0000000180B0D070
	private void u0922u0928u0923u091Eu091Au0920u0920u091Fu0928u0921u0924() {} // 0x0000000180B09FE0-0x0000000180B0A390
	private void Start() {} // 0x0000000180B05D60-0x0000000180B05EE0
	public void u091Eu091Cu0923u0927u0925u091Du0929u0929u091Au091Fu091B() {} // 0x0000000180B085F0-0x0000000180B08660
	private void u0929u091Bu0926u091Cu091Bu0920u091Cu0926u091Eu0926u0925() {} // 0x0000000180B0D070-0x0000000180B0D420
	private void Update() {} // 0x0000000180B0DA70-0x0000000180B0DE30
	private void u091Eu0926u0921u0926u091Du0929u091Au0922u091Du0929u0924() {} // 0x0000000180B08730-0x0000000180B08AE0
}
