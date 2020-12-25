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

namespace VRTK
{
	public class VRTK_IndependentRadialMenuController : VRTK_RadialMenuController // TypeDefIndex: 7450
	{
		// Fields
		public VRTK_InteractableObject u0926u0929u0920u091Du0927u0925u0925u0921u0922u0921u091F; // 0x30
		public bool u091Eu0921u091Fu0922u0929u0920u0921u091Bu0921u091Du0921; // 0x38
		// [Range] // 0x00000001800DF840-0x00000001800DF860
		public float u091Eu0929u091Du0929u0922u0924u0929u0926u091Eu0920u0922; // 0x3C
		public bool u0927u091Bu0927u0927u0928u091Bu091Au091Du0920u0924u0928; // 0x40
		// [Range] // 0x0000000180134310-0x0000000180134330
		public float u091Au091Fu091Eu0922u0927u0923u091Au0926u0921u0925u0921; // 0x44
		public GameObject u091Fu091Du0923u0925u0921u0927u0921u091Au0927u091Au091F; // 0x48
		protected List<GameObject> u0929u0929u0927u091Du0923u091Du0927u091Au0928u091Du091C; // 0x50
		protected List<GameObject> u0927u091Cu0925u0921u091Du0921u0925u091Au0927u091Bu091D; // 0x58
		protected SphereCollider u0920u0927u091Cu0925u0927u0920u0921u0926u0922u0922u0929; // 0x60
		protected Coroutine u0927u091Du0924u0924u0924u091Cu0929u091Eu0926u091Bu0921; // 0x68
		protected Vector3 u0927u0925u0927u0923u0928u091Eu091Fu0924u0920u091Du091D; // 0x70
		protected Quaternion u0926u0920u0925u0927u0929u0928u0928u0927u091Cu0928u0929; // 0x7C
		protected bool u091Cu0924u0925u0927u091Cu0924u0921u0921u0921u091Au091C; // 0x8C
		protected bool u0924u0929u091Eu0921u091Bu091Au0922u091Cu0921u0921u091A; // 0x8D
		protected int u0928u091Du091Bu0924u0929u091Au0923u0923u091Au0929u091E; // 0x90
	
		// Constructors
		public VRTK_IndependentRadialMenuController() {} // 0x000000018109C140-0x000000018109C170
	
