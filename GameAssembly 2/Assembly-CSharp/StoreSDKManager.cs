﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class StoreSDKManager : MonoBehaviour // TypeDefIndex: 7217
{
	// Fields
	public u0920u091Au0927u091Bu0926u0926u0926u0927u0927u0925u091F u0923u0924u091Eu091Du0923u0924u091Du091Au0920u091Fu091F; // 0x18
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public u091Du091Eu0923u0922u091Cu091Cu091Bu0926u0926u0925u0928 u091Du0920u0920u0925u0928u091Au0924u0929u0928u091Bu0929; // 0x1C
	public u091Du091Eu0923u0922u091Cu091Cu091Bu0926u0926u0925u0928 u091Eu0927u091Eu0925u091Fu0926u0924u091Bu0926u0927u091E; // 0x20
	public string u091Fu091Bu091Au0924u0920u0923u0921u0926u0924u091Cu091E; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private ViveportInitialiser viveportInitialiser; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private SteamManager steamManager; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private MainManager mainManager; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private StoreManager storeManager; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject errorScreen; // 0x50
	public static StoreSDKManager u0925u091Fu0920u091Cu0925u091Fu0927u091Cu091Au0925u0927; // 0x00

	// Nested types
	public enum u0920u091Au0927u091Bu0926u0926u0926u0927u0927u0925u091F // TypeDefIndex: 7218
	{
		steam = 0,
		viveport = 1
	}

	public enum u091Du091Eu0923u0922u091Cu091Cu091Bu0926u0926u0925u0928 // TypeDefIndex: 7219
	{
		Main = 0,
		Developer = 1,
		Arcade = 2
	}

	// Constructors
	public StoreSDKManager() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	private void u091Du091Fu0929u091Cu091Du091Cu091Au091Bu091Bu091Du091B(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118AFA0-0x000000018118AFC0
	private void u0925u091Fu0921u091Au091Fu091Eu0924u0921u0921u0924u091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118D330-0x000000018118D340
	private IEnumerator u0929u0925u0928u0922u091Eu091Bu091Fu0928u091Du0923u091C() => default; // 0x000000018118E4B0-0x000000018118E520
	private IEnumerator u0928u0927u0925u091Eu0927u091Bu091Cu0924u0920u0920u0927() => default; // 0x000000018118E420-0x000000018118E490
	private void u091Bu0921u0925u091Fu0922u091Cu091Du0926u0921u091Eu0920(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118A900-0x000000018118A910
	public void u0926u091Eu091Du0924u091Eu0925u0927u091Eu0929u0926u0929() {} // 0x000000018118D900-0x000000018118D990
	private void u0925u091Eu091Eu0923u0924u0922u0922u0928u0925u091Au0924() {} // 0x000000018118D240-0x000000018118D330
	private IEnumerator u0922u0924u0924u091Fu0929u091Eu0927u0928u091Au0924u0921() => default; // 0x000000018118C690-0x000000018118C700
	public void u0929u0928u0927u091Eu091Au091Cu0922u091Du0928u091Du0922() {} // 0x000000018118E5B0-0x000000018118E640
	private void u0924u0923u0921u0924u091Cu0923u091Cu091Bu0927u091Au0924() {} // 0x000000018118CF90-0x000000018118D080
	public void u0924u0920u0922u091Fu091Bu0921u091Cu0923u0927u0927u0923() {} // 0x000000018118CCF0-0x000000018118CD80
	public void u0920u0922u091Du091Cu091Au091Cu0927u0925u0925u0928u0929() {} // 0x000000018118BBA0-0x000000018118BC30
	private void u091Fu091Bu0922u0929u0929u0927u0921u091Bu0927u091Fu091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B4A0-0x000000018118B4C0
	private void u0927u0921u091Eu0922u0926u091Cu0927u091Au091Eu0929u091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DEB0-0x000000018118DED0
	private IEnumerator u091Bu0920u0929u091Eu0922u091Au0928u0922u0929u091Cu0924() => default; // 0x000000018118A890-0x000000018118A900
	private void u0926u091Fu0920u091Bu0923u091Cu091Fu0927u0920u0924u0920(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DA90-0x000000018118DAB0
	private void u091Fu091Eu0927u091Cu0921u0925u0925u091Bu0921u091Bu091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B5B0-0x000000018118B5C0
	private void u0921u091Cu0927u0923u0925u091Au0921u0929u0924u0920u0920() {} // 0x000000018118BF30-0x000000018118C060
	private void u091Eu0925u0921u0923u0927u0921u0926u091Eu0924u0924u091D(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B300-0x000000018118B320
	public void u0929u0927u091Fu091Bu0926u0927u0922u0924u091Fu091Bu091A() {} // 0x000000018118E520-0x000000018118E5B0
	private IEnumerator u091Fu091Fu091Au091Cu0920u091Eu0929u0929u091Au091Au0921() => default; // 0x000000018118B5C0-0x000000018118B630
	public void u0927u0929u0925u091Fu0926u0921u091Au091Cu091Au091Du0920() {} // 0x000000018118E060-0x000000018118E0F0
	private void u0925u091Au0927u0926u091Bu0927u091Du0923u091Bu091Bu091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118D220-0x000000018118D240
	private void u091Au091Du091Cu091Au0921u0923u0923u0926u0926u0928u091D(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118A190-0x000000018118A1B0
	private void u0925u0920u091Eu0921u0921u091Cu091Cu0925u0928u0929u0925() {} // 0x000000018118D340-0x000000018118D430
	private void u0929u091Eu0929u0921u0921u0928u0925u091Cu091Cu091Du0927(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118ACE0-0x000000018118AD00
	public void u091Bu091Eu091Fu0929u091Cu0929u0928u091Bu091Du091Cu091B() {} // 0x000000018118A770-0x000000018118A800
	public void u091Bu091Eu0925u0921u0925u0927u0928u0927u0924u091Au0924() {} // 0x000000018118A800-0x000000018118A890
	public void u0923u091Cu0921u0926u0922u091Eu0927u0925u091Bu0929u091C() {} // 0x000000018118C8F0-0x000000018118C980
	private void u0926u091Eu0920u091Fu0927u091Eu0925u0927u0923u091Au091E(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118A190-0x000000018118A1B0
	private void u091Eu0922u091Bu091Bu0923u0923u091Eu091Au0926u0923u091F() {} // 0x000000018118B180-0x000000018118B270
	public void QueryArcadeLicense() {} // 0x000000018118A020-0x000000018118A0B0
	public void u091Eu0922u0924u091Fu0920u091Au091Eu0924u0921u0923u0926() {} // 0x000000018118B270-0x000000018118B300
	private void u0922u0920u0925u0922u0928u0928u0927u0928u0920u091Du091D() {} // 0x000000018118C510-0x000000018118C600
	public void u091Au0925u0922u091Fu0929u091Cu0928u0922u091Fu091Fu0921() {} // 0x000000018118A3F0-0x000000018118A480
	private void u0924u0928u0926u091Bu091Du091Cu0922u091Bu0926u0922u0920() {} // 0x000000018118D130-0x000000018118D220
	private void u091Du091Du0924u0925u0929u091Cu0928u0925u0928u0921u0923() {} // 0x000000018118AE40-0x000000018118AF30
	private void u0926u091Bu091Au0926u0928u091Eu0923u091Cu0921u0924u0922() {} // 0x000000018118D780-0x000000018118D870
	private IEnumerator u0921u091Cu0928u091Fu0926u091Du0921u091Du091Eu091Cu0926() => default; // 0x000000018118C060-0x000000018118C0D0
	private void u091Du091Bu0928u091Bu091Au091Au0921u091Du091Fu0920u091E(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118AD70-0x000000018118AD90
	private IEnumerator u091Cu091Du091Bu0926u091Bu0921u091Fu091Au0928u0925u091B() => default; // 0x000000018118A9A0-0x000000018118AA10
	private IEnumerator u091Fu0928u0929u0920u0923u0927u0920u091Bu0920u091Du0924() => default; // 0x000000018118B940-0x000000018118B9B0
	private void u091Fu091Du091Au0923u091Eu0927u0929u0928u0924u091Eu091B() {} // 0x000000018118B4C0-0x000000018118B5B0
	public void u0922u0920u0924u0925u0927u0926u0928u0928u091Eu091Bu091A() {} // 0x000000018118C480-0x000000018118C510
	public void u091Au0922u0920u091Eu0920u091Cu0921u0925u0928u091Fu0921() {} // 0x000000018118A260-0x000000018118A2F0
	public void u0924u0923u091Fu091Du0924u0921u091Fu0923u091Au0922u0929() {} // 0x000000018118CF00-0x000000018118CF90
	private void u0921u0921u0925u0921u091Fu091Cu0928u0922u0925u0927u0925(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118C1C0-0x000000018118C1E0
	private void u0928u091Bu0922u091Au0928u0927u091Du0921u0928u0929u0921(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B4A0-0x000000018118B4C0
	private IEnumerator u091Eu0921u091Bu0926u091Eu091Du0924u0928u091Fu0922u0927() => default; // 0x000000018118B110-0x000000018118B180
	private void u0927u091Cu0921u0924u0928u0929u0928u091Cu0920u0923u091E(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DB00-0x000000018118DB20
	private void u0929u0929u0924u091Du0923u0923u0924u0924u0923u0924u0929() {} // 0x000000018118E640-0x000000018118E740
	private IEnumerator u0928u0921u0921u091Du0927u0924u0929u091Bu0923u0922u091B() => default; // 0x000000018118E180-0x000000018118E1F0
	private void Awake() {} // 0x0000000181189EF0-0x000000018118A020
	private void u091Bu0927u0924u0925u091Cu0925u091Cu0925u0925u0927u0929(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118A910-0x000000018118A930
	private void u0928u0927u0924u0928u0923u091Eu0925u0920u0920u091Bu091B() {} // 0x000000018118E330-0x000000018118E420
	private void u0927u0927u0928u0921u0929u091Au0929u091Fu0920u0921u0922(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118E040-0x000000018118E060
	private void u0925u0924u091Eu0927u091Bu091Cu0921u0929u091Du091Cu0921() {} // 0x000000018118D4A0-0x000000018118D590
	public void u0924u0921u0922u0921u0928u0922u0920u091Bu091Au091Bu0928() {} // 0x000000018118CD80-0x000000018118CE10
	public void u091Au0923u0927u0928u0925u091Au0924u0921u0922u0920u091D() {} // 0x000000018118A360-0x000000018118A3F0
	private void u0920u091Eu091Fu0923u0920u091Du0921u0929u0923u091Du091B(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118BB10-0x000000018118BB30
	public void u091Fu091Fu091Eu0921u0921u0928u091Fu0928u091Cu0925u0922() {} // 0x000000018118B630-0x000000018118B6C0
	private void u0925u091Au091Fu0926u091Au0920u091Fu0924u091Cu091Du0925(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118CA10-0x000000018118CA30
	public void u0928u091Fu0922u091Cu091Bu091Bu0921u0926u0922u091Fu0922() {} // 0x000000018118E0F0-0x000000018118E180
	private void u0920u091Cu0926u091Au0929u0924u0922u0920u0920u091Cu091D() {} // 0x000000018118BA20-0x000000018118BB10
	private void u0920u0924u0925u0928u091Eu0920u091Cu0922u091Eu0925u0926() {} // 0x000000018118BCC0-0x000000018118BDB0
	private void u0926u0928u0920u0925u0923u091Bu0928u0922u0925u0926u0929(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DAB0-0x000000018118DAD0
	public void u091Fu0924u091Du0926u0928u0922u091Eu091Eu0927u0928u0926() {} // 0x000000018118B7C0-0x000000018118B850
	private void u091Cu0925u091Fu0924u0929u0927u0922u091Eu0929u0922u0929() {} // 0x000000018118ABF0-0x000000018118ACE0
	private void u0927u091Fu0925u091Fu0923u0920u0921u0928u091Bu091Cu0929() {} // 0x000000018118DC30-0x000000018118DD30
	private IEnumerator u091Bu0929u0920u091Au091Au0924u091Cu091Eu091Au0926u091D() => default; // 0x000000018118A930-0x000000018118A9A0
	private void u091Eu0928u0924u091Du091Fu091Au0928u0922u091Cu0929u0926() {} // 0x000000018118B3B0-0x000000018118B4A0
	private IEnumerator u0920u091Cu091Bu0926u0920u0923u0927u091Bu091Du0925u091E() => default; // 0x000000018118B9B0-0x000000018118BA20
	private void u0924u0922u0928u0922u0921u0924u0928u0922u091Cu0929u091E() {} // 0x000000018118CE10-0x000000018118CF00
	public void u091Du0928u0926u0925u0929u0928u091Du091Bu091Bu0924u0927() {} // 0x000000018118B050-0x000000018118B0E0
	private void u091Cu0926u091Eu0928u091Eu0927u0924u091Fu0929u0928u0925(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118ACE0-0x000000018118AD00
	private void u0923u0928u0923u091Au091Au0926u0928u091Au0922u0925u091B() {} // 0x000000018118CB30-0x000000018118CC20
	private void u0928u0928u0927u0929u0922u0922u091Cu091Cu0920u0925u0922(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118E490-0x000000018118E4B0
	private void u091Cu0922u0924u091Fu091Au091Au0920u0920u091Cu0920u0929() {} // 0x000000018118AA80-0x000000018118AB80
	private IEnumerator u0920u0921u0920u091Cu0921u0924u0925u0924u0927u091Au0921() => default; // 0x000000018118BB30-0x000000018118BBA0
	public void u091Du0922u0923u091Cu091Bu0924u091Du0924u0923u0928u0927() {} // 0x000000018118AFC0-0x000000018118B050
	private IEnumerator u091Du091Eu091Cu0929u091Fu0921u091Du0929u0929u091Eu0928() => default; // 0x000000018118AF30-0x000000018118AFA0
	private void u0921u0928u0928u091Bu0922u0926u091Fu091Bu0928u091Du0923(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118C300-0x000000018118C320
	private void u0923u091Bu091Au091Du0921u0925u091Du091Eu091Bu0929u0926() {} // 0x000000018118C800-0x000000018118C8F0
	private void u0926u091Fu091Du091Bu091Au091Fu0922u091Cu0924u0927u0920() {} // 0x000000018118D990-0x000000018118DA90
	private void u0928u0924u0925u091Fu0929u0922u091Bu0926u0927u0920u0923(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118E1F0-0x000000018118E200
	private void u0929u0923u0929u091Eu0927u0926u0922u0923u0928u0928u0920(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118E040-0x000000018118E060
	// [IteratorStateMachine] // 0x000000018010ABD0-0x000000018010AC20
	private IEnumerator Start() => default; // 0x000000018118A0B0-0x000000018118A120
	public void u0921u0922u091Fu091Du0926u091Eu0929u0927u091Bu091Bu0924() {} // 0x000000018118C1E0-0x000000018118C270
	private IEnumerator u0922u0925u0922u091Au0923u0924u091Du0921u0920u0921u0923() => default; // 0x000000018118C700-0x000000018118C770
	public void u0924u0927u0926u091Du091Du091Bu091Fu091Bu0922u091Du0925() {} // 0x000000018118D0A0-0x000000018118D130
	public void u0925u0928u091Cu0927u0928u091Eu0922u0927u0924u0928u0922() {} // 0x000000018118D600-0x000000018118D690
	private IEnumerator u091Cu0920u091Cu0922u0921u0922u0924u091Cu0924u0920u0921() => default; // 0x000000018118AA10-0x000000018118AA80
	private void u0923u0924u0920u091Du0920u0921u0927u091Bu0920u091Du0927(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118CA10-0x000000018118CA30
	private IEnumerator u091Au091Au091Du0924u0922u091Cu0924u0925u0922u091Au0923() => default; // 0x000000018118A120-0x000000018118A190
	public void u0927u0920u0924u0920u0920u0923u0922u0925u0926u091Cu0921() {} // 0x000000018118DD30-0x000000018118DDC0
	private void u091Fu0927u091Fu0920u0921u091Fu0921u091Au091Eu091Du091A() {} // 0x000000018118B850-0x000000018118B940
	public void u091Du091Cu091Bu091Bu091Au0926u091Du0927u0922u0922u091E() {} // 0x000000018118AD90-0x000000018118AE20
	public void u0920u0923u091Du091Au091Bu091Cu0923u091Bu0925u091Fu0928() {} // 0x000000018118BC30-0x000000018118BCC0
	private IEnumerator u0922u091Bu0929u0923u091Bu0920u0926u0923u091Bu091Du091A() => default; // 0x000000018118C320-0x000000018118C390
	public void u091Eu0928u091Cu0920u0924u0924u091Fu0924u0929u0926u0921() {} // 0x000000018118B320-0x000000018118B3B0
	public void u0923u0928u0927u0920u091Cu091Bu091Bu0922u0926u0923u0929() {} // 0x000000018118CC20-0x000000018118CCB0
	public void u0922u0927u0920u0923u091Bu0923u091Bu0929u091Du091Au0924() {} // 0x000000018118C770-0x000000018118C800
	private IEnumerator u091Au0922u0925u091Bu0924u091Du0921u0920u0926u0928u0929() => default; // 0x000000018118A2F0-0x000000018118A360
	public void u091Au0928u0923u091Bu0924u091Cu091Bu0921u0928u091Fu0921() {} // 0x000000018118A580-0x000000018118A610
	private void u091Bu091Cu091Fu0920u0923u091Au0928u091Fu0922u091Eu0926() {} // 0x000000018118A680-0x000000018118A770
	public void u091Fu0920u0923u0925u091Du091Cu091Eu0929u0920u0928u0921() {} // 0x000000018118B730-0x000000018118B7C0
	private IEnumerator u0925u0920u0923u0920u0925u0926u0929u091Au0927u0923u091A() => default; // 0x000000018118D430-0x000000018118D4A0
	private void u091Eu091Fu0929u0921u0926u0925u091Du091Du0922u091Eu091E(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B100-0x000000018118B110
	private void u0922u091Cu0929u0922u091Bu091Du0923u0924u0920u0920u091B() {} // 0x000000018118C390-0x000000018118C480
	private void u0924u091Fu0925u0920u0920u0928u091Eu0928u0924u091Du091E(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B300-0x000000018118B320
	private void u091Au0921u0929u0923u091Bu0927u0920u091Fu0921u091Cu0920(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118A240-0x000000018118A260
	private void u091Au0925u0927u0922u0921u0925u091Fu091Du091Cu091Cu0922() {} // 0x000000018118A480-0x000000018118A580
	private void u091Du091Cu091Eu091Du0920u091Au091Cu0923u0927u0927u0924(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118AE20-0x000000018118AE40
	private IEnumerator u0925u0925u091Eu091Bu091Fu0928u0923u0926u091Cu0926u0922() => default; // 0x000000018118D590-0x000000018118D600
	public void u0921u0925u0922u091Fu0922u091Du0927u0925u0921u091Eu0928() {} // 0x000000018118C270-0x000000018118C300
	private void u0927u0920u0927u091Cu091Au0924u091Eu091Au0924u0921u091B() {} // 0x000000018118DDC0-0x000000018118DEB0
	private IEnumerator u0920u0927u091Eu0926u0922u0924u091Du0925u0928u0922u091A() => default; // 0x000000018118BDD0-0x000000018118BE40
	private void u0921u091Eu0928u0927u0926u091Cu0929u0928u0926u0924u0923() {} // 0x000000018118C0D0-0x000000018118C1C0
	private void u0928u0924u0925u0920u091Bu0925u0928u0924u0927u0925u091D() {} // 0x000000018118E200-0x000000018118E330
	public void u0926u091Bu091Du091Cu0920u091Du091Fu091Du0924u0928u091E() {} // 0x000000018118D870-0x000000018118D900
	private void u0927u091Eu0921u0920u0927u0928u0926u091Bu091Du0925u091B() {} // 0x000000018118DB20-0x000000018118DC10
	private void u0926u0929u0921u0921u0929u0923u091Eu0926u0929u0921u0927(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DAD0-0x000000018118DAF0
	private void u0924u0924u0921u0924u0920u0922u0929u0922u0921u091Eu0925(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118D080-0x000000018118D0A0
	private void u0927u091Fu0920u0924u0920u0925u0924u0924u091Eu0924u0927(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DC10-0x000000018118DC30
	private void u0924u091Fu0921u0923u0927u0920u0926u0929u0923u0929u091F(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118CCD0-0x000000018118CCF0
	public void u0923u0921u0927u0922u0924u0925u0922u091Au0920u0921u091E() {} // 0x000000018118C980-0x000000018118CA10
	private void u0927u0927u0922u091Cu091Bu0929u091Bu0920u0923u0925u0921() {} // 0x000000018118DF40-0x000000018118E040
	private IEnumerator u091Fu091Fu0921u0928u0921u0926u0928u0920u0921u0922u0924() => default; // 0x000000018118B6C0-0x000000018118B730
	private void u0923u0927u091Au091Cu091Cu091Bu091Au0926u091Bu0929u0923() {} // 0x000000018118CA30-0x000000018118CB30
	public void u0922u0923u091Fu091Fu0926u0929u091Du0924u091Fu0925u0927() {} // 0x000000018118C600-0x000000018118C690
	private void u0920u0924u0926u0928u0926u091Bu0922u091Eu0924u0924u0928(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118BDB0-0x000000018118BDD0
	private void u0920u0927u0925u091Bu0928u0926u091Eu0926u0922u091Au0929() {} // 0x000000018118BE40-0x000000018118BF30
	private IEnumerator u091Cu0924u091Fu091Eu091Bu0925u0920u0922u091Cu0922u091A() => default; // 0x000000018118AB80-0x000000018118ABF0
	private void u0925u0928u0920u0924u0927u0920u0923u091Bu091Au0927u0923() {} // 0x000000018118D690-0x000000018118D780
	public void u091Au0920u0929u0928u091Bu0925u091Bu091Eu0921u0921u0924() {} // 0x000000018118A1B0-0x000000018118A240
	private void u0927u091Au091Du091Eu0921u0925u0920u0925u091Au0926u0928(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118DAF0-0x000000018118DB00
	private void u0924u091Bu0924u0922u0921u091Du0928u091Eu091Fu0925u091D(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118CCB0-0x000000018118CCD0
	private IEnumerator u091Cu0928u0928u0924u0922u0925u0923u0925u091Fu091Au0925() => default; // 0x000000018118AD00-0x000000018118AD70
	private IEnumerator u0927u0926u0923u091Fu0927u091Cu0927u0921u0928u091Eu0921() => default; // 0x000000018118DED0-0x000000018118DF40
	private void u091Du0929u091Au0923u0925u0926u0926u091Eu0922u0924u0922(int u0924u091Cu0929u091Cu0923u0929u0927u0929u0926u0922u0926, int u0923u0924u091Bu091Cu091Cu091Au0924u091Du0921u0924u091E) {} // 0x000000018118B0E0-0x000000018118B100
	private IEnumerator u091Au0929u091Au0928u0921u0925u0924u091Eu0922u091Fu091E() => default; // 0x000000018118A610-0x000000018118A680
}

