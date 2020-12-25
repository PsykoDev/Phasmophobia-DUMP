﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
	public class VRTK_RadialMenu : MonoBehaviour // TypeDefIndex: 7464
	{
		// Fields
		public List<RadialMenuButton> u0922u0929u091Cu0920u0923u0925u091Au091Au0923u0924u0929; // 0x18
		public GameObject u0925u0923u0929u0927u0920u091Bu091Bu0924u0923u0920u0920; // 0x20
		public bool u091Du0922u0927u0924u0923u0929u0924u0927u091Fu0923u0926; // 0x28
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float u0922u0922u091Bu091Fu091Du0920u0922u0929u0927u0926u0922; // 0x2C
		public Color u0922u091Fu0923u0920u0928u0928u091Bu0927u091Bu0924u0926; // 0x30
		public float u0921u091Du091Du0923u091Bu0923u091Cu091Du091Eu091Au0926; // 0x40
		// [Range] // 0x00000001800D6BF0-0x00000001800D6C10
		public float u0922u0925u0921u091Bu0926u0928u0926u091Cu0921u0924u091A; // 0x44
		public bool u091Bu0922u0928u091Au091Fu0920u0922u091Bu0927u0928u091B; // 0x48
		public float u091Cu091Cu0920u0922u091Du0924u0928u0920u0928u091Fu091B; // 0x4C
		public bool u091Fu091Eu091Eu091Cu091Cu0929u091Eu091Cu091Bu0921u0926; // 0x50
		public bool u091Eu0920u0920u0924u091Bu091Au0926u0925u0928u091Cu0929; // 0x51
		public bool u0928u0924u0920u091Eu091Bu091Bu091Fu0929u0921u0925u0925; // 0x52
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float u0927u0922u091Au0924u0923u0924u091Cu0922u0921u091Fu091D; // 0x54
		public List<GameObject> u091Eu0927u0927u0925u091Fu0923u0922u0929u0926u0928u0924; // 0x60
		protected int u091Eu0925u091Fu0929u091Eu0923u0924u0928u091Fu091Fu091B; // 0x68
		protected int u0927u0921u0924u0927u091Du0925u0929u0928u0926u091Cu0925; // 0x6C
	
		// Events
		public event u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0926u0924u0922u0925u0924u091Fu091Fu091Eu091Bu0925u0920;
	
		// Nested types
		[Serializable]
		public class RadialMenuButton // TypeDefIndex: 7465
		{
			// Fields
			public Sprite ButtonIcon; // 0x10
			public UnityEvent OnClick; // 0x18
			public UnityEvent OnHold; // 0x20
			public UnityEvent OnHoverEnter; // 0x28
			public UnityEvent OnHoverExit; // 0x30
	
			// Constructors
			public RadialMenuButton() {} // 0x00000001817C6110-0x00000001817C61F0
		}
	
		public enum u091Cu0927u0924u091Bu0923u0927u0929u091Cu0927u0921u0929 // TypeDefIndex: 7466
		{
			hoverOn = 0,
			hoverOff = 1,
			click = 2,
			unclick = 3
		}
	
		// Constructors
		public VRTK_RadialMenu() {} // 0x00000001817D8B40-0x00000001817D8B90
	
		// Methods
		public virtual void u0927u0926u091Bu091Fu091Bu0923u091Fu091Fu091Eu0923u091B() {} // 0x00000001817D7990-0x00000001817D7A10
		public void u0926u0921u091Fu091Du0925u091Bu091Du0920u091Bu091Fu0920(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D7350-0x00000001817D73B0
		public virtual void ClickButton(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D22A0-0x00000001817D22C0
		public virtual void u0924u0926u091Eu091Au091Eu0921u091Eu091Au091Au091Eu091E(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D60B0-0x00000001817D60D0
		public virtual void u0928u091Eu0923u0924u0920u091Cu0928u091Bu0924u0929u0920(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D7BF0-0x00000001817D7C80
		public virtual void u0927u091Cu0926u0927u0926u0927u0920u091Eu0925u0927u0924(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D76C0-0x00000001817D76E0
		public virtual void u0929u0923u0924u0924u091Du0924u0926u0925u0920u0928u091E() {} // 0x00000001817D8860-0x00000001817D8890
		public virtual RadialMenuButton u091Fu0924u0928u0924u091Au0923u091Du0923u0928u091Cu0921(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D5020-0x00000001817D50A0
		public virtual RadialMenuButton u0928u0920u0926u0928u0924u0920u0922u0928u0929u0925u0926(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D7DC0-0x00000001817D7E40
		public void u0925u091Au0921u091Eu0927u091Eu0922u0923u0926u0923u0923() {} // 0x00000001817D60D0-0x00000001817D6AF0
		public virtual void u0924u091Cu0929u0926u0928u091Au0927u0927u0920u091Cu0922(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D5EE0-0x00000001817D5F70
		public virtual void u0920u0920u091Eu091Fu091Bu0926u091Au0921u0920u091Eu0928(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D50E0-0x00000001817D5100
		public virtual void u091Du0929u0920u091Fu0925u091Eu0926u0929u0922u0924u0925() {} // 0x00000001817D4230-0x00000001817D42B0
		public virtual void u0927u0928u0924u0926u0924u091Eu0928u091Eu091Fu0924u0922(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D7B40-0x00000001817D7BD0
		public void u0920u0922u0923u091Du091Fu091Au091Au0924u0925u0923u0924(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D5100-0x00000001817D51A0
		public virtual void u0929u0927u091Eu0920u091Du0924u091Cu0920u091Au091Fu0929() {} // 0x00000001817D8890-0x00000001817D8A20
		public virtual void u091Fu091Bu0921u0920u0921u0929u0921u0920u0928u0925u0921(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D5000-0x00000001817D5020
		public virtual void u0920u0928u0924u0925u091Bu0926u091Cu091Fu0923u091Du091A(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D51A0-0x00000001817D5230
		protected virtual void u091Cu091Fu0923u0924u091Cu0926u0922u091Au0920u0920u091A() {} // 0x00000001817D3870-0x00000001817D3930
		public virtual void u0927u0925u0926u0920u0925u091Bu0920u0924u0929u0920u0924() {} // 0x00000001817D7910-0x00000001817D7990
		protected virtual void u091Du091Fu0928u0923u0921u0927u091Au0926u0923u0925u091B() {} // 0x00000001817D3B80-0x00000001817D3C00
		public void u091Cu091Du0921u091Au0924u0922u0921u091Au0925u0921u091A(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D3790-0x00000001817D37F0
		public virtual RadialMenuButton u0923u091Cu0926u091Eu0929u0928u0928u0926u0922u091Bu091D(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D5760-0x00000001817D57E0
		protected virtual void u0926u0928u0928u0927u091Cu0927u0927u0929u091Au0928u091F() {} // 0x00000001817D74B0-0x00000001817D75C0
		protected virtual void Update() {} // 0x00000001817D8AC0-0x00000001817D8B40
		public virtual void u0922u0929u091Cu091Du0922u0923u0926u0922u0923u0927u0929(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D50E0-0x00000001817D5100
		public virtual RadialMenuButton GetButton(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D22C0-0x00000001817D2340
		public virtual RadialMenuButton u0926u091Bu0925u0922u091Fu0927u0927u0920u0927u0922u091F(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D7210-0x00000001817D7290
		public virtual void u0925u0924u0923u091Du091Eu0924u0920u0920u0922u0921u0924(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D7100-0x00000001817D7190
		public virtual void u0926u0926u0921u0924u091Du0929u0925u0925u0921u0927u091C(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D22A0-0x00000001817D22C0
		public virtual void u091Au0929u091Eu091Fu091Cu0929u0929u0927u0922u091Fu091D(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D3170-0x00000001817D3190
		public virtual void StopTouching() {} // 0x00000001817D2E50-0x00000001817D2FE0
		public virtual void u091Du0921u0927u091Eu0921u091Du0924u091Au091Au091Bu0926(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x0000000180775560-0x0000000180775580
		protected virtual void u0925u0929u0925u091Au091Eu0923u0929u0922u0924u091Au0922() {} // 0x00000001817D7190-0x00000001817D7210
		public virtual void HideMenu(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D2340-0x00000001817D23D0
		public virtual void HoverButton(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x0000000180775560-0x0000000180775580
		public virtual void ShowMenu() {} // 0x00000001817D2DD0-0x00000001817D2E50
		public virtual void u091Cu0928u0924u091Au0929u0929u091Eu0920u0926u0924u0924(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D3B60-0x00000001817D3B80
		public void u0928u0922u091Eu091Du0921u0928u091Cu091Cu091Eu0929u0926() {} // 0x00000001817D7E40-0x00000001817D8860
		public virtual void u0925u091Fu091Cu0927u091Au0928u0925u0925u091Du0927u0920() {} // 0x00000001817D5800-0x00000001817D5830
		public void u091Cu0921u091Eu091Eu0926u0927u0928u091Au091Eu0929u091A(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D3930-0x00000001817D39D0
		public void u091Eu0928u0928u0926u091Du0927u091Bu0920u091Fu091Bu0920() {} // 0x00000001817D4550-0x00000001817D4F70
		protected virtual IEnumerator u0927u091Au0924u0922u091Bu0925u0920u0924u0926u0924u0927(bool u091Eu0923u091Cu091Cu091Bu091Cu091Bu091Cu091Cu091Bu0928) => default; // 0x00000001817D7640-0x00000001817D76C0
		public virtual RadialMenuButton u091Cu091Fu091Fu091Fu091Eu091Fu091Bu0924u091Du0929u0922(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D37F0-0x00000001817D3870
		public virtual void u0923u0924u0927u0923u0928u091Du0925u0923u0929u091Fu0920(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D5830-0x00000001817D5850
		public virtual void u0926u0921u0928u0924u0926u0924u0923u091Bu091Fu0923u091D() {} // 0x00000001817D73B0-0x00000001817D7430
		public virtual void u0928u091Du0920u091Du0925u091Eu091Du0925u0929u091Cu0925(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D7BD0-0x00000001817D7BF0
		public void u091Au091Du0922u091Eu091Bu0923u091Du091Cu0929u091Au091D(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D3010-0x00000001817D30B0
		public virtual void u091Au0923u0920u0921u091Bu0920u091Cu091Au0928u0922u091C(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D30B0-0x00000001817D30D0
		public virtual void ToggleMenu() {} // 0x00000001817D2FE0-0x00000001817D3010
		protected virtual void u0924u0925u091Eu0926u091Fu0924u0921u0920u0927u0927u0920() {} // 0x00000001817D6010-0x00000001817D6090
		protected virtual IEnumerator u0923u0926u0929u0920u0920u0921u0929u091Au091Cu0929u0924(bool u091Eu0923u091Cu091Cu091Bu091Cu091Bu091Cu091Cu091Bu0928) => default; // 0x00000001817D5850-0x00000001817D58D0
		public virtual void u0923u0924u0924u091Cu091Du0922u0924u0924u0927u0929u0926() {} // 0x00000001817D5800-0x00000001817D5830
		public void AddButton(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D2180-0x00000001817D21E0
		public void u0928u091Eu0924u0929u0922u091Fu0920u091Cu0924u091Fu091B(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D7C80-0x00000001817D7CE0
		protected virtual void u0925u0921u0928u0922u0928u0926u091Au0921u0925u091Au091B(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922, u091Cu0927u0924u091Bu0923u0927u0929u091Cu0927u0921u0929 u091Cu091Bu091Du0929u0929u0926u0923u091Fu0926u091Eu0927) {} // 0x00000001817D6BB0-0x00000001817D7100
		protected virtual void u091Bu0924u0929u091Au0924u091Eu091Du091Eu0920u0922u0922(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922, u091Cu0927u0924u091Bu0923u0927u0929u091Cu0927u0921u0929 u091Cu091Bu091Du0929u0929u0926u0923u091Fu0926u091Eu0927) {} // 0x00000001817D32C0-0x00000001817D3770
		public virtual void u0923u091Au0924u0926u0921u0929u0925u091Cu0928u0921u0929() {} // 0x00000001817D5690-0x00000001817D56C0
		protected virtual void Awake() {} // 0x00000001817D21E0-0x00000001817D22A0
		public virtual RadialMenuButton u091Au0928u0920u0925u091Fu0926u091Au091Au0920u091Fu0925(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D30F0-0x00000001817D3170
		protected virtual void u0924u091Cu0924u091Bu0926u0928u0922u0921u091Fu0926u0927() {} // 0x00000001817D5E60-0x00000001817D5EE0
		protected virtual void u0928u0920u091Au091Du0923u091Du0924u091Du0925u0923u0920(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D7DA0-0x00000001817D7DC0
		public void u0922u091Au091Cu0924u091Cu091Au0922u091Cu0925u091Bu0926(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D5630-0x00000001817D5690
		public void u0927u091Eu0924u0924u091Cu0923u0923u091Bu091Au091Cu0926(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D76E0-0x00000001817D7780
		public void u091Du0927u0925u091Eu0926u091Du0920u0920u0927u0925u0928(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D3C20-0x00000001817D3CC0
		protected virtual void u091Cu0926u0925u091Bu0926u091Du0921u0922u091Bu091Du091F() {} // 0x00000001817D3A50-0x00000001817D3B60
		public void u091Eu091Au091Cu091Fu0927u0926u0924u091Du091Cu091Cu0923(RadialMenuButton u0920u091Eu0920u0926u091Au0928u091Bu091Bu0922u091Bu0923) {} // 0x00000001817D42B0-0x00000001817D4310
		public virtual void u0921u0920u0925u091Cu0924u0924u0921u091Bu091Du0921u091F(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D5440-0x00000001817D5460
		protected virtual void u091Fu0927u0927u0920u0927u091Du091Au0920u0925u091Bu091B(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D50A0-0x00000001817D50C0
		public void u0924u091Fu091Fu0923u0922u091Bu0925u0928u091Fu0927u091E(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D5F70-0x00000001817D6010
		public virtual void u091Eu0929u0924u0926u091Du0925u091Du091Cu0920u0922u091B(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D4F70-0x00000001817D5000
		public virtual RadialMenuButton u091Cu0925u0925u0925u091Eu0929u0921u0927u0926u091Au0928(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D39D0-0x00000001817D3A50
		public virtual RadialMenuButton u0921u091Fu091Bu091Au0920u091Du091Du091Au0928u0924u091A(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D53C0-0x00000001817D5440
		protected virtual void u0926u091Fu091Du091Bu091Au091Fu0922u091Cu0924u0927u0920() {} // 0x00000001817D7290-0x00000001817D7350
		public void u091Eu0921u091Fu091Au0928u091Eu0928u0923u0925u091Bu0928(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D4430-0x00000001817D44D0
		public virtual void u0920u091Du091Du0923u091Du0928u0922u091Bu091Bu091Au0928(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D50C0-0x00000001817D50E0
		protected virtual void u091Du0929u091Au0929u091Du0920u0927u0928u0921u0927u091C(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922, u091Cu0927u0924u091Bu0923u0927u0929u091Cu0927u0921u0929 u091Cu091Bu091Du0929u0929u0926u0923u091Fu0926u091Eu0927) {} // 0x00000001817D3CC0-0x00000001817D4230
		protected virtual void u0924u091Cu091Au091Du0922u091Bu0929u0924u0925u0923u091C(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922, u091Cu0927u0924u091Bu0923u0927u0929u091Cu0927u0921u0929 u091Cu091Bu091Du0929u0929u0926u0923u091Fu0926u091Eu0927) {} // 0x00000001817D58F0-0x00000001817D5E60
		public void u0929u0928u091Cu0926u091Au0925u0920u0926u0920u0924u091E(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D8A20-0x00000001817D8AC0
		protected virtual IEnumerator u0926u0924u0929u0920u0921u0925u0920u091Cu0921u0921u0920(bool u091Eu0923u091Cu091Cu091Bu091Cu091Bu091Cu091Cu091Bu0928) => default; // 0x00000001817D7430-0x00000001817D74B0
		public virtual void u091Eu091Eu0925u091Bu0923u0922u0927u0924u091Eu091Cu091B(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D43A0-0x00000001817D4430
		protected virtual void u091Au0927u0923u091Cu0928u0929u0926u0926u0920u091Du091A(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D30D0-0x00000001817D30F0
		public virtual void u0923u091Du0922u091Eu0920u091Du091Fu0924u0929u091Cu091F(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D57E0-0x00000001817D5800
		// [IteratorStateMachine] // 0x0000000180138BE0-0x0000000180138C30
		protected virtual IEnumerator u0927u091Au091Du0923u091Cu091Au0927u0924u0929u0925u0925(bool u091Eu0923u091Cu091Cu091Bu091Cu091Bu091Cu091Cu091Bu0928) => default; // 0x00000001817D75C0-0x00000001817D7640
		public virtual void u091Bu0929u0927u0928u0923u091Eu091Cu0928u0928u091Bu091E(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D3770-0x00000001817D3790
		public virtual void u091Eu091Du0922u091Fu0929u0925u091Cu091Eu0920u0926u0921(bool u0926u0921u091Bu0925u0925u0926u0920u0924u0929u0928u0927) {} // 0x00000001817D4310-0x00000001817D43A0
		protected virtual void u0928u091Fu091Bu0922u091Au0923u0928u091Au0926u0926u091D() {} // 0x00000001817D7CE0-0x00000001817D7DA0
		public virtual RadialMenuButton u091Eu0927u0920u0929u0927u0922u0921u0921u091Fu0922u0924(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) => default; // 0x00000001817D44D0-0x00000001817D4550
		public virtual void u0923u0929u091Du0928u0924u091Bu0925u0920u0928u091Cu091E(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D50C0-0x00000001817D50E0
		protected virtual void u091Bu091Fu0921u0926u0922u0926u0926u0929u0920u091Du0926() {} // 0x00000001817D3190-0x00000001817D32C0
		public virtual void UnClickButton(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D60B0-0x00000001817D60D0
		public void u0925u0920u091Au0921u0923u091Du0921u091Cu091Au0924u091E(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D6B10-0x00000001817D6BB0
		protected virtual void u0924u0926u091Du0920u091Cu0924u0920u0924u0928u0920u091C(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D6090-0x00000001817D60B0
		protected virtual void u091Du0927u091Bu0929u0926u091Bu091Bu0923u091Cu0929u0924(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D3C00-0x00000001817D3C20
		public virtual void u0925u0923u091Bu0921u091Eu0929u0925u0921u091Au0922u0929(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001807761A0-0x00000001807761C0
		public virtual void u0924u091Bu0927u0927u091Au0926u0928u0922u0926u0920u0927(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D58D0-0x00000001817D58F0
		protected virtual void u0921u0929u0924u0921u0921u091Du0926u0923u0929u091Cu0928() {} // 0x00000001817D5500-0x00000001817D5630
		public virtual void u0927u091Fu091Du0923u091Au0923u0928u091Cu0928u0923u0923() {} // 0x00000001817D7780-0x00000001817D7910
		public virtual void u0926u0926u0924u091Au0920u0922u091Fu091Du0920u0924u091A(float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x00000001817D3770-0x00000001817D3790
		public void u0923u091Bu0920u0921u0922u0921u0923u091Du0922u091Fu0923(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D56C0-0x00000001817D5760
		public void u0921u0929u091Bu091Cu0924u091Fu0926u0929u0922u0925u0924(u091Au0922u0922u091Eu091Au091Au091Eu091Bu0923u0924u0928 u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) {} // 0x00000001817D5460-0x00000001817D5500
		protected virtual void u0925u091Du0925u091Fu091Fu0928u0928u0923u0924u091Cu0928(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x00000001817D6AF0-0x00000001817D6B10
		public virtual void u0920u0928u0928u0923u0926u0920u0923u0925u0923u0927u091F() {} // 0x00000001817D5230-0x00000001817D53C0
		public void RegenerateButtons() {} // 0x00000001817D23D0-0x00000001817D2DD0
		protected virtual void u0927u0927u0926u091Du0923u0920u0922u0922u091Fu0929u0927() {} // 0x00000001817D7A10-0x00000001817D7B40
	}
}
