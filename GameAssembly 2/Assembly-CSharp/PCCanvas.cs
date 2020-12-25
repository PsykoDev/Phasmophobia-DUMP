﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class PCCanvas : MonoBehaviour // TypeDefIndex: 7182
{
	// Fields
	public Image u091Au0924u0921u0920u091Eu0921u0923u091Au0926u0924u091E; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Sprite normalSprite; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Sprite lockSprite; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Sprite lightSprite; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Player player; // 0x38
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public bool u0922u0929u0920u0920u0926u091Fu0922u0925u0920u091Cu0929; // 0x40
	private Color32 u0923u0924u091Eu0927u091Au0926u0922u091Au091Eu0923u0920; // 0x44
	private Color32 u0922u0921u0920u0921u0925u0928u0922u091Eu091Cu091Bu091A; // 0x48
	public GameObject u0923u091Cu0923u091Au0922u091Eu0926u0925u091Cu0927u091F; // 0x50
	private Vector3 u0929u0925u0926u0927u091Cu091Bu0927u0921u091Bu0929u0922; // 0x58
	private string u0927u0920u0926u0929u0922u0922u0921u091Bu091Eu0929u0926; // 0x68
	public u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925; // 0x70

	// Nested types
	public enum u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F // TypeDefIndex: 7183
	{
		none = 0,
		active = 1,
		locked = 2,
		light = 3
	}

	// Constructors
	public PCCanvas() {} // 0x0000000181028580-0x00000001810285E0

	// Methods
	private void u091Fu0926u091Au0923u091Bu0926u091Bu0928u0921u0923u091A() {} // 0x0000000181021B40-0x0000000181021CB0
	public void u0927u0922u091Cu0923u091Cu0921u0921u091Au091Eu0924u091B(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181026B60-0x0000000181026E00
	private void u091Bu091Bu0925u0928u0924u0925u0924u0920u091Eu0925u0925() {} // 0x000000018101FAB0-0x000000018101FC20
	public void SetState(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x000000018101ED70-0x000000018101F010
	public void u0927u0924u091Fu0921u0924u0926u0924u0924u0921u091Du091B() {} // 0x0000000181026E00-0x0000000181026F20
	public void u0925u0925u0923u0929u0921u0927u0924u0929u091Du091Cu091D() {} // 0x0000000181025E40-0x0000000181025FB0
	public void u0921u091Fu0928u091Eu0928u0929u0920u0923u091Eu0925u0924() {} // 0x0000000181023210-0x0000000181023330
	public void u0927u0929u0924u0921u091Cu0923u091Bu091Cu091Du091Cu0924(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181026FA0-0x0000000181027240
	private void u0929u091Bu0926u091Cu091Bu0920u091Cu0926u091Eu0926u0925() {} // 0x0000000181027C80-0x0000000181027DF0
	public void u0926u091Cu091Fu0923u0926u0929u0928u0926u0928u0925u0921() {} // 0x0000000181026470-0x0000000181026600
	public void u0922u091Fu0927u0925u091Au0923u091Au0926u0928u091Cu091A(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x00000001810239A0-0x0000000181023C40
	private void u0926u091Au0922u091Au0925u0921u0921u0923u0922u0924u0927() {} // 0x0000000181026300-0x0000000181026470
	private void u091Bu0925u091Eu0920u091Bu091Du091Du0927u0924u0922u0924() {} // 0x000000018101FFA0-0x0000000181020110
	private void u0920u091Au0921u091Cu0925u0921u0923u0920u0925u091Au0920() {} // 0x0000000181021FD0-0x00000001810221B0
	private void u091Bu0926u0927u091Fu091Au091Du0920u091Bu091Au091Bu0929() {} // 0x0000000181020110-0x0000000181020280
	public void u0922u091Bu0928u0928u0925u091Cu091Bu0929u0920u0923u0927() {} // 0x0000000181023790-0x0000000181023920
	public void u0929u0926u0927u0925u091Eu091Au0929u091Au0925u0925u091F() {} // 0x00000001810281C0-0x00000001810282E0
	public void u0926u091Au091Cu0927u0921u0920u0925u091Eu0920u0928u0921() {} // 0x0000000181026120-0x0000000181026300
	public void u091Bu091Cu0927u0927u0924u0923u091Eu0920u0924u0929u0927() {} // 0x000000018101FC20-0x000000018101FE00
	public void u0924u091Eu0921u0923u0924u091Bu091Du091Fu091Au091Au091C(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181024E50-0x0000000181024ED0
	private void u0928u0920u091Fu091Du0925u0927u0926u0924u0928u091Cu091A() {} // 0x0000000181027590-0x0000000181027700
	public void u0922u0921u0927u0922u0926u0920u0924u0922u0928u0926u0924(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181023C40-0x0000000181023EE0
	private void u0925u0929u0926u091Au0921u091Fu091Au0926u0928u0925u0928() {} // 0x0000000181025FB0-0x0000000181026120
	public void u0929u0925u0923u091Cu091Du0928u0921u0927u0929u0926u0928() {} // 0x0000000181027FE0-0x00000001810281C0
	public void u0926u0925u091Au0927u0923u0923u091Eu091Fu091Au0927u0925(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x00000001810269C0-0x0000000181026A40
	public void u0929u0921u091Cu0924u0921u0927u0925u091Au0926u0924u0925(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181027F60-0x0000000181027FE0
	private void u091Du0922u091Au0926u0925u0926u091Bu091Eu0928u0928u091B() {} // 0x0000000181020C80-0x0000000181020DF0
	public void u091Eu0920u0921u0924u091Cu0929u091Eu0922u091Eu091Du0922() {} // 0x0000000181020FE0-0x0000000181021100
	public void u0923u0929u0922u0921u0921u0926u0927u0925u0923u0927u0925() {} // 0x0000000181024C90-0x0000000181024E50
	public void u0927u091Eu0920u091Fu0929u091Eu091Eu091Eu091Bu091Cu091C() {} // 0x0000000181026A40-0x0000000181026B60
	public void u091Eu0925u091Bu091Bu0923u0920u0922u0928u0925u0927u091E(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x00000001810212F0-0x0000000181021590
	public void u0923u0922u0921u0921u0922u0924u091Cu0929u0922u0928u091C(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x00000001810247A0-0x0000000181024820
	public void u0922u091Eu0929u0928u091Fu0922u0925u0926u0920u091Bu0925(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181023920-0x00000001810239A0
	public void u0925u091Eu0928u091Au091Eu0924u091Fu0926u091Cu0922u091E() {} // 0x00000001810253C0-0x00000001810254E0
	public void u0921u0921u0925u0926u0928u091Du091Du091Bu0923u091Fu091A() {} // 0x0000000181023330-0x0000000181023530
	private void u091Cu0924u091Fu091Eu091Bu0925u0920u0922u091Cu0922u091A() {} // 0x0000000181020A10-0x0000000181020C00
	private void u0920u0924u0920u0926u0926u0920u0923u091Fu0929u091Du091F() {} // 0x00000001810225F0-0x0000000181022760
	private void u091Cu0920u0929u0921u0922u0922u0921u0925u091Bu0926u091F() {} // 0x0000000181020730-0x00000001810208A0
	public void u091Bu0929u0920u0924u091Au0920u0920u0927u0921u0923u0927(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x00000001810203A0-0x0000000181020640
	private void u0920u091Cu091Bu0926u0920u0923u0927u091Bu091Du0925u091E() {} // 0x00000001810221B0-0x0000000181022390
	public void u0925u091Fu091Cu0920u0921u0925u0928u0920u0929u091Au0928() {} // 0x00000001810254E0-0x0000000181025660
	public void u0929u091Du091Cu0924u0928u091Bu0927u091Bu091Du091Au091E(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181027EE0-0x0000000181027F60
	public void u0928u0924u0928u0921u0924u0924u0923u091Du0925u0928u0926() {} // 0x00000001810279A0-0x0000000181027B10
	public void u0923u091Au0928u0924u091Eu091Du091Fu0922u091Au091Du0927() {} // 0x0000000181023EE0-0x00000001810240C0
	private void u0920u0921u0920u091Cu0921u0924u0925u0924u0927u091Au0921() {} // 0x0000000181022410-0x00000001810225F0
	public void u091Bu091Au0929u0927u0921u0922u0922u0925u0927u091Du0925() {} // 0x000000018101F7B0-0x000000018101F8D0
	public void u091Fu0927u091Cu0920u0927u0929u0928u0927u091Eu091Au0928(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181021D30-0x0000000181021FD0
	public void u0923u0920u0924u0927u0927u091Fu0925u091Bu0929u0924u0929() {} // 0x00000001810243A0-0x00000001810244C0
	public void u0927u0925u0920u091Eu091Bu091Fu0926u091Cu091Fu0926u0922(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181026F20-0x0000000181026FA0
	private void u0923u0926u0927u0928u0923u0927u091Au091Fu0924u0921u0920() {} // 0x0000000181024990-0x0000000181024B70
	public void u0925u0924u0922u0920u091Du0921u0926u0922u0929u091Au091B(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181025900-0x0000000181025BA0
	private void u091Bu091Bu0923u091Bu091Fu0924u0924u0929u0927u0929u091A() {} // 0x000000018101F8D0-0x000000018101FAB0
	public void u0921u0925u091Au0928u0924u091Cu091Bu0926u091Eu0925u0928(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181023530-0x00000001810235B0
	public void u0924u091Eu0922u0929u0922u0926u091Bu0929u0928u0925u0928() {} // 0x0000000181024ED0-0x0000000181024FF0
	private void u0923u091Eu091Bu0923u091Au0921u0923u0929u091Cu0924u091E() {} // 0x00000001810240C0-0x0000000181024230
	public void u091Eu0925u0926u091Bu091Eu091Fu0923u091Cu091Fu0921u0923(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181021590-0x0000000181021610
	public void u091Bu091Du0927u0921u091Bu0929u091Au0927u091Cu0923u0923() {} // 0x000000018101FE00-0x000000018101FF20
	public void u0923u0921u0928u0929u091Eu091Cu091Eu091Du0920u0929u0927() {} // 0x00000001810245E0-0x00000001810247A0
	public void u091Fu091Eu0929u0929u0927u091Eu0927u091Bu0924u0921u0927() {} // 0x0000000181021610-0x0000000181021780
	public void u0920u0920u0921u0923u0926u091Bu091Du091Fu0923u091Au091A(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181022390-0x0000000181022410
	private void Start() {} // 0x000000018101F010-0x000000018101F100
	public void u0925u0920u0922u0923u091Eu0923u0923u091Eu0928u0922u091F(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181025660-0x0000000181025900
	private void u0923u0926u091Eu0926u0925u0922u091Fu091Fu0925u0923u0925() {} // 0x0000000181024820-0x0000000181024990
	private void u0928u091Eu0924u0928u0928u0922u0929u091Fu0921u0926u091C() {} // 0x0000000181027240-0x00000001810273B0
	public void u0926u091Eu0929u0926u091Au0926u091Au0922u091Eu091Bu091C(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181026600-0x00000001810268A0
	public void u091Du091Du091Cu091Cu0924u091Bu091Cu0926u0921u091Cu0925(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181020C00-0x0000000181020C80
	private void u091Cu091Du091Bu0926u091Bu0921u091Fu091Au0928u0925u091B() {} // 0x0000000181020640-0x0000000181020730
	public void u0925u091Du0929u091Fu0921u091Bu0924u091Du0922u091Bu0922(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181025340-0x00000001810253C0
	public void OnControlSchemeChanged() {} // 0x000000018101E980-0x000000018101EB10
	public void u091Fu0923u091Cu0924u0929u0920u0924u0921u091Fu0927u0929() {} // 0x0000000181021A20-0x0000000181021B40
	public void u091Bu0920u091Du0923u091Cu0924u0928u0928u091Fu0922u0929(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x000000018101FF20-0x000000018101FFA0
	public void u0926u0923u0923u0926u0921u0927u0928u0927u0923u091Du0925() {} // 0x00000001810268A0-0x00000001810269C0
	public void u0925u0925u091Au0924u091Au0922u0929u0921u0926u0925u0927(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181025BA0-0x0000000181025E40
	public void u091Au0920u0922u0923u091Du0929u091Bu0921u091Cu0926u091C() {} // 0x000000018101F2F0-0x000000018101F4D0
	public void u0923u0921u0925u0925u0922u0925u0921u091Bu0925u0922u0925() {} // 0x00000001810244C0-0x00000001810245E0
	public void u091Fu0927u091Au0923u091Eu091Cu0929u091Au0926u0929u0924(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181021CB0-0x0000000181021D30
	public void UpdateCursorBrightness() {} // 0x00000001810282E0-0x0000000181028410
	private void u091Au0928u091Au091Bu091Cu091Fu0922u091Du0925u0925u091A() {} // 0x000000018101F640-0x000000018101F7B0
	private void u091Eu091Bu0928u0924u0925u0920u0921u0926u0920u0925u0925() {} // 0x0000000181020DF0-0x0000000181020FE0
	public void u091Fu0920u0926u0924u091Bu091Fu0928u0926u091Eu0927u0920(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181021780-0x0000000181021A20
	public void u0923u0928u0926u0921u0927u0920u091Fu0921u0922u091Au091A() {} // 0x0000000181024B70-0x0000000181024C90
	private void u0929u091Au0929u0922u091Bu0927u0921u0921u0922u091Cu0929() {} // 0x0000000181027B10-0x0000000181027C80
	public void u091Bu0928u091Bu0925u0927u0928u0924u0927u0922u0921u0925() {} // 0x0000000181020280-0x00000001810203A0
	private void u0929u091Cu091Eu0925u091Au0921u0922u0925u091Bu091Au091D() {} // 0x0000000181027DF0-0x0000000181027EE0
	private void u091Cu0921u0923u0928u0926u0929u0924u0927u0920u0921u0922() {} // 0x00000001810208A0-0x0000000181020A10
	private void u0921u091Eu0925u091Cu091Bu0927u0925u091Au0922u0929u091F() {} // 0x00000001810230A0-0x0000000181023210
	public void u0920u0925u091Cu0926u0924u0927u0926u091Cu0920u091Cu091E(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181022760-0x0000000181022A00
	private void u0923u091Fu091Au0923u0928u091Fu0928u0926u0920u0921u0920() {} // 0x0000000181024230-0x00000001810243A0
	private void u0921u091Cu0920u0929u0926u091Du0921u091Au0921u0923u0923() {} // 0x0000000181022B20-0x0000000181022E00
	public void Pause() {} // 0x000000018101EB90-0x000000018101ED70
	public void u091Au0926u091Au0921u091Cu091Fu091Au091Au0927u0923u0926(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x000000018101F5C0-0x000000018101F640
	private void u091Au091Du0925u0928u0925u091Fu0923u0920u0928u0925u0929() {} // 0x000000018101F100-0x000000018101F2F0
	public void u0921u091Du091Fu091Fu0924u091Du0923u0923u091Au091Au091A(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181022E00-0x00000001810230A0
	public void u0928u0923u091Bu0929u091Bu0926u091Au091Au091Eu091Du0921(u0920u0924u0920u0926u0921u091Fu0929u091Bu091Fu0927u091F u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, bool u0929u0927u0926u091Au091Cu0928u091Fu091Au0926u0928u0925 = default) {} // 0x0000000181027700-0x00000001810279A0
	private void u0924u0921u0928u0921u0926u091Au091Du0929u091Cu0920u091E() {} // 0x0000000181024FF0-0x0000000181025160
	public void u0924u0925u0922u0926u0920u0923u0929u091Du091Du0923u0920() {} // 0x0000000181025160-0x0000000181025340
	public void OnPause(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x000000018101EB10-0x000000018101EB90
	private void u091Au0922u0923u0927u0924u0921u091Fu0922u0921u091Fu0921() {} // 0x000000018101F4D0-0x000000018101F5C0
	private void Update() {} // 0x0000000181028410-0x0000000181028580
	private void u091Eu0921u091Bu0926u091Eu091Du0924u0928u091Fu0922u0927() {} // 0x0000000181021100-0x00000001810212F0
	private void u0928u091Eu0927u091Cu091Eu091Fu091Du0927u091Au0928u0922() {} // 0x00000001810273B0-0x0000000181027590
	public void u0920u0928u0928u0927u091Cu0929u0926u0922u0924u091Du0927() {} // 0x0000000181022A00-0x0000000181022B20
	public void u0921u0927u0929u0923u091Eu0923u0926u091Au0921u0921u0926() {} // 0x00000001810235B0-0x0000000181023790
}