		// Methods
		protected virtual void u0926u0926u0929u0923u091Bu0924u0929u0928u091Du091Au0928(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097D60-0x0000000181097E10
		public virtual void u0921u091Bu091Bu091Eu091Eu0925u091Bu0922u0921u0920u091D() {} // 0x0000000181094050-0x00000001810943D0
		protected virtual void u0920u0923u0926u0926u091Fu091Bu091Fu0920u0924u0929u0924() {} // 0x0000000180824F50-0x0000000180824F70
		protected virtual void u091Cu091Au091Du091Eu0920u0922u091Eu0926u091Du091Cu091E(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108E030-0x000000018108E090
		public virtual void u091Du0925u0922u091Bu0921u0926u0922u091Cu091Cu0927u0923() {} // 0x000000018108FC60-0x000000018108FFE0
		protected override void Awake() {} // 0x000000018108BAA0-0x000000018108BB30
		protected virtual void u0923u0926u0926u091Du0929u0925u091Eu0927u0927u091Eu0929() {} // 0x0000000181096500-0x0000000181096550
		protected virtual void u0929u0922u0925u0924u091Fu0926u0920u0929u091Fu0928u091C(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018109B150-0x000000018109B1B0
		protected virtual void u0920u091Du0926u091Au0926u0926u0928u0929u0924u091Au0929(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181093590-0x00000001810935F0
		protected override void u091Cu0923u0924u091Cu0922u091Du0929u0926u0929u091Au091F(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x000000018108E4C0-0x000000018108E560
		protected virtual void u0926u0922u0926u0922u0920u091Fu0928u0926u0923u091Au0927(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097B00-0x0000000181097B60
		protected virtual void u0929u0927u0920u0924u0922u091Au0923u091Fu091Au091Fu0923() {} // 0x000000018109B2D0-0x000000018109B340
		protected virtual void u0927u0927u0928u0925u091Du091Cu091Fu091Au091Du0926u0926(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181098CF0-0x0000000181098D50
		protected virtual void u091Eu091Cu091Bu091Au0924u091Cu091Fu0921u091Bu0928u0922() {} // 0x0000000180824F50-0x0000000180824F70
		protected virtual void u0921u091Au0921u091Bu0927u0921u0928u0927u091Bu0928u091D(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181093FE0-0x0000000181094050
		protected virtual void u0923u0927u0927u0922u0926u091Eu0925u0920u091Du0928u0924(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181096550-0x0000000181096600
		protected override void u0920u0929u0920u0922u0922u0921u0926u091Fu091Au0920u0928() {} // 0x0000000181093E00-0x0000000181093FE0
		public virtual void u091Eu091Bu091Du0922u0927u0923u0923u0927u0925u091Au091F() {} // 0x00000001810912B0-0x0000000181091630
		protected virtual void u0928u0920u091Fu091Du0925u0927u0926u0924u0928u091Cu091A() {} // 0x0000000181099C80-0x000000018109A150
		protected override void OnDisable() {} // 0x000000018108BC00-0x000000018108BDC0
		protected virtual void u0928u091Bu0928u0920u0925u0927u0926u091Bu0925u091Bu0928(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181099690-0x00000001810997B0
		protected override void u091Eu0924u091Au0922u0920u0929u0924u091Fu0920u0925u0924() {} // 0x0000000181091F20-0x00000001810920E0
		protected virtual void u0928u0921u091Du091Bu0921u091Bu0928u0927u091Au0925u0924(bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018109A8A0-0x000000018109AB70
		protected virtual void u0926u0920u091Bu091Fu0921u0928u0927u091Fu0926u0921u0926() {} // 0x000000018108EAB0-0x000000018108EAD0
		protected virtual void u091Du0923u0925u0925u0925u0926u0929u0923u0923u0923u091C() {} // 0x000000018108F940-0x000000018108F960
		protected virtual float u091Au091Eu0921u091Eu091Bu0921u0921u0929u0925u0925u091C(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x000000018108BFA0-0x000000018108C280
		protected virtual float u0927u0920u0929u091Bu0924u0921u0927u0927u0920u0921u0927(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x0000000181097FE0-0x00000001810982C0
		protected override void u091Bu0927u091Bu0928u0921u091Cu091Eu091Au0924u091Du091C() {} // 0x000000018108DCB0-0x000000018108DE70
		protected virtual float u091Bu0927u091Au091Du0928u0925u0920u091Fu091Cu0924u091B(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x000000018108DB60-0x000000018108DCB0
		public virtual void u091Eu091Bu0928u0924u0927u0924u091Fu091Eu0923u091Au091D() {} // 0x0000000181091630-0x00000001810919B0
		protected virtual void u091Du0920u0928u091Fu0925u0925u091Eu0927u0926u0927u0921(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108F600-0x000000018108F6B0
		protected virtual IEnumerator u091Eu0922u0923u0923u091Fu0923u0927u091Cu0927u0921u0929(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x0000000181091DA0-0x0000000181091E50
		protected virtual void u0921u0921u0921u0927u091Cu0920u0927u0929u0927u0925u091A(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181094FE0-0x00000001810951B0
		protected virtual void u091Fu091Eu0926u091Du091Bu0926u0920u0922u0921u0920u0921(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181092D70-0x0000000181092F40
		protected virtual void u091Fu0922u0926u091Au0920u0926u091Au091Fu091Cu0928u091E(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181093220-0x0000000181093290
		protected virtual float u091Au0926u091Du091Fu091Eu0927u091Du0925u091Au0927u0925(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x000000018108C2E0-0x000000018108C5C0
		protected override void u091Bu091Eu0927u0920u0927u0920u0926u091Du091Du0923u0920() {} // 0x000000018108D070-0x000000018108D250
		protected override void u091Bu0929u091Bu0920u0924u091Du0920u0929u0925u0920u091C() {} // 0x000000018108DE70-0x000000018108E030
		protected virtual IEnumerator u0922u091Au0928u0920u0924u0920u0926u0928u0929u0927u091E(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x0000000181095BF0-0x0000000181095CA0
		protected override void u091Fu0927u091Cu0924u0922u091Fu0928u0921u0926u091Fu091B(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x0000000181093460-0x0000000181093500
		protected virtual float u0924u091Au0928u0927u0920u091Fu091Fu0924u091Cu0926u0923(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x0000000181096600-0x00000001810968E0
		protected virtual void OnDestroy() {} // 0x000000018108BB90-0x000000018108BC00
		protected virtual void u091Bu0925u091Eu0920u091Bu091Du091Du0927u0924u0922u0924() {} // 0x000000018108D5D0-0x000000018108DAA0
		protected virtual void u0927u0925u0928u0927u091Cu091Eu091Au0920u091Cu091Cu091D() {} // 0x0000000181091EC0-0x0000000181091F20
		public virtual void u091Bu0920u0925u0927u0922u091Eu091Du0926u0920u091Eu0924() {} // 0x000000018108D250-0x000000018108D5D0
		protected virtual void u091Eu0923u0928u091Fu091Bu091Bu091Cu091Cu0923u091Bu091E() {} // 0x0000000181091EC0-0x0000000181091F20
		protected virtual IEnumerator u0926u0923u0925u091Du0928u0928u091Eu091Fu091Cu0923u091D(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x0000000181097B60-0x0000000181097C10
		protected virtual void Start() {} // 0x0000000180824F50-0x0000000180824F70
		protected virtual void u091Cu091Eu0922u0922u0927u0926u0925u091Fu0920u091Eu0929(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108E290-0x000000018108E460
		protected virtual void Update() {} // 0x000000018109BC70-0x000000018109C140
		protected virtual void u0928u0927u0924u0921u091Bu091Au0921u0922u0921u091Du091B() {} // 0x000000018109B040-0x000000018109B0B0
		protected override void u0923u0922u091Du091Fu0924u0927u0924u0922u0925u0929u091E() {} // 0x0000000181096150-0x0000000181096330
		protected virtual void u091Eu091Du0926u0920u091Fu0929u0926u0921u0929u091Au091C(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810919B0-0x0000000181091A20
		protected virtual void u091Cu091Bu091Du091Au0926u0927u091Cu0924u0927u0926u0924(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108E090-0x000000018108E140
		protected virtual void u091Fu091Du0922u0928u091Eu091Du0927u091Fu0922u0925u0922(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181092C50-0x0000000181092D70
		protected virtual void u0925u0927u091Au0927u091Au0928u091Du0929u091Du091Cu091C(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810977B0-0x0000000181097980
		protected virtual void u091Du091Fu0923u0924u0926u0925u0921u0922u091Au0928u0928(bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108F2C0-0x000000018108F600
		protected virtual void u0922u0923u0922u0922u091Bu0927u091Au091Du0921u0924u091E(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181095D10-0x0000000181095D70
		protected virtual void u0920u0922u091Eu091Eu0920u091Bu0924u0924u0929u091Du0923(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810938D0-0x0000000181093930
		protected override void u0921u091Du0923u0923u0923u0923u0924u0928u091Au091Du0920() {} // 0x00000001810946B0-0x0000000181094890
		protected virtual void u091Eu0926u091Eu0923u091Bu091Bu0928u091Du091Fu0925u0926(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810920E0-0x00000001810922B0
		protected virtual void u0928u091Au091Cu0927u0928u0924u0925u091Fu0926u0926u091C(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181098E70-0x0000000181098ED0
		protected virtual void u091Fu0925u0923u0924u0925u0925u0923u091Du0924u0924u0924(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181093290-0x0000000181093460
		protected virtual void u0928u091Bu091Au0929u0926u0928u091Du091Bu091Au091Bu0925(bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181098ED0-0x00000001810991C0
		protected virtual void FixedUpdate() {} // 0x000000018108BB30-0x000000018108BB90
		protected virtual void u0924u091Cu091Du091Du0921u0927u091Au091Au091Du091Bu0925(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810968E0-0x0000000181096A00
		protected virtual void u0921u0924u091Cu091Fu0925u091Fu0920u091Bu0920u0924u0929() {} // 0x0000000181095300-0x0000000181095360
		protected override void u091Bu091Bu0926u0922u0928u091Fu0922u0929u0920u0929u0920() {} // 0x000000018108CE90-0x000000018108D070
		protected virtual void u0929u0929u091Cu091Du0926u091Bu0929u091Du091Du091Du0921() {} // 0x000000018109B340-0x000000018109B3A0
		protected virtual IEnumerator u091Du0923u091Fu0926u091Du0924u091Du0929u0923u0920u091F(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x000000018108F800-0x000000018108F8B0
		protected virtual void u091Au0928u091Au091Bu091Cu091Fu0922u091Du0925u0925u091A() {} // 0x000000018108C5C0-0x000000018108CA90
		protected virtual void u0923u0923u0922u0926u091Du0926u091Bu0928u0927u0926u0920(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181096330-0x0000000181096500
		protected virtual float u0925u091Cu091Du091Cu0920u0928u0927u091Bu0926u0927u0922(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x00000001810975D0-0x0000000181097720
		protected override void u0921u0927u0928u091Eu0921u091Fu0924u091Du0927u091Du091B() {} // 0x0000000181095410-0x0000000181095B60
		public virtual void u0923u091Au0925u0921u091Bu0924u091Fu0924u0922u091Bu091E() {} // 0x0000000181095D70-0x00000001810960F0
		protected override void u0924u0920u0926u0922u0923u0924u0924u0925u091Cu0925u0923() {} // 0x0000000181096A90-0x0000000181096C50
		protected virtual IEnumerator u0929u0923u0928u0923u091Au091Au0922u0924u0928u0921u091F(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x000000018109B1B0-0x000000018109B260
		protected virtual void u091Au0928u091Fu091Du091Eu091Du0926u0922u091Cu091Fu0925(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108CA90-0x000000018108CBB0
		protected virtual void u0923u091Cu0929u0920u0923u0924u0925u091Bu0929u091Du091B(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x00000001810960F0-0x0000000181096150
		protected override void u0920u091Bu0921u091Cu091Fu0924u0924u0924u0929u0927u0928() {} // 0x0000000181093500-0x0000000181093590
		protected override void u091Du0928u0926u0920u091Fu091Cu091Fu0923u091Fu0928u091C() {} // 0x0000000181090B60-0x00000001810912B0
		protected virtual void u091Au0925u0929u0923u0927u0923u0929u0928u091Cu0929u0920() {} // 0x000000018108C280-0x000000018108C2E0
		protected override void u0921u091Du0926u0926u0928u0922u0922u0925u091Du091Fu0926() {} // 0x0000000181094890-0x0000000181094FE0
		protected virtual void u0928u091Bu0924u091Cu0921u091Fu0920u0923u091Eu091Au0928() {} // 0x00000001810991C0-0x0000000181099690
		protected virtual void u0926u0925u091Eu0926u091Du091Cu091Fu091Au0923u091Du091A(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097C10-0x0000000181097CC0
		protected virtual void u0929u0924u0923u0922u0921u0925u0925u091Cu0923u0928u0927() {} // 0x000000018109B260-0x000000018109B2D0
		public virtual void u091Eu0920u0929u091Cu0927u0929u091Fu0920u0922u091Cu0923() {} // 0x0000000181091A20-0x0000000181091DA0
		protected override void u0928u0920u0925u0929u091Du0928u0921u091Au091Bu0922u0928() {} // 0x000000018109A150-0x000000018109A8A0
		protected virtual float u091Bu091Bu0923u091Bu0920u091Eu0921u091Bu0924u091Au091D(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x000000018108CBB0-0x000000018108CE90
		protected virtual void u0926u091Fu091Eu0925u091Eu0926u0928u0925u0929u0924u0921() {} // 0x0000000181097A30-0x0000000181097A90
		protected virtual void u091Cu0920u0924u0924u091Cu0927u091Bu0925u091Au0928u091E(u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108E460-0x000000018108E4C0
		protected virtual void u091Du091Bu0928u091Eu0924u091Bu091Bu0928u0929u091Fu091E() {} // 0x000000018108EAB0-0x000000018108EAD0
		protected virtual void u0926u0928u091Au0923u091Eu0928u091Au091Fu0920u0920u0922(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097E10-0x0000000181097F30
		public virtual void u091Cu0929u091Bu091Eu091Eu0927u0927u091Cu091Cu091Au0922() {} // 0x000000018108E730-0x000000018108EAB0
		protected virtual void u0926u0922u091Eu091Cu0922u091Bu0923u091Cu0923u0921u091F(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097A90-0x0000000181097B00
		protected override void u0925u0924u091Eu0927u091Bu091Cu0921u0929u091Du091Cu0921() {} // 0x0000000181097720-0x00000001810977B0
		protected override void u0929u091Eu0929u0920u0928u091Bu091Cu091Du0924u0928u091D(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x000000018109B0B0-0x000000018109B150
		protected virtual void u091Eu0922u0927u0920u0926u0928u0925u091Au0923u091Au0928(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181091E50-0x0000000181091EC0
		protected virtual float u0921u0923u091Fu091Bu0920u0926u0925u0922u0927u0922u0929(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x00000001810951B0-0x0000000181095300
		protected virtual void u091Bu0925u0924u0923u0923u0920u091Eu091Fu0928u091Fu0929() {} // 0x000000018108DAF0-0x000000018108DB60
		protected override void u0926u0926u091Du0925u0923u091Eu0920u0922u0920u091Fu091A(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x0000000181097CC0-0x0000000181097D60
		protected virtual void u0924u0927u0924u091Au0926u091Du0923u091Eu0925u091Au0925() {} // 0x0000000181096E30-0x0000000181096EA0
		protected virtual float u091Cu091Bu091Fu0927u0927u0921u0923u0925u0922u0924u091F(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x000000018108E140-0x000000018108E290
		protected virtual void u091Eu0926u0921u0926u091Du0929u091Au0922u091Du0929u0924() {} // 0x00000001810922B0-0x0000000181092780
		protected virtual void u0927u0929u0920u091Au0928u091Bu0923u0921u0921u0923u0926(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181098D50-0x0000000181098E70
		protected virtual void u091Fu091Au091Du091Du0921u091Eu0920u0921u091Bu091Fu091A() {} // 0x0000000181092780-0x0000000181092C50
		protected virtual float u0921u091Cu091Cu0920u0923u091Du0925u0922u091Au091Eu091F(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x00000001810943D0-0x00000001810946B0
		protected virtual void u0928u091Cu091Eu0924u0926u091Eu0921u0924u0923u0924u091E() {} // 0x00000001810997B0-0x0000000181099C80
		public virtual void u0929u0929u0924u0925u0921u0926u091Au091Bu091Fu091Bu091E() {} // 0x000000018109B3A0-0x000000018109B720
		protected override void u091Du091Eu0925u0924u091Bu0927u0929u0921u0928u0921u091D(float u091Fu0929u0926u0929u0920u0925u091Eu091Au0926u0928u0928) {} // 0x000000018108F220-0x000000018108F2C0
		protected override void OnEnable() {} // 0x000000018108BDC0-0x000000018108BFA0
		protected override void u0927u0925u091Au0926u0923u0921u091Du091Eu0920u0928u091F() {} // 0x00000001810985A0-0x0000000181098CF0
		protected virtual void u091Bu0925u0922u0921u0921u0921u091Du0923u091Eu091Eu0927() {} // 0x000000018108DAA0-0x000000018108DAF0
		// [IteratorStateMachine] // 0x0000000180134480-0x00000001801344D0
		protected virtual IEnumerator u0927u091Cu0922u0921u0929u0921u091Fu0923u091Fu0929u0927(bool u0924u0926u0928u0925u0923u0922u0929u0927u091Au091Du091E, float u0924u0920u091Bu091Bu0928u091Cu0927u0928u0924u0920u0922, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) => default; // 0x0000000181097F30-0x0000000181097FE0
		protected virtual float u0927u0922u091Bu091Bu0922u091Eu0927u0921u091Cu0921u091E(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x00000001810982C0-0x00000001810985A0
		protected virtual float u091Fu0922u091Cu0926u0920u0926u0925u0927u0926u0928u0921(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x0000000181092F40-0x0000000181093220
		protected virtual float u091Du0923u091Fu091Du091Cu091Eu091Du091Eu0927u0927u0923(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x000000018108F6B0-0x000000018108F800
		protected virtual void u0921u0924u091Cu0925u091Cu0924u091Cu091Du091Fu0923u091E(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181095360-0x0000000181095410
		protected override void u0921u0928u0924u0929u0925u0929u0922u091Fu0921u0922u091F() {} // 0x0000000181095B60-0x0000000181095BF0
		protected virtual float u091Du0926u091Bu0926u0926u091Du0927u091Cu0928u091Eu0921(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x000000018108FFE0-0x00000001810902C0
		protected override void u0924u0927u0921u0928u0924u091Bu091Eu091Cu0922u091Fu091D() {} // 0x0000000181096C50-0x0000000181096E30
		protected virtual void u0929u0929u0926u0924u0923u0921u0928u0925u0920u091Du091E(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018109B720-0x000000018109B8F0
		protected virtual void u091Cu0927u0922u091Cu0921u0923u0926u0921u0923u091Au091A(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108E560-0x000000018108E730
		protected virtual void u0920u0924u0920u0926u0926u0920u0923u091Fu0929u091Du091F() {} // 0x0000000181093930-0x0000000181093E00
		protected override void u0924u091Fu0920u091Eu0921u0920u0924u091Fu091Du091Eu091D() {} // 0x0000000181096A00-0x0000000181096A90
		public virtual void UpdateEventsManager() {} // 0x000000018109B8F0-0x000000018109BC70
		protected override void u0924u0928u091Bu0920u091Bu091Bu091Cu0920u0922u0927u0924() {} // 0x0000000181096EA0-0x00000001810975D0
		protected virtual float u0920u0921u0928u091Bu0929u0925u0924u0928u0922u0920u0928(GameObject u091Au0920u091Au091Eu091Eu0925u0929u0923u091Au0923u0920) => default; // 0x00000001810935F0-0x00000001810938D0
		protected virtual float u091Du0926u091Eu0924u0927u0921u091Eu0924u091Du0927u0923(Vector3 u0925u091Cu0929u0924u091Du0928u091Fu0929u0924u0922u0924, Vector3 u091Fu0928u091Cu0922u0923u0928u091Au0920u0928u0926u0925, Vector3 u091Bu091Au0922u0928u091Au0929u091Cu0926u091Fu0922u091D) => default; // 0x00000001810902C0-0x0000000181090410
		protected override void u091Du0927u0929u091Au091Bu091Eu091Fu0924u0927u0929u0921() {} // 0x0000000181090410-0x0000000181090B60
		protected virtual void u0923u091Du091Bu0928u0929u0929u0920u0929u091Fu091Cu091F() {} // 0x0000000181091EC0-0x0000000181091F20
		protected virtual void u091Du0925u091Eu0925u091Du091Fu0925u0928u0927u091Fu091B(bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018108F960-0x000000018108FC60
		protected virtual void u0928u0924u091Au091Eu0923u0922u0927u091Fu0929u091Bu0927() {} // 0x000000018109AB70-0x000000018109B040
		protected virtual void u0926u091Cu0920u0920u0927u0925u091Bu091Cu091Du0924u0929(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u091Au0920u0926u091Fu091Au0927u0923u091Fu0922u0925u0925 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000181097980-0x0000000181097A30
		protected override void u091Du091Eu0922u091Du0922u0924u0923u0925u091Au0926u0925() {} // 0x000000018108EAD0-0x000000018108F220
		protected override void u091Du0923u0925u091Fu091Eu0922u091Cu091Cu0926u0922u091C() {} // 0x000000018108F8B0-0x000000018108F940
		protected virtual void u0922u091Bu0929u0921u0928u0927u0928u0925u091Du0922u0921() {} // 0x0000000181095CA0-0x0000000181095D10
	}
}