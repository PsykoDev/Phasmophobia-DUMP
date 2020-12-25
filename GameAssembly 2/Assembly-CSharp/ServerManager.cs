﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class ServerManager : MonoBehaviour, IInRoomCallbacks, IConnectionCallbacks, IMatchmakingCallbacks // TypeDefIndex: 7149
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Sprite[] characterIcons; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject loadingScreen; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button startGameButton; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button readyButton; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text readyText; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text selectJobText; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text startGameText; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Color enabledColour; // 0x50
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Color disabledColour; // 0x60
	public PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x70
	public InventoryManager u091Cu0920u0925u0926u0923u0924u0924u091Bu0920u091Eu091F; // 0x78
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LevelSelectionManager levelSelectionManager; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LoadingAsyncManager loadingAsyncManager; // 0x88
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private SteamVR_LoadLevel loadLevel; // 0x90
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button jobFinderButton; // 0x98
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject contractSelectionObject; // 0xA0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text difficultyText; // 0xA8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text levelSelectionText; // 0xB0
	public List<u0923u091Cu0929u091Du0928u0921u0928u0920u0920u0923u091C> u0920u091Au0927u0929u091Eu091Bu0928u0928u0922u091Bu091A; // 0xB8
	public List<ServerItem> u0921u0924u091Bu091Bu091Bu091Eu091Fu0927u0927u0925u0920; // 0xC0
	private int u0921u0928u091Fu0926u0929u091Eu091Eu0926u091Bu0928u0925; // 0xC8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private RectTransform serverMask; // 0xD0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private RectTransform mainMask; // 0xD8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GameObject storeObject; // 0xE0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GamepadUISelector mainSelector; // 0xE8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private GamepadUISelector contractSelector; // 0xF0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button[] kickPlayerButtons; // 0xF8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text inviteCodeText; // 0x100
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private UnityEngine.UI.Text inviteText; // 0x108
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button hideButton; // 0x110
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Button copyButton; // 0x118

	// Constructors
	public ServerManager() {} // 0x0000000180CFD970-0x0000000180CFDA30

	// Methods
	public void u0920u0926u091Cu0923u091Fu0929u091Au0922u0921u0925u0922() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0921u091Au091Eu091Eu0922u091Au091Cu091Eu0928u091Eu091D(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF8310-0x0000000180CF8380
	private IEnumerator u0925u0920u0921u0922u091Au0924u0923u0923u091Fu0922u0926(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) => default; // 0x0000000180CFA030-0x0000000180CFA0C0
	private void u0923u0927u0929u0923u091Bu0925u091Bu0927u0920u091Du091F(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, int u091Bu0927u091Cu0929u091Du0921u0929u0926u091Au0925u0929) {} // 0x0000000180CF99D0-0x0000000180CF9BA0
	public void OnCreatedRoom() {} // 0x0000000180CF28B0-0x0000000180CF2970
	public void Ready() {} // 0x0000000180CF3390-0x0000000180CF3490
	private void u091Fu0926u0929u0925u0923u0921u0925u091Du091Eu0929u0928(string u091Au091Cu0923u091Du0927u091Cu0928u0921u0924u091Cu091F, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CF7710-0x0000000180CF7C20
	private void u0923u0928u0921u0927u0929u0927u091Eu091Eu0927u0924u0923() {} // 0x0000000180CF9BA0-0x0000000180CF9E50
	public void HideCodeButton() {} // 0x0000000180CF1A10-0x0000000180CF1B00
	public void OnJoinRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF2FA0-0x0000000180CF3010
	private IEnumerator u0920u0927u091Cu0923u091Bu0924u0929u0924u0922u0926u0927() => default; // 0x0000000180CF81F0-0x0000000180CF8240
	public void u091Cu0920u091Fu091Du091Fu0920u0925u091Bu0929u091Fu091C() {} // 0x0000000180CF58C0-0x0000000180CF59B0
	private void u0923u091Cu091Bu091Bu0925u091Cu091Au091Cu0926u0927u0925() {} // 0x0000000180CF91C0-0x0000000180CF9290
	public void u091Du0922u091Cu091Fu091Bu091Bu0928u0928u091Du0924u091E() {} // 0x0000000180CF6570-0x0000000180CF6660
	private void u0926u091Eu0927u0927u0926u0927u0926u091Bu091Cu0925u0929() {} // 0x0000000180CFA980-0x0000000180CFAA70
	public void u0928u0926u0924u091Fu0926u0925u0929u0921u0924u091Du091C(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnJoinedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Eu0928u0921u0924u0926u091Au091Cu091Au091Cu0929u0924(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CF6E60-0x0000000180CF6FA0
	public void u091Du091Au0926u0922u0920u0920u0928u0924u0922u0923u091F() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu091Cu0927u0927u0921u0926u091Eu091Cu0926u091Bu0928(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF7300-0x0000000180CF7370
	private void OnEnable() {} // 0x0000000180CF2E30-0x0000000180CF2F30
	private void Start() {} // 0x0000000180CF3BE0-0x0000000180CF3FF0
	public void UpdateUI() {} // 0x0000000180CFD0B0-0x0000000180CFD970
	public void OnCreateRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF2840-0x0000000180CF28B0
	private IEnumerator u0926u0924u091Au0924u0925u091Fu091Eu091Cu0929u091Eu0924() => default; // 0x0000000180CFAAC0-0x0000000180CFAB10
	private IEnumerator u0929u0920u091Au0928u091Fu091Au0922u0922u091Cu0928u091F(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) => default; // 0x0000000180CFC2A0-0x0000000180CFC330
	public void u0929u0922u091Cu091Bu0927u0926u0923u0922u0924u0924u091D() {} // 0x0000000180CFC330-0x0000000180CFCBA0
	public void u0928u091Du091Cu091Eu0928u0927u0921u091Eu091Cu0924u0922() {} // 0x0000000180246DB0-0x0000000180246DC0
	// [IteratorStateMachine] // 0x00000001800F2460-0x00000001800F24B0
	private IEnumerator u0929u091Cu0927u091Au0925u0923u091Au091Au0921u0927u0923() => default; // 0x0000000180CFC250-0x0000000180CFC2A0
	public void u0923u0926u091Bu0928u0928u0921u0925u091Du0923u0925u091C(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnDisconnected(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180CF2AE0-0x0000000180CF2E30
	public void u0920u0927u091Bu0920u0922u0928u0921u0921u0921u091Fu0923(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0924u091Eu0924u0929u0924u091Fu0921u0920u091Du0929u0927() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Cu0927u0926u0920u0923u0929u0926u0929u0925u0922u0928() {} // 0x0000000180CF5F50-0x0000000180CF6020
	public void u091Eu0922u0927u091Bu0920u0921u0921u091Cu0929u0921u0925(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CF69F0-0x0000000180CF6C40
	public void u0927u0924u0929u091Cu0927u0927u091Bu0922u091Cu091Au0927() {} // 0x0000000180CFB750-0x0000000180CFB7F0
	public void u091Cu0924u0926u091Bu0920u0929u0922u0922u091Cu0929u0920() {} // 0x0000000180CF5A00-0x0000000180CF5C50
	private void u0928u0929u0923u091Eu0923u0924u091Eu0928u0925u091Du0921(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180CFBE90-0x0000000180CFC0F0
	private void u0923u0927u0922u091Eu091Eu0928u0922u091Au091Cu0926u0923() {} // 0x0000000180CF9720-0x0000000180CF99D0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	public void SetPlayerInformation(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u0920u0923u0925u0927u091Bu0928u091Du091Fu091Du0928u0929, int u0920u091Eu091Eu091Au0921u0924u091Eu091Bu0927u091Fu091A, int u0921u091Du0928u0920u0921u091Bu091Au091Au091Eu091Eu0924) {} // 0x0000000180CF3540-0x0000000180CF39A0
	private void u0926u091Bu091Cu0922u0928u0923u091Fu0924u091Bu091Bu0923() {} // 0x0000000180CFA500-0x0000000180CFA910
	public void u0924u0928u0925u0926u091Du091Au0920u091Au091Du0922u0925() {} // 0x0000000180CF9F50-0x0000000180CF9FA0
	public void u091Fu0924u091Du091Fu0929u091Eu0929u0925u091Eu091Bu0927(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CF73E0-0x0000000180CF7710
	public void u0926u0921u0922u091Bu0924u091Fu0925u0926u0929u0922u0921() {} // 0x0000000180CFAA70-0x0000000180CFAAC0
	public void u091Cu0921u0926u0925u0926u091Bu091Au091Eu0927u0921u0921() {} // 0x0000000180CF59B0-0x0000000180CF5A00
	public void u0927u091Au0925u091Eu091Fu0925u0922u0923u091Fu0929u091E(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929, int u0920u0923u0925u0927u091Bu0928u091Du091Fu091Du0928u0929, int u0920u091Eu091Eu091Au0921u0924u091Eu091Bu0927u091Fu091A, int u0921u091Du0928u0920u0921u091Bu091Au091Au091Eu091Eu0924) {} // 0x0000000180CFB200-0x0000000180CFB640
	public void u091Eu0921u091Du091Du091Bu0922u0926u091Au0927u0926u0925(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF6980-0x0000000180CF69F0
	public void u0928u0925u0928u0929u091Fu0928u0922u0924u0921u0921u091F() {} // 0x0000000180CFBC00-0x0000000180CFBDC0
	public void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Au0923u0924u0928u0928u091Au091Eu0928u0921u091Eu0928() {} // 0x0000000180CF44D0-0x0000000180CF4770
	private void u0923u091Fu0924u091Bu091Bu0920u0920u091Du0920u091Du0921() {} // 0x0000000180CF9290-0x0000000180CF9360
	public void u0920u091Bu091Eu091Fu091Cu091Eu0920u0929u0929u0924u0929(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x0000000180CF7C90-0x0000000180CF7DA0
	private void u091Du0922u0925u0926u091Au0929u0927u0927u091Fu091Fu0927() {} // 0x0000000180CF6660-0x0000000180CF6910
	public void u091Bu0921u0922u091Du0923u0924u0923u091Eu0925u091Au0925(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du091Au0923u0927u0929u091Cu0926u0922u091Bu0928u0927(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CF6020-0x0000000180CF6160
	public void u091Fu091Du0924u091Au0929u091Fu091Bu091Fu0922u0926u0927(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF7370-0x0000000180CF73E0
	public void u0922u0924u091Du0923u091Eu0924u091Du0921u091Fu0920u091C(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF88C0-0x0000000180CF8930
	public void u091Au091Au091Au0928u0923u091Du0922u091Cu091Fu0920u0927() {} // 0x0000000180CF3FF0-0x0000000180CF40E0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedReady(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180CF24F0-0x0000000180CF27F0
	public void u0921u0923u0923u091Fu091Fu0929u0920u091Du091Cu091Eu0928(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180CF8380-0x0000000180CF83F0
	public void SelectJob(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF3490-0x0000000180CF3540
	public void u091Cu0928u091Eu0924u0925u091Du0926u0926u0923u091Du091A() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0924u0921u0928u091Fu0929u091Du0929u0922u0928u091Eu091A(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0921u0925u0928u091Du091Eu0926u091Bu0924u091Bu0924u091E(ExitGames.Client.Photon.Hashtable u0927u091Bu091Eu0926u0922u091Au0928u0920u0929u091Cu0921) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void EnableOrDisablePlayerModels(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF16D0-0x0000000180CF1A10
	public void u0921u0920u091Bu0920u0921u0929u091Du0924u0925u091Eu091D(Photon.Realtime.Player u0922u091Au0920u0923u091Du091Au091Eu091Eu0925u0920u091B) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du0925u091Eu0920u091Du091Du0929u0924u0926u0924u091C(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180CF6910-0x0000000180CF6980
	private void u091Cu091Eu0925u091Au0920u0926u0927u091Du0928u0929u0927() {} // 0x0000000180CF5610-0x0000000180CF58C0
	private void u0927u091Au0924u091Fu0922u0927u091Bu091Cu091Au0921u0923() {} // 0x0000000180CFB100-0x0000000180CFB200
	public void u0922u091Au091Cu0920u091Au0924u0925u0926u091Eu0921u091C(Photon.Realtime.Player u0922u091Au0920u0923u091Du091Au091Eu091Eu0925u0920u091B) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Eu0923u091Au0923u0923u0923u091Eu0928u0922u091Cu0920() {} // 0x0000000180CF6C40-0x0000000180CF6C90
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	public void LeaveServer(bool u091Fu0923u0928u091Cu0928u0926u091Fu0927u0923u0921u091C, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CF1E10-0x0000000180CF1FC0
	public void u091Au0924u091Bu0929u091Cu0926u0922u0921u0929u0925u0925() {} // 0x0000000180CF4770-0x0000000180CF49C0
	public void u091Bu091Fu091Cu091Fu0928u091Au0923u0922u091Fu0920u091C(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x0000000180CF5350-0x0000000180CF5460
	public void u0927u091Du0927u091Au0923u091Au0929u0927u0921u0922u0929(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x0000000180CFB640-0x0000000180CFB750
	public void u091Du091Cu0929u0926u0929u0928u0927u091Eu0925u091Eu091D(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF61F0-0x0000000180CF6310
	private IEnumerator u0925u091Cu091Cu091Fu0925u091Bu0928u0925u0924u0921u0923(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) => default; // 0x0000000180CF9FA0-0x0000000180CFA030
	private void u091Au091Fu0928u091Bu0924u0928u0924u0920u091Au0927u0926(Photon.Realtime.Player u0924u0925u091Au091Du0924u0929u0926u0929u0929u0924u0929) {} // 0x0000000180CF4130-0x0000000180CF44D0
	public void u091Au0927u0928u0929u091Fu091Cu091Fu091Fu091Bu0920u0927() {} // 0x0000000180CF4B80-0x0000000180CF4DD0
	private void u091Cu0925u0929u091Bu0925u0925u0927u091Au0921u0922u091F(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180CF5C50-0x0000000180CF5F50
	private IEnumerator u0920u0925u0928u0924u091Eu0929u0929u091Fu091Eu091Bu0922() => default; // 0x0000000180CF81A0-0x0000000180CF81F0
	private void Awake() {} // 0x0000000180CF1340-0x0000000180CF13C0
	public void u0926u091Au091Cu091Bu091Cu091Fu0923u0922u091Eu091Au0923(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CFA370-0x0000000180CFA500
	public void u091Bu091Cu0929u0921u0928u091Eu0923u0921u0924u091Du0923(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF5090-0x0000000180CF5100
	public void u0928u091Cu0926u0926u091Fu091Du091Eu0924u0924u091Fu091B() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0928u091Bu0929u0925u0923u091Cu091Bu0923u0923u091Fu091C(bool u091Fu0923u0928u091Cu0928u0926u091Fu0927u0923u0921u091C, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CFB7F0-0x0000000180CFB9B0
	private void u0925u0924u0921u0927u091Cu0924u0921u0921u0926u091Cu091C() {} // 0x0000000180CFA0C0-0x0000000180CFA370
	public void u091Bu0928u0920u0927u0928u0921u091Du0920u091Eu091Fu0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0924u0920u0926u0922u0923u0924u0924u0925u091Cu0925u0923() {} // 0x0000000180CF9E50-0x0000000180CF9F50
	public void u0929u0922u0925u091Au0928u091Du0922u091Bu0925u091Au091A(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CFCBA0-0x0000000180CFCEE0
	private void u0922u091Eu0928u091Au091Cu091Eu0929u0925u0923u0927u0922() {} // 0x0000000180CF87F0-0x0000000180CF88C0
	private void u091Bu091Bu0926u0922u0928u091Fu0922u0929u0920u0929u0920() {} // 0x0000000180CF4F90-0x0000000180CF5090
	public void u0929u091Au091Cu091Du0921u0928u0923u0922u0925u091Du091E(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CFC0F0-0x0000000180CFC1D0
	private void u0921u0928u0926u0925u0927u0920u091Bu0927u0929u0921u091B() {} // 0x0000000180CF8720-0x0000000180CF87F0
	public void u0928u0922u091Eu0922u091Cu091Fu0923u091Fu091Du0922u091B(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CFB9B0-0x0000000180CFBC00
	public void OnCustomAuthenticationFailed(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180CF2970-0x0000000180CF29E0
	private void u0920u0923u0926u0926u091Fu091Bu091Fu0920u0924u0929u0924() {} // 0x0000000180CF7DA0-0x0000000180CF81A0
	public void u0922u091Fu0921u0927u091Eu0927u0925u0929u0924u0924u0922(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu091Au0920u0927u091Bu0929u0929u0926u0923u0920u091E(bool u091Fu0923u0928u091Cu0928u0926u091Fu0927u0923u0921u091C, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CF4DD0-0x0000000180CF4F90
	public void KickPlayer(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CF1B00-0x0000000180CF1E10
	public void u091Fu0923u091Au0927u0922u091Au091Au0925u0921u091Eu0921(Photon.Realtime.Player u0922u091Au0920u0923u091Du091Au091Eu091Eu0925u0920u091B) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu091Bu091Du0923u091Du0926u0922u0921u0921u0922u0928(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF5530-0x0000000180CF5610
	public void OnMasterClientSwitched(Photon.Realtime.Player u0922u091Au0920u0923u091Du091Au091Eu091Eu0925u0920u091B) {} // 0x0000000180246DB0-0x0000000180246DC0
	private IEnumerator u091Au091Bu091Au0923u0924u091Du0923u0923u0922u091Du091D() => default; // 0x0000000180CF40E0-0x0000000180CF4130
	public void u0926u0923u091Eu0927u0929u091Cu091Au0929u091Au0926u091F(Photon.Realtime.Player u0923u0929u091Cu091Du0920u0920u0920u091Au091Au0927u091B, ExitGames.Client.Photon.Hashtable u0920u091Au0927u091Au0920u0928u0926u0924u0927u091Cu0923) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0926u0927u091Fu0920u0928u091Au0924u0924u0920u0920u0922() {} // 0x0000000180CFAB80-0x0000000180CFABD0
	public void OnRegionListReceived(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0928u0921u0927u0926u091Bu0929u091Cu0926u0929u0924(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF7C20-0x0000000180CF7C90
	public void u0926u091Bu0925u091Bu0927u0922u091Bu0926u0928u091Fu091C(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180CFA910-0x0000000180CFA980
	public void u0921u0926u0921u0929u091Cu0923u091Cu0925u091Au0924u0922(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF83F0-0x0000000180CF8720
	public void EnableMasks(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF1620-0x0000000180CF16D0
	private void u0926u0928u091Fu0924u091Au0929u0923u0922u0922u0922u0920(string u091Au091Cu0923u091Du0927u091Cu0928u0921u0924u091Cu091F, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CFABD0-0x0000000180CFB100
	public void u091Cu091Au0925u0929u0925u0924u0928u0923u0921u091Au0924() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable u0927u091Bu091Eu0926u0922u091Au0928u0920u0929u091Cu0921) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu091Eu0925u0923u091Bu0925u0927u0924u091Bu0924u091A() {} // 0x0000000180CF5100-0x0000000180CF5350
	public void ChangeCharacterButton() {} // 0x0000000180CF13C0-0x0000000180CF1580
	private void u0922u0925u0925u091Bu091Bu0924u0922u091Fu0927u0920u0921(string u091Au091Cu0923u091Du0927u091Cu0928u0921u0924u091Cu091F, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CF8930-0x0000000180CF8E60
	public void u091Au0924u091Cu091Au0924u0927u0926u091Au0920u0924u0925() {} // 0x0000000180CF49C0-0x0000000180CF4B80
	public void u0923u0925u0925u0922u0924u0926u0928u091Cu0926u0921u0928(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF9360-0x0000000180CF94A0
	public void OpenStore(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000180CF3260-0x0000000180CF3390
	private void u0920u0929u0929u0921u091Bu091Au0926u0921u0926u091Cu091B() {} // 0x0000000180CF8240-0x0000000180CF8310
	public void u091Du0920u0929u0924u091Eu0926u0924u091Cu0923u0929u0929(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180CF6310-0x0000000180CF6570
	public void OnPlayerEnteredRoom(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CF3010-0x0000000180CF3150
	public void u091Eu0924u0921u091Fu0920u0927u091Cu091Du0927u0927u0925() {} // 0x0000000180CF6C90-0x0000000180CF6E60
	public void StartGame() {} // 0x0000000180CF39A0-0x0000000180CF3BE0
	public void OnPlayerLeftRoom(Photon.Realtime.Player u091Au0929u091Au0920u091Eu0929u091Cu091Au091Au0926u0929) {} // 0x0000000180CF3150-0x0000000180CF3260
	public void OnCustomAuthenticationResponse(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Bu0927u091Au091Bu091Du0920u0929u091Bu0922u091Cu0929() {} // 0x0000000180CF5460-0x0000000180CF5530
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void LoadScene(string u091Au091Cu0923u091Du0927u091Cu0928u0921u0924u091Cu091F, int u0924u0925u0924u0927u091Du0924u0923u0926u0927u0929u091B) {} // 0x0000000180CF1FC0-0x0000000180CF24F0
	// [IteratorStateMachine] // 0x00000001800F2790-0x00000001800F27E0
	private IEnumerator u091Du091Cu091Fu0929u0925u091Bu0924u091Eu0929u0925u0925(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) => default; // 0x0000000180CF6160-0x0000000180CF61F0
	public void u0923u0926u0927u091Bu0925u0920u091Eu0925u0923u0920u0927(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CF94A0-0x0000000180CF95E0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void UpdateCharacter(Photon.Realtime.Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, int u091Bu0927u091Cu0929u091Du0921u0929u0926u091Au0925u0929) {} // 0x0000000180CFCEE0-0x0000000180CFD0B0
	private void u0928u0926u0927u091Eu091Du0924u091Eu0920u0924u091Fu0923() {} // 0x0000000180CFBDC0-0x0000000180CFBE90
	public void OnFriendListUpdate(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u0927u091Au0924u091Cu0921u091Au091Cu0920u0928u0922(Photon.Realtime.Player u0920u0923u0920u091Au0924u0920u091Bu091Bu0928u0926u0925) {} // 0x0000000180CF95E0-0x0000000180CF9720
	public void u0926u0926u0923u0928u091Du0924u091Du0926u091Du0929u0922(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CFAB10-0x0000000180CFAB80
	private void u0929u091Au091Du0928u0923u091Cu0924u0924u0920u0926u091D() {} // 0x0000000180CFC1D0-0x0000000180CFC250
	private void OnDisable() {} // 0x0000000180CF29E0-0x0000000180CF2AE0
	public void u091Bu0923u0922u0927u091Du0921u0921u091Eu091Au0920u091E(Photon.Realtime.Player u0922u091Au0920u0923u091Du091Au091Eu091Eu0925u0920u091B) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnPlayerPropertiesUpdate(Photon.Realtime.Player u0923u0929u091Cu091Du0920u0920u0920u091Au091Au0927u091B, ExitGames.Client.Photon.Hashtable u0920u091Au0927u091Au0920u0928u0926u0924u0927u091Cu0923) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0927u0920u0927u0927u091Du091Eu091Bu0929u091Du0923u091F(Photon.Realtime.Player u0923u0929u091Cu091Du0920u0920u0920u091Au091Au0927u091B, ExitGames.Client.Photon.Hashtable u0920u091Au0927u091Au0920u0928u0926u0924u0927u091Cu0923) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0922u0928u091Au0925u091Eu091Au0926u0920u091Bu0921u0928(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180CF8E60-0x0000000180CF91C0
	public void OnJoinRandomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180CF2F30-0x0000000180CF2FA0
	public void OnConnected() {} // 0x0000000180CF27F0-0x0000000180CF2840
	public void CopyToClipboard() {} // 0x0000000180CF1580-0x0000000180CF1620
	public void u091Fu091Au091Au0927u091Fu0920u0929u091Bu0920u091Au0922(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180CF6FA0-0x0000000180CF7300
}

