﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class LightSwitch : MonoBehaviour // TypeDefIndex: 7037
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource source; // 0x18
	public PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioClip[] clips; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioClip bulbSmashClip; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private List<Light> lights; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private List<Renderer> rends; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Renderer rendToChangeTexture; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Texture onTexture; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Texture offTexture; // 0x58
	public List<ReflectionProbe> u091Bu091Du0925u091Cu0923u0924u0924u0921u0925u0923u091A; // 0x60
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Animator[] animators; // 0x68
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource[] sources; // 0x70
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject[] objectsToActivate; // 0x78
	public Transform u0922u091Bu0921u091Du0926u0924u0923u0923u0925u091Bu0925; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PhotonObjectInteract photonInteract; // 0x88
	private List<float> u0924u0924u0920u0927u091Au0923u0924u091Au0921u091Eu091B; // 0x90
	private float u0921u0925u0922u091Cu091Eu0928u091Fu091Au0927u091Eu0923; // 0x98
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u091Cu0927u091Au0923u0920u0922u0924u0923u091Au0925u091E; // 0x9C
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Noise noise; // 0xA0
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u091Du091Au0928u091Cu091Au0926u0925u0922u091Au091Du091A; // 0xA8
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public LevelRoom u091Au0921u091Eu091Cu0923u091Fu091Cu0926u0929u0921u0929; // 0xB0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject handPrintObject; // 0xB8

	// Constructors
	public LightSwitch() {} // 0x0000000181163AF0-0x0000000181163BF0

	// Methods
	public void u091Eu0921u091Du0926u0923u091Au0928u091Eu0929u0921u091C() {} // 0x0000000181154A70-0x0000000181154B30
	private IEnumerator u0929u0925u0922u091Bu0928u0920u0926u0925u091Du0926u0920() => default; // 0x0000000181162270-0x00000001811622E0
	public void u0921u0929u091Cu091Au0920u091Fu091Du0928u091Au0928u0928() {} // 0x000000018115A560-0x000000018115A620
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	public void TurnOffNetworked(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114DB20-0x000000018114E2A0
	private void u0928u0927u0924u0925u0927u0925u0927u091Bu0920u0929u091F() {} // 0x00000001811619D0-0x0000000181161A50
	public void u091Cu0923u0928u0920u0925u091Bu0925u091Bu0925u0921u091E() {} // 0x0000000181152BD0-0x0000000181152D30
	public void u0925u0922u0924u0920u091Au0925u091Cu0923u0926u091Bu0927() {} // 0x000000018115EE60-0x000000018115EF20
	public void u0927u091Bu0920u0929u091Au0927u091Bu091Fu091Eu091Au0922() {} // 0x000000018114D710-0x000000018114D720
	private void u091Eu0928u0920u0927u0925u0929u0920u0922u091Cu0929u091B() {} // 0x0000000181155E20-0x0000000181156010
	private IEnumerator u0927u091Eu0924u0920u0928u0926u091Bu091Fu091Du0922u0927() => default; // 0x000000018115F560-0x000000018115F5D0
	public void u0924u0920u0925u0924u091Du0923u0924u0927u0924u0921u091E(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018115DDD0-0x000000018115E490
	private IEnumerator u091Fu0922u0925u0928u091Au0924u091Fu0926u0927u0928u0926() => default; // 0x0000000181156B60-0x0000000181156BD0
	public void u0929u0926u091Du091Eu0928u0920u0920u091Du0927u091Cu091F() {} // 0x00000001811622E0-0x00000001811623A0
	public void u0920u0921u0926u0923u0920u0925u091Eu0927u0923u0922u091A() {} // 0x0000000181157CD0-0x0000000181157E30
	public void u0920u091Eu0922u0922u091Au091Cu091Du091Du091Fu0926u0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181157590-0x0000000181157C60
	public void u091Du091Fu091Au0921u0923u091Eu091Au0928u091Eu091Fu0926(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181153AF0-0x0000000181154230
	private void u091Eu0925u091Bu0922u0923u091Bu091Du0922u0924u091Fu091F() {} // 0x0000000181155DA0-0x0000000181155E20
	public void u0929u0920u091Fu0929u091Du091Cu0922u0928u0925u0924u0922() {} // 0x0000000181162090-0x0000000181162180
	private void u091Au0925u0927u0927u091Bu0927u0929u0925u091Cu0920u0920() {} // 0x000000018114F350-0x000000018114F5D0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedSpawnHandPrintEvidence() {} // 0x000000018114CD40-0x000000018114CD70
	public void SmashBulb() {} // 0x000000018114D5E0-0x000000018114D650
	public void u091Bu091Au091Au0922u0921u0920u0929u0928u0924u091Eu0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114FDB0-0x000000018114FEA0
	public void u0926u0928u0921u091Bu0921u0927u091Du0929u0920u0921u091A() {} // 0x000000018115F2B0-0x000000018115F370
	public void u0926u0922u091Eu0928u0929u0928u091Au091Bu0929u091Au091A(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018115F0D0-0x000000018115F1C0
	private void u091Eu0922u0921u091Du091Fu0920u091Cu091Eu091Eu0927u091D() {} // 0x000000018114C330-0x000000018114C3B0
	private void u091Fu091Cu0928u0924u0925u091Au091Bu0923u091Bu091Au091F() {} // 0x0000000181156750-0x00000001811567D0
	public void u0923u0920u091Du091Fu0929u0920u091Bu0926u091Au091Fu0928() {} // 0x000000018115BFF0-0x000000018115C560
	public void u091Cu091Bu0922u0925u091Cu0922u0928u0928u0922u091Du0923() {} // 0x0000000181151050-0x00000001811511B0
	private void u0923u0925u091Eu0928u0929u091Cu0924u091Du0926u0921u0925() {} // 0x000000018115A4E0-0x000000018115A560
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	public void TurnOnNetworked(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114E390-0x000000018114EA70
	public void StopBlinking() {} // 0x000000018114D9C0-0x000000018114DB20
	private void u0922u091Cu0929u0922u0927u0921u091Eu0921u091Fu091Eu0921() {} // 0x000000018115A620-0x000000018115B4D0
	public void u091Bu0921u0922u0923u091Au0927u0928u091Au0927u0929u091B(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181150880-0x0000000181150970
	public void u091Cu0920u091Au0926u0926u0929u0924u0921u0921u0923u0924() {} // 0x000000018114D710-0x000000018114D720
	private void Update() {} // 0x0000000181162AF0-0x0000000181162B70
	// [IteratorStateMachine] // 0x000000018012E410-0x000000018012E460
	private IEnumerator u091Eu091Cu0924u091Fu0929u0929u0928u091Eu0928u0921u0921() => default; // 0x0000000181154780-0x00000001811547F0
	private IEnumerator u091Cu0923u0924u0926u0922u0927u091Eu0927u0925u0927u0920() => default; // 0x0000000181152B60-0x0000000181152BD0
	public void u0923u0923u091Cu091Eu0924u0922u0923u091Au091Bu0928u0926() {} // 0x000000018115C560-0x000000018115CA00
	private IEnumerator u091Cu0927u091Fu0924u091Bu091Du0929u091Bu0928u0927u0926() => default; // 0x0000000181153630-0x00000001811536A0
	public void u0928u0927u091Bu091Eu0920u0920u0929u0924u0924u0928u0920() {} // 0x000000018114D710-0x000000018114D720
	public void u0920u0923u0927u0925u0929u091Fu091Du0926u0923u091Bu0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x00000001811585B0-0x0000000181158CE0
	public void u091Bu0923u0924u0921u0929u0920u091Du0929u0922u0922u0928(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181150970-0x0000000181150A60
	private void u091Fu091Bu0924u0921u091Bu091Eu091Fu0921u0922u0924u0920() {} // 0x0000000181156010-0x00000001811562B0
	public void u0927u0927u0928u0921u091Eu0929u0927u091Cu091Bu0922u0924() {} // 0x000000018115FF40-0x0000000181160520
	private void u0927u091Eu0929u0920u0922u091Fu091Fu0920u091Du0926u0926() {} // 0x000000018115F5D0-0x000000018115F6C0
	public void u0923u0925u0921u091Cu0921u0926u0926u091Cu0927u0925u0927() {} // 0x000000018114D710-0x000000018114D720
	// [IteratorStateMachine] // 0x000000018012E530-0x000000018012E580
	private IEnumerator u0920u091Fu0927u0927u091Fu091Du091Au091Fu0921u091Au0921() => default; // 0x0000000181157C60-0x0000000181157CD0
	private void u0921u0923u091Eu0925u0921u0920u0923u091Au091Au0929u0920() {} // 0x000000018115A090-0x000000018115A3F0
	public void u091Eu091Eu091Fu091Fu0926u0922u0922u0928u0928u0921u0924() {} // 0x00000001811547F0-0x0000000181154860
	public void u0929u0928u0929u0929u091Eu0929u091Du0923u0923u0924u0927(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181162410-0x0000000181162AF0
	public void u0921u0921u091Cu0926u0927u091Bu091Cu091Fu0925u0927u0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x00000001811599C0-0x000000018115A090
	public void u0921u091Fu0929u0927u091Du0921u0923u0922u091Au0927u091D() {} // 0x0000000181159820-0x00000001811599C0
	private void u091Cu091Cu0924u091Du0929u0923u091Fu0924u091Cu0924u0920() {} // 0x00000001811511B0-0x0000000181152040
	private void u091Cu0922u0924u091Fu091Au091Au0920u0920u091Cu0920u0929() {} // 0x0000000181152970-0x0000000181152B60
	public void TurnOn(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114EA70-0x000000018114EB60
	private void u0928u091Bu0929u091Fu0921u0926u091Fu091Au0926u0921u0921() {} // 0x0000000181160520-0x00000001811605A0
	private void u0928u0922u0925u091Fu091Cu0928u091Fu0925u091Cu091Du0929() {} // 0x0000000181160FA0-0x0000000181161320
	private void u0922u091Fu091Cu0926u0925u0920u091Fu091Au0920u0929u091D() {} // 0x000000018115B4D0-0x000000018115B6C0
	private IEnumerator u0928u0928u0924u091Du0929u091Eu0925u0922u091Du091Au091A() => default; // 0x0000000181161A50-0x0000000181161AC0
	private void u0927u091Fu0924u091Cu091Du0928u0920u091Bu0924u091Au0928() {} // 0x000000018115EFE0-0x000000018115F010
	public void u0929u0922u0925u0929u0928u091Eu091Au091Eu091Cu0927u0920(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181162180-0x0000000181162270
	public void u0920u0923u091Cu0920u0927u0927u0927u0927u091Du0928u0921(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181157E30-0x00000001811585B0
	public void u0928u0927u091Du0922u091Bu0922u091Bu091Du091Du0922u091D() {} // 0x00000001811618F0-0x00000001811619D0
	private void u091Bu0928u0925u0920u0920u0923u0921u0923u091Fu0927u0920() {} // 0x000000018114CD40-0x000000018114CD70
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void ResetLights() {} // 0x000000018114CD70-0x000000018114CE60
	private void u0927u0925u0925u091Fu0921u0924u0929u0927u0924u0929u0921() {} // 0x000000018115EFE0-0x000000018115F010
	public void u091Eu0924u091Fu0926u0921u0927u091Cu0920u0922u0922u0925() {} // 0x0000000181155750-0x0000000181155CB0
	private void u0923u0923u0921u0929u0924u0927u091Fu0921u091Bu0920u091F() {} // 0x000000018115CA00-0x000000018115D840
	public void u0924u0921u0929u0928u091Fu091Bu091Du091Au0922u091Au0923() {} // 0x000000018115E500-0x000000018115E9B0
	private void Awake() {} // 0x000000018114BBF0-0x000000018114BDE0
	public void u0920u0926u091Fu0921u0925u0924u0923u0921u091Au091Fu0920(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181158CE0-0x00000001811593A0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void FlickerNetworked() {} // 0x000000018114C330-0x000000018114C3B0
	private IEnumerator u091Eu0921u091Fu0926u0929u091Fu0920u091Cu0925u091Du091D() => default; // 0x0000000181154B30-0x0000000181154BA0
	private IEnumerator u0921u091Eu0929u091Cu091Eu0922u0923u0922u091Bu091Bu0923() => default; // 0x00000001811597B0-0x0000000181159820
	public void u0927u0925u0922u091Bu091Du0923u091Du0924u091Du0928u0926() {} // 0x000000018115FDA0-0x000000018115FF40
	private IEnumerator u0921u091Du091Au0922u091Fu091Bu0926u0923u0925u0923u091A() => default; // 0x00000001811595E0-0x0000000181159650
	private IEnumerator u0922u0921u0924u091Du091Bu091Cu0928u0928u091Fu0927u0927() => default; // 0x000000018115B6C0-0x000000018115B730
	private void u091Fu0923u091Du0927u091Cu0924u0928u0921u091Cu0926u091F() {} // 0x0000000181156BD0-0x0000000181156CC0
	private void u0929u0922u0920u091Du091Au091Bu0923u091Au091Fu0920u0923() {} // 0x000000018115EFE0-0x000000018115F010
	private IEnumerator u0928u0924u0927u091Fu0921u0923u0927u091Cu091Eu0924u091F() => default; // 0x0000000181161880-0x00000001811618F0
	public void SpawnHandPrintEvidence() {} // 0x000000018114D650-0x000000018114D710
	private void u0921u0927u0923u091Cu091Fu091Fu0929u0928u091Fu091Fu0924() {} // 0x000000018115A4E0-0x000000018115A560
	public void u0922u0924u091Cu0922u091Eu0926u091Au091Du0922u0920u091E(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018115B730-0x000000018115BE90
	private void u091Bu0927u0923u091Fu091Eu0923u0928u0925u0925u0927u0925() {} // 0x0000000181150A60-0x0000000181150B50
	private void u091Fu0927u0925u0926u0927u091Fu0921u0926u091Au091Bu0924() {} // 0x00000001811574D0-0x0000000181157590
	private void u091Au0928u0924u091Cu0929u091Du0924u0925u091Au091Bu0929() {} // 0x000000018114CD40-0x000000018114CD70
	public void u0921u0927u091Cu0929u091Fu091Eu091Cu0922u0921u0924u0920() {} // 0x000000018115A3F0-0x000000018115A4E0
	public void u0924u091Cu091Bu0928u0920u0927u0926u0926u0920u091Au091D() {} // 0x000000018115D920-0x000000018115D990
	private void u0925u0920u091Eu0921u0921u091Cu091Cu0925u0928u0929u0925() {} // 0x000000018115EC70-0x000000018115EE60
	private void u0921u091Du0920u0924u091Bu091Cu0929u0929u0921u0922u0929() {} // 0x000000018114CD40-0x000000018114CD70
	// [IteratorStateMachine] // 0x000000018012E740-0x000000018012E790
	private IEnumerator u091Eu0921u091Au0927u0920u0927u0927u091Du0925u0927u0924() => default; // 0x0000000181154860-0x00000001811548D0
	public void u091Bu091Fu091Eu0922u0926u091Eu0929u0929u0928u091Fu0929() {} // 0x00000001811506E0-0x0000000181150880
	private void u091Au0926u091Bu0924u0920u0924u0927u0924u091Bu091Cu0923() {} // 0x000000018114F5D0-0x000000018114F7C0
	public void UseLight() {} // 0x0000000181162B70-0x0000000181162C50
	public void u0927u0924u0924u0924u091Au091Cu0929u0925u0923u0926u091E() {} // 0x000000018115F8B0-0x000000018115FDA0
	public void u091Eu0921u0924u091Fu0928u0927u0920u0924u091Cu0921u091D(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181154BA0-0x0000000181155260
	private void u091Cu091Cu0925u0922u0926u091Bu0929u0926u091Eu0923u091A() {} // 0x0000000181152040-0x0000000181152230
	public void u091Fu091Cu091Au0924u0920u0928u0925u0922u091Cu0927u091F() {} // 0x00000001811562B0-0x0000000181156750
	private IEnumerator u0929u0928u0928u091Fu091Cu0925u0925u0923u091Eu0924u091A() => default; // 0x00000001811623A0-0x0000000181162410
	public void u091Du091Eu0925u0927u0922u0925u091Du091Au091Eu0929u091A() {} // 0x00000001811536A0-0x0000000181153AF0
	public void u0928u091Du0920u0927u091Bu091Cu091Eu0920u091Au0927u0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x00000001811607F0-0x0000000181160F30
	private void u0921u091Au0921u0923u091Eu0925u0926u091Bu0927u0927u0920() {} // 0x0000000181159460-0x0000000181159520
	public void FuseOn() {} // 0x000000018114C840-0x000000018114CD40
	private void u0927u0920u0927u091Cu091Au0924u091Eu091Au0924u0921u091B() {} // 0x000000018115F6C0-0x000000018115F8B0
	public void ResetReflectionProbes() {} // 0x000000018114CE60-0x000000018114D000
	private void u0929u091Au091Bu091Du0926u091Eu0923u0921u0929u091Cu0922() {} // 0x000000018114CD40-0x000000018114CD70
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	public void SmashBulbNetworked() {} // 0x000000018114D000-0x000000018114D5E0
	private void Start() {} // 0x000000018114D720-0x000000018114D9C0
	public void u091Fu091Eu0929u091Du0922u091Eu0924u0920u091Eu091Cu0929() {} // 0x00000001811569C0-0x0000000181156AA0
	public void u0924u0921u0928u091Au0923u0927u091Cu0928u091Du0921u091B() {} // 0x000000018115E490-0x000000018115E500
	public void u0924u091Bu0924u091Du0924u0922u0928u091Au091Du091Du0924() {} // 0x000000018115D840-0x000000018115D920
	public void u0929u091Au0924u0928u091Du0928u0922u0924u091Bu091Bu0927() {} // 0x0000000181161AC0-0x0000000181161C20
	public void u0929u091Cu0921u091Eu0927u0924u0926u0923u091Au091Au0924(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181161E40-0x0000000181161F30
	public void u091Au0926u0925u0921u0920u091Au091Eu091Du0922u0924u0920() {} // 0x000000018114F7C0-0x000000018114FD30
	public void u091Au0920u0928u091Au0929u0920u091Eu0925u0921u0926u0922(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114F260-0x000000018114F350
	public void FuseOff() {} // 0x000000018114C3B0-0x000000018114C840
	private void u091Fu091Du091Au0923u091Eu0927u0929u0928u0924u091Eu091B() {} // 0x00000001811567D0-0x00000001811569C0
	public void Blink() {} // 0x000000018114BDE0-0x000000018114C330
	public void u0926u0926u091Bu0921u0929u0927u0920u0928u091Du091Au0929() {} // 0x000000018115F1C0-0x000000018115F2B0
	private void u0926u0928u0921u0926u0926u091Au0928u0925u091Du0921u0923() {} // 0x000000018115F370-0x000000018115F560
	public void u091Bu0928u091Fu0924u0924u0923u0923u091Cu0926u091Du091F() {} // 0x0000000181150B50-0x0000000181150FE0
	public void u091Eu0921u091Bu091Cu091Eu0928u091Bu091Fu0927u0923u0925() {} // 0x00000001811548D0-0x0000000181154A70
	public void u0924u0920u0921u091Eu0921u0928u0928u091Cu091Cu0924u0922() {} // 0x000000018115D990-0x000000018115DDD0
	public void u0921u091Du0920u0928u0926u091Du091Au091Cu0923u0924u091F() {} // 0x0000000181159650-0x00000001811597B0
	public void u0928u091Du091Cu091Fu0922u0928u0925u091Cu091Du091Eu091B() {} // 0x0000000181160690-0x00000001811607F0
	public void u0925u0925u091Bu0927u091Bu091Eu091Eu0923u0925u091Fu0927() {} // 0x000000018115EF20-0x000000018115EFE0
	public void u0921u091Cu091Fu091Au091Eu091Cu0925u0920u091Bu0921u0920() {} // 0x0000000181159520-0x00000001811595E0
	public void u0925u091Du0920u091Fu091Du0921u091Fu091Fu0922u0929u0924() {} // 0x000000018115E9B0-0x000000018115EB10
	public void u091Fu0922u091Fu091Cu0923u091Bu0921u091Fu091Cu0924u0926() {} // 0x0000000181156AA0-0x0000000181156B60
	public void u0920u0926u0926u0921u0924u0928u0924u0923u091Cu0924u091D() {} // 0x00000001811593A0-0x0000000181159460
	private IEnumerator u091Cu091Fu091Bu091Cu091Au0926u0927u0924u0927u0928u0926() => default; // 0x0000000181152230-0x00000001811522A0
	public void StartBlinking() {} // 0x000000018114D710-0x000000018114D720
	public void u0928u091Cu0922u091Bu091Eu091Cu0921u0924u0929u091Fu091F() {} // 0x00000001811605A0-0x0000000181160690
	private void u091Au0928u091Cu091Bu0920u0928u0921u0921u0929u091Eu091B() {} // 0x000000018114FD30-0x000000018114FDB0
	public void u091Fu0926u0929u091Fu091Du0921u0927u091Bu091Cu0921u091A() {} // 0x0000000181156F50-0x00000001811574D0
	public void u0922u0928u0927u0929u0928u0928u0928u0926u091Fu0926u0924() {} // 0x000000018115BE90-0x000000018115BFF0
	public void u091Eu0922u0927u091Au091Fu0922u0929u091Eu0920u0924u091B() {} // 0x0000000181155260-0x0000000181155750
	public void u091Au091Cu0928u0920u0921u0921u0929u0920u0925u0921u091A(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114EB60-0x000000018114F260
	private IEnumerator u0928u0921u091Bu091Au091Fu0925u0923u0927u091Bu0929u0925() => default; // 0x0000000181160F30-0x0000000181160FA0
	public void u091Du0925u091Au0922u091Du091Du0929u0927u091Cu0924u091B() {} // 0x0000000181154230-0x0000000181154780
	public void u091Cu0924u0923u091Cu0925u091Du0927u091Eu0929u0921u0924() {} // 0x0000000181152D30-0x0000000181152ED0
	private IEnumerator u091Bu0928u0927u091Du0922u091Au0925u091Eu0920u0924u0922() => default; // 0x0000000181150FE0-0x0000000181151050
	public void u0925u091Eu0928u091Eu091Du091Bu091Fu091Cu0929u0928u091D() {} // 0x000000018115EB10-0x000000018115EC70
	private void u091Eu0924u0925u0926u091Du0926u091Du0928u091Cu0926u091F() {} // 0x0000000181155CB0-0x0000000181155DA0
	public void TurnOff() {} // 0x000000018114E2A0-0x000000018114E390
	public void u091Cu0921u0924u0929u0925u0924u091Eu0929u0923u091Bu0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x00000001811522A0-0x0000000181152970
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void Use() {} // 0x0000000181162C50-0x0000000181163AF0
	public void u0929u091Bu091Bu091Du091Fu0924u0925u091Eu091Au091Eu091B() {} // 0x0000000181161CA0-0x0000000181161E40
	public void u0928u0923u091Fu0929u0929u091Cu0925u0926u0924u0925u091F() {} // 0x0000000181161320-0x0000000181161790
	private void u0926u091Eu0926u0923u091Fu0924u0920u0920u0924u0923u091C() {} // 0x000000018115EFE0-0x000000018115F010
	private void u091Fu0923u0922u091Eu091Fu091Bu0924u091Eu0928u091Au0929() {} // 0x0000000181156CC0-0x0000000181156F50
	public void u0928u0923u0925u0923u0929u0924u0924u0928u091Au0927u0927() {} // 0x0000000181161790-0x0000000181161880
	public void u091Bu091Bu091Cu091Eu0926u0927u0924u0920u0928u0924u091F(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x000000018114FEA0-0x0000000181150620
	public void u0924u091Cu091Au091Fu091Eu0924u0928u091Cu091Cu091Du091D() {} // 0x000000018114D710-0x000000018114D720
	public void u091Cu0926u0929u0926u0926u0923u0926u0921u091Eu091Du0923(bool u0929u091Au0923u0923u0926u091Au0927u0925u0926u091Bu0927) {} // 0x0000000181152ED0-0x0000000181153630
	private void u0929u091Au0929u0922u091Bu0927u0921u0921u0922u091Cu0929() {} // 0x0000000181161C20-0x0000000181161CA0
	public void u0926u0921u091Fu0922u0927u0925u091Cu091Eu0924u091Eu091E() {} // 0x000000018115F010-0x000000018115F0D0
	public void u0929u091Eu0928u0927u0928u0920u0924u091Eu0920u0927u0925() {} // 0x0000000181161F30-0x0000000181162090
	private void u091Bu091Bu0928u0924u091Eu0926u0926u0923u0923u0925u0929() {} // 0x0000000181150620-0x00000001811506E0
}

