﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class MainManager : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks // TypeDefIndex: 7136
{
	// Fields
	public static MainManager u0925u091Fu0920u091Cu0925u091Fu0927u091Cu091Au0925u0927; // 0x00
	public Camera u091Cu091Eu0928u091Du0922u091Au0924u091Cu091Cu0926u0929; // 0x18
	public List<Transform> u0925u0923u091Eu091Au0928u0924u0922u0923u091Bu091Du091B; // 0x20
	public GameObject u0928u0928u0920u0920u091Eu0920u091Bu0920u091Au0921u091E; // 0x28
	public GameObject u0925u0927u091Fu0927u091Eu091Bu0920u0926u091Eu091Bu0926; // 0x30
	private bool u0928u0921u0928u091Au0923u091Bu0927u0927u0920u0922u0925; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject serverObject; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_UICanvas vrtkCanvas; // 0x48
	public PCManager u0924u0924u0929u091Du091Fu091Eu0922u0929u091Du0926u0924; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private MyAudioManager audioManager; // 0x58
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private StoreSDKManager storeSDKManager; // 0x60
	public ControlsManager u0922u0926u0929u0929u0928u091Cu0920u091Eu0929u0926u091E; // 0x68
	public ServerManager u0925u0929u091Fu0928u0927u091Eu091Du091Du091Cu0926u0927; // 0x70
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject RewardScreen; // 0x78
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject FailureScreen; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject TrainingScreen; // 0x88
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject serverScreen; // 0x90
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject ErrorScreen; // 0x98
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject PhotoWarningScreen; // 0xA0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text trainingGhostTypeText; // 0xA8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button serverLobbyButton; // 0xB0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text serverLobbyText; // 0xB8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text serverVersionText; // 0xC0
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public Player u091Du0920u0926u091Eu0926u091Fu0929u0929u0929u0926u0927; // 0xC8
	private int u0920u0928u0929u0923u0921u0922u091Bu0929u0920u091Du0925; // 0xD0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private SteamAuth steamAuth; // 0xD8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private ViveportAuth viveportAuth; // 0xE0

	// Constructors
	public MainManager() {} // 0x0000000180C06D50-0x0000000180C06DC0

	// Methods
	private void u0929u0923u0921u091Bu0926u091Cu091Eu0920u0921u091Fu0921() {} // 0x0000000180C06B80-0x0000000180C06D00
	private void u091Eu0927u0926u091Fu091Cu091Fu091Bu0929u091Fu0923u0924(bool u091Au0925u0925u0924u0929u091Au0928u091Du0921u0926u091E) {} // 0x0000000180C04FB0-0x0000000180C05300
	private IEnumerator u091Fu091Fu091Au091Cu0920u091Eu0929u0929u091Au091Au0921() => default; // 0x0000000180C053E0-0x0000000180C05450
	public void OnRoomListUpdate(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Bu091Du0928u0921u091Eu0920u091Bu0922u0923u0929u091D(bool u091Au0925u0925u0924u0929u091Au0928u091Du0921u0926u091E) {} // 0x0000000180C044D0-0x0000000180C04810
	private void u0922u0929u0921u0926u091Eu091Eu0922u0922u0927u0925u0928() {} // 0x0000000180C05D00-0x0000000180C05FA0
	public void QuitGame() {} // 0x0000000180C03E70-0x0000000180C03E80
	public void u091Fu091Au0929u0926u0927u0922u0922u0923u091Cu091Eu091D(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0922u0928u0924u0927u0925u091Fu0920u0929u091Bu091Fu0920() {} // 0x0000000180C05C60-0x0000000180C05D00
	public void u091Bu0929u0927u091Du0929u0927u091Eu0926u0923u0929u091A(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180C04970-0x0000000180C04A70
	private void u091Du0929u0929u0929u091Eu0927u091Fu0921u0927u091Bu091C() {} // 0x0000000180C04D10-0x0000000180C04FB0
	public void OnCustomAuthenticationFailed(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180C036F0-0x0000000180C03800
	public void u0925u091Fu091Au091Du0927u091Cu0927u091Eu0922u0925u091D(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Bu091Fu0922u0928u091Au0921u0926u0929u091Fu091Au091C() {} // 0x0000000180C04810-0x0000000180C04970
	public void u091Fu0924u0923u0925u091Bu091Fu091Au0924u091Eu0925u0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180C054F0-0x0000000180C05600
	public void u091Du091Eu0920u091Eu091Du0926u0928u091Au0921u091Cu0929(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Fu0923u0924u0928u0920u0927u0924u0929u0928u0920u0923() {} // 0x0000000180C05450-0x0000000180C054F0
	public void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void Awake() {} // 0x0000000180C03530-0x0000000180C035D0
	public void AcceptPhotoWarning() {} // 0x0000000180C034B0-0x0000000180C03530
	public void OnJoinRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180C03B20-0x0000000180C03E70
	private void u091Au0923u0924u0928u0928u091Au091Eu0928u0921u091Eu0928() {} // 0x0000000180C04390-0x0000000180C044D0
	private void u0926u0924u091Bu0923u0928u091Du0929u091Au091Cu091Du0927(bool u0929u0921u0929u091Fu0927u0925u091Eu0926u0920u0924u091B) {} // 0x0000000180C063E0-0x0000000180C06450
	public void u0926u091Bu0922u0928u091Au0921u091Au0929u0928u091Cu091C(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void OnEnable() {} // 0x0000000180C03AC0-0x0000000180C03B20
	private void OnDisable() {} // 0x0000000180C03800-0x0000000180C03860
	public void OnJoinRandomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0927u0929u0925u0921u0929u0925u091Bu0921u091Du0920u0920(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180C067C0-0x0000000180C06B10
	private void u0920u0923u0928u0920u091Eu091Du0921u0925u091Du0929u0921() {} // 0x0000000180C05980-0x0000000180C059E0
	// [IteratorStateMachine] // 0x00000001800ED110-0x00000001800ED160
	private IEnumerator u0929u0929u0923u091Fu091Au0922u0929u0927u091Fu091Du091D() => default; // 0x0000000180C06D00-0x0000000180C06D50
	public void OnDisconnected(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180C03860-0x0000000180C03AC0
	private void u0921u0922u0924u0921u091Au091Du091Fu0923u0924u091Fu0929() {} // 0x0000000180C05B40-0x0000000180C05BE0
	private void u0925u0922u0921u0923u0928u0922u0920u0926u0923u0926u091E() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0928u091Au0923u0929u0924u091Bu0929u0929u091Fu0922(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnRegionListReceived(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Au091Cu091Eu0928u091Au0926u0925u0927u091Du091Du091F() {} // 0x0000000180C04080-0x0000000180C04390
	private void u091Cu0924u0923u091Eu091Du091Fu0922u0920u0922u0923u091B() {} // 0x0000000180C04A70-0x0000000180C04D10
	private void u091Au091Au0924u091Cu0925u091Cu0927u0925u091Cu091Au0925() {} // 0x0000000180C04020-0x0000000180C04080
	private void u0923u091Bu091Du0920u091Fu091Fu091Bu091Eu0926u091Fu0920() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu091Au0925u0926u0922u0920u091Bu091Fu0925u0920u091A(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0926u091Du0924u091Bu0921u0925u091Cu0922u0920u091Fu0925() {} // 0x0000000180C06260-0x0000000180C063E0
	public void OnCustomAuthenticationResponse(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0929u091Fu0928u091Eu0925u0921u0927u091Eu0927u091Eu0921(bool u0929u0921u0929u091Fu0927u0925u091Eu0926u0920u0924u091B) {} // 0x0000000180C06B10-0x0000000180C06B80
	public void u0922u091Bu0928u0922u0924u091Au0923u091Au0921u0923u0920() {} // 0x0000000180C05BE0-0x0000000180C05C60
	public void OnLeftLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnConnected() {} // 0x0000000180C035D0-0x0000000180C035E0
	private IEnumerator u0923u091Fu091Fu091Fu091Eu091Fu091Eu0920u091Cu0928u0929() => default; // 0x0000000180C05FA0-0x0000000180C05FF0
	private void u091Fu0928u0921u0922u0922u0928u0926u091Au0927u0925u091B() {} // 0x0000000180C05600-0x0000000180C05910
	public void SetPlayerName() {} // 0x0000000180C03E80-0x0000000180C03FB0
	public void u091Du091Au0929u0921u0923u091Bu091Cu0924u0927u0929u0922(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180246DB0-0x0000000180246DC0
	private IEnumerator u0920u0922u0920u091Au0929u091Du091Au091Du0926u0928u0922() => default; // 0x0000000180C05910-0x0000000180C05980
	private void u0921u0922u091Du0926u0920u091Bu091Au0927u0929u091Bu091A() {} // 0x0000000180C059E0-0x0000000180C05B40
	public void u091Fu091Au0921u091Cu0922u0925u0928u0929u0928u091Bu0926() {} // 0x0000000180C05300-0x0000000180C053E0
	// [IteratorStateMachine] // 0x00000001800ED2D0-0x00000001800ED320
	private IEnumerator Start() => default; // 0x0000000180C03FB0-0x0000000180C04020
	public void OnCreateRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180C035E0-0x0000000180C036F0
	public void u091Au0923u091Au0928u091Bu091Bu0927u0927u0920u0922u0926(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0927u0923u0924u091Du0927u0927u0923u0925u0929u091Du0920(bool u091Au0925u0925u0924u0929u091Au0928u091Du0921u0926u091E) {} // 0x0000000180C06450-0x0000000180C067C0
	private void u0920u091Fu0927u0920u091Fu091Cu0928u091Bu0928u0923u091C() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnFriendListUpdate(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0924u0924u091Au091Fu0925u091Du0924u0924u0925u0928u0921() {} // 0x0000000180C05FF0-0x0000000180C06260
}

