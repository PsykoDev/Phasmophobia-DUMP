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

public class ExitLevel : MonoBehaviour // TypeDefIndex: 7225
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PhotonView view; // 0x18
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u091Cu0923u0928u091Bu0928u091Bu091Fu0929u0926u091Cu0921; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private ExitLevelTrigger trigger; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource source; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioClip startExitSound; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioClip stopExitSound; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private ItemSpawner itemSpawner; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private BoxCollider invisibleWall; // 0x50

	// Constructors
	public ExitLevel() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	public bool u091Eu0928u091Cu0924u091Fu091Bu0922u091Du0926u0921u0927() => default; // 0x0000000181865E00-0x0000000181866030
	public static void CheckMissions() {} // 0x0000000181864800-0x0000000181864B70
	private void u091Du0922u091Au0926u0929u0923u0928u0926u0925u0924u0920() {} // 0x00000001818658F0-0x0000000181865C40
	public void u0924u091Au0920u0922u0921u0923u091Du0926u0924u091Fu091F() {} // 0x0000000181866810-0x0000000181866890
	public static void CheckExp(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181864630-0x0000000181864800
	public void u091Fu091Fu091Du0921u091Au0929u0929u091Du0920u0923u0927() {} // 0x0000000181864F80-0x0000000181865000
	public static void u0922u0928u0925u0928u0923u0929u091Au091Au0929u0927u0929(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181866E00-0x0000000181867090
	private IEnumerator u0925u0926u0923u091Du0924u0927u091Au0921u091Cu091Au0929() => default; // 0x0000000181868A00-0x0000000181868A70
	public static void u0923u0921u091Cu091Fu0928u091Du0926u0928u091Eu0924u091B() {} // 0x0000000181867260-0x00000001818675A0
	private IEnumerator u091Fu091Eu0929u091Eu0922u0927u0922u0926u091Au091Du091A() => default; // 0x00000001818662D0-0x0000000181866340
	public static void u0928u091Eu091Fu0921u0923u0922u0920u0922u0923u091Du0921() {} // 0x0000000181868DB0-0x0000000181869030
	private void u0922u0926u0923u0926u0928u091Du0929u091Fu0928u0928u0925() {} // 0x0000000181866D50-0x0000000181866DB0
	public void StartAttemptExitLevel() {} // 0x0000000181864F80-0x0000000181865000
	public void u0920u0928u0928u091Du091Cu0929u0920u091Du0922u0926u0926() {} // 0x0000000181866890-0x0000000181866910
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void Exit() {} // 0x0000000181864B70-0x0000000181864EC0
	public static void u0922u0925u0926u0925u091Bu0921u0920u091Cu091Bu091Cu0921(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181866B90-0x0000000181866D50
	public bool ThereAreAlivePlayersOutsideTheTruck() => default; // 0x0000000181865050-0x0000000181865280
	public static void u091Du0921u0922u091Fu0920u0929u0924u0927u091Du091Au0920(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181865650-0x00000001818658F0
	public static void CheckChallenges(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181864390-0x0000000181864630
	private void u0925u0921u091Cu0927u0926u0922u0928u0923u0926u091Eu0929() {} // 0x0000000181864EC0-0x0000000181864F20
	public static void u0924u0925u091Bu0929u0927u0925u091Bu0924u0928u0922u091E() {} // 0x0000000181867C00-0x0000000181867EE0
	private void u0929u0920u0925u091Eu0923u091Au0928u091Cu0921u0925u0924() {} // 0x0000000181864EC0-0x0000000181864F20
	private IEnumerator u0925u0922u091Eu0928u0920u0924u0921u0924u091Fu091Eu091D() => default; // 0x0000000181868630-0x00000001818686A0
	public static void u0925u0921u0927u0926u0922u091Au0928u091Cu091Bu0928u0924() {} // 0x0000000181868300-0x0000000181868630
	public void u0921u091Bu091Fu0923u0921u0929u0923u0928u0929u091Fu0926() {} // 0x0000000181866890-0x0000000181866910
	public bool u0928u091Eu0921u091Fu0923u091Fu091Au0928u0927u091Fu0928() => default; // 0x0000000181869030-0x0000000181869220
	public static void u0924u0923u0920u0924u0924u0925u0924u0924u091Au0923u0926() {} // 0x00000001818678A0-0x0000000181867C00
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void PlayTruckStopSound() {} // 0x0000000181864F20-0x0000000181864F80
	public static void u091Bu091Au0921u0925u0929u0921u0924u091Au0929u0929u091A(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181865340-0x00000001818655E0
	public void u0920u091Du091Eu0922u091Au091Du0920u0921u0923u0924u0926() {} // 0x0000000181866810-0x0000000181866890
	public static void u091Fu091Cu0923u091Fu091Au0920u091Cu0924u0928u0923u091E(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181866030-0x00000001818662D0
	private IEnumerator u091Au0920u091Fu0924u0929u0924u0921u0920u091Du0921u0922() => default; // 0x0000000181865280-0x00000001818652F0
	public bool u0920u091Cu0927u0928u091Fu0922u0925u091Bu0923u0923u0920() => default; // 0x00000001818665E0-0x0000000181866810
	public static void u091Du0928u0922u091Cu091Du0920u0922u091Fu091Fu0924u091F(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181865C40-0x0000000181865E00
	private void u091Au0928u091Fu0927u0925u091Bu0926u0927u0929u0926u091E(int u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001818652F0-0x0000000181865340
	public static void u0924u0921u0926u091Du0920u0920u091Du0923u0920u0928u0922(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181867600-0x00000001818678A0
	public static void u0925u0921u091Eu0924u091Au0927u0921u0923u0928u091Fu091F(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181868140-0x0000000181868300
	private void u091Fu0921u0924u091Bu091Du091Du0929u0926u0920u091Eu0924() {} // 0x0000000181864F20-0x0000000181864F80
	private void u0927u091Fu0927u0926u0923u0922u0923u0927u0924u0926u091D() {} // 0x0000000181868A70-0x0000000181868DB0
	private void u0925u091Bu0926u091Cu091Fu0924u091Eu091Cu091Du0922u0926(int u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001818680F0-0x0000000181868140
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void SyncPhotoValue(int u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181865000-0x0000000181865050
	private IEnumerator u0922u091Bu091Cu091Bu0920u0922u0926u091Fu0922u0928u0924() => default; // 0x0000000181866910-0x0000000181866980
	private void u0927u091Au0923u091Du0921u0921u0924u091Du091Cu091Bu0923() {} // 0x0000000181864F20-0x0000000181864F80
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void PlayTruckStartUpSound() {} // 0x0000000181864EC0-0x0000000181864F20
	private void u0923u0921u0920u0926u091Au0923u0922u0926u0925u0929u0928() {} // 0x00000001818675A0-0x0000000181867600
	public static void u0920u091Cu091Du0925u091Au091Au091Cu0921u0921u0926u091D(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181866340-0x00000001818665E0
	public void u0923u091Au0922u0922u0922u0925u0920u0920u0921u0921u0920() {} // 0x0000000181866810-0x0000000181866890
	// [IteratorStateMachine] // 0x000000018010BAA0-0x000000018010BAF0
	private IEnumerator u091Cu091Cu0924u0928u091Bu0920u0927u0927u0925u091Au0928() => default; // 0x00000001818655E0-0x0000000181865650
	private void u0924u0928u091Au091Du0926u0926u0920u0924u0929u0926u091E(int u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181867EE0-0x0000000181867F30
	public bool u0922u091Du0923u091Du0924u0926u0928u0926u091Cu0929u091D() => default; // 0x0000000181866980-0x0000000181866B90
	public static void u0925u0924u0920u091Cu0926u0928u091Du0926u0920u0925u091E() {} // 0x00000001818686A0-0x0000000181868A00
	public static void u0923u091Cu0921u0925u091Fu0922u091Fu0921u091Bu091Cu0926(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181867090-0x0000000181867260
	public static void u0924u0929u0928u091Du0923u091Eu091Fu0920u0929u091Au0928(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181867F30-0x00000001818680F0
	private void u0922u0927u0929u091Du091Eu0924u0927u0929u0922u091Eu0923(int u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x0000000181866DB0-0x0000000181866E00
	public static void u0928u0926u091Fu091Au091Cu0926u091Eu0923u0921u091Cu0923(bool u0922u091Eu0927u091Cu0924u091Bu0929u0926u091Eu0927u091A) {} // 0x0000000181869220-0x00000001818694C0
}

