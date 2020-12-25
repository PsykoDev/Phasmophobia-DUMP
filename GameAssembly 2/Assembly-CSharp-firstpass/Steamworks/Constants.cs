﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class Constants // TypeDefIndex: 6338
	{
		// Fields
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001"; // Metadata: 0x00650EB3
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008"; // Metadata: 0x00650ED8
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001"; // Metadata: 0x00650EFA
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient020"; // Metadata: 0x00650F21
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "SteamController007"; // Metadata: 0x00650F33
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends017"; // Metadata: 0x00650F49
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001"; // Metadata: 0x00650F5C
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer013"; // Metadata: 0x00650F77
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001"; // Metadata: 0x00650F8D
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_005"; // Metadata: 0x00650FA8
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION003"; // Metadata: 0x00650FD2
		public const string STEAMINPUT_INTERFACE_VERSION = "SteamInput001"; // Metadata: 0x00650FF4
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V003"; // Metadata: 0x00651005
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009"; // Metadata: 0x00651026
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002"; // Metadata: 0x0065103D
		public const string STEAMGAMESEARCH_INTERFACE_VERSION = "SteamMatchGameSearch001"; // Metadata: 0x0065105B
		public const string STEAMPARTIES_INTERFACE_VERSION = "SteamParties002"; // Metadata: 0x00651076
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001"; // Metadata: 0x00651089
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001"; // Metadata: 0x006510AC
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking006"; // Metadata: 0x006510D5
		public const string STEAMNETWORKINGSOCKETS_INTERFACE_VERSION = "SteamNetworkingSockets008"; // Metadata: 0x006510EB
		public const string STEAMNETWORKINGUTILS_INTERFACE_VERSION = "SteamNetworkingUtils003"; // Metadata: 0x00651108
		public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001"; // Metadata: 0x00651123
		public const string STEAMREMOTEPLAY_INTERFACE_VERSION = "STEAMREMOTEPLAY_INTERFACE_VERSION001"; // Metadata: 0x00651151
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION014"; // Metadata: 0x00651179
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003"; // Metadata: 0x006511A4
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION014"; // Metadata: 0x006511CD
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser020"; // Metadata: 0x006511EE
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011"; // Metadata: 0x006511FE
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils009"; // Metadata: 0x00651225
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V002"; // Metadata: 0x00651236
		public const int k_cubAppProofOfPurchaseKeyMax = 240; // Metadata: 0x00651253
		public const int k_cchMaxFriendsGroupName = 64; // Metadata: 0x00651257
		public const int k_cFriendsGroupLimit = 100; // Metadata: 0x0065125B
		public const int k_cEnumerateFollowersMax = 50; // Metadata: 0x0065125F
		public const int k_cchPersonaNameMax = 128; // Metadata: 0x00651263
		public const int k_cwchPersonaNameMax = 32; // Metadata: 0x00651267
		public const int k_cubChatMetadataMax = 8192; // Metadata: 0x0065126B
		public const int k_cchMaxRichPresenceKeys = 30; // Metadata: 0x0065126F
		public const int k_cchMaxRichPresenceKeyLength = 64; // Metadata: 0x00651273
		public const int k_cchMaxRichPresenceValueLength = 256; // Metadata: 0x00651277
		public const int k_unServerFlagNone = 0; // Metadata: 0x0065127B
		public const int k_unServerFlagActive = 1; // Metadata: 0x0065127F
		public const int k_unServerFlagSecure = 2; // Metadata: 0x00651283
		public const int k_unServerFlagDedicated = 4; // Metadata: 0x00651287
		public const int k_unServerFlagLinux = 8; // Metadata: 0x0065128B
		public const int k_unServerFlagPassworded = 16; // Metadata: 0x0065128F
		public const int k_unServerFlagPrivate = 32; // Metadata: 0x00651293
		public const int k_unFavoriteFlagNone = 0; // Metadata: 0x00651297
		public const int k_unFavoriteFlagFavorite = 1; // Metadata: 0x0065129B
		public const int k_unFavoriteFlagHistory = 2; // Metadata: 0x0065129F
		public const int k_unMaxCloudFileChunkSize = 104857600; // Metadata: 0x006512A3
		public const int k_cchPublishedDocumentTitleMax = 129; // Metadata: 0x006512A7
		public const int k_cchPublishedDocumentDescriptionMax = 8000; // Metadata: 0x006512AB
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000; // Metadata: 0x006512AF
		public const int k_unEnumeratePublishedFilesMaxResults = 50; // Metadata: 0x006512B3
		public const int k_cchTagListMax = 1025; // Metadata: 0x006512B7
		public const int k_cchFilenameMax = 260; // Metadata: 0x006512BB
		public const int k_cchPublishedFileURLMax = 256; // Metadata: 0x006512BF
		public const int k_nScreenshotMaxTaggedUsers = 32; // Metadata: 0x006512C3
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32; // Metadata: 0x006512C7
		public const int k_cubUFSTagTypeMax = 255; // Metadata: 0x006512CB
		public const int k_cubUFSTagValueMax = 255; // Metadata: 0x006512CF
		public const int k_ScreenshotThumbWidth = 200; // Metadata: 0x006512D3
		public const int kNumUGCResultsPerPage = 50; // Metadata: 0x006512D7
		public const int k_cchDeveloperMetadataMax = 5000; // Metadata: 0x006512DB
		public const int k_cchStatNameMax = 128; // Metadata: 0x006512DF
		public const int k_cchLeaderboardNameMax = 128; // Metadata: 0x006512E3
		public const int k_cLeaderboardDetailsMax = 64; // Metadata: 0x006512E7
		public const int k_cbMaxGameServerGameDir = 32; // Metadata: 0x006512EB
		public const int k_cbMaxGameServerMapName = 32; // Metadata: 0x006512EF
		public const int k_cbMaxGameServerGameDescription = 64; // Metadata: 0x006512F3
		public const int k_cbMaxGameServerName = 64; // Metadata: 0x006512F7
		public const int k_cbMaxGameServerTags = 128; // Metadata: 0x006512FB
		public const int k_cbMaxGameServerGameData = 2048; // Metadata: 0x006512FF
		public const int k_iSteamUserCallbacks = 100; // Metadata: 0x00651303
		public const int k_iSteamGameServerCallbacks = 200; // Metadata: 0x00651307
		public const int k_iSteamFriendsCallbacks = 300; // Metadata: 0x0065130B
		public const int k_iSteamBillingCallbacks = 400; // Metadata: 0x0065130F
		public const int k_iSteamMatchmakingCallbacks = 500; // Metadata: 0x00651313
		public const int k_iSteamContentServerCallbacks = 600; // Metadata: 0x00651317
		public const int k_iSteamUtilsCallbacks = 700; // Metadata: 0x0065131B
		public const int k_iClientFriendsCallbacks = 800; // Metadata: 0x0065131F
		public const int k_iClientUserCallbacks = 900; // Metadata: 0x00651323
		public const int k_iSteamAppsCallbacks = 1000; // Metadata: 0x00651327
		public const int k_iSteamUserStatsCallbacks = 1100; // Metadata: 0x0065132B
		public const int k_iSteamNetworkingCallbacks = 1200; // Metadata: 0x0065132F
		public const int k_iSteamNetworkingSocketsCallbacks = 1220; // Metadata: 0x00651333
		public const int k_iSteamNetworkingMessagesCallbacks = 1250; // Metadata: 0x00651337
		public const int k_iSteamNetworkingUtilsCallbacks = 1280; // Metadata: 0x0065133B
		public const int k_iClientRemoteStorageCallbacks = 1300; // Metadata: 0x0065133F
		public const int k_iClientDepotBuilderCallbacks = 1400; // Metadata: 0x00651343
		public const int k_iSteamGameServerItemsCallbacks = 1500; // Metadata: 0x00651347
		public const int k_iClientUtilsCallbacks = 1600; // Metadata: 0x0065134B
		public const int k_iSteamGameCoordinatorCallbacks = 1700; // Metadata: 0x0065134F
		public const int k_iSteamGameServerStatsCallbacks = 1800; // Metadata: 0x00651353
		public const int k_iSteam2AsyncCallbacks = 1900; // Metadata: 0x00651357
		public const int k_iSteamGameStatsCallbacks = 2000; // Metadata: 0x0065135B
		public const int k_iClientHTTPCallbacks = 2100; // Metadata: 0x0065135F
		public const int k_iClientScreenshotsCallbacks = 2200; // Metadata: 0x00651363
		public const int k_iSteamScreenshotsCallbacks = 2300; // Metadata: 0x00651367
		public const int k_iClientAudioCallbacks = 2400; // Metadata: 0x0065136B
		public const int k_iClientUnifiedMessagesCallbacks = 2500; // Metadata: 0x0065136F
		public const int k_iSteamStreamLauncherCallbacks = 2600; // Metadata: 0x00651373
		public const int k_iClientControllerCallbacks = 2700; // Metadata: 0x00651377
		public const int k_iSteamControllerCallbacks = 2800; // Metadata: 0x0065137B
		public const int k_iClientParentalSettingsCallbacks = 2900; // Metadata: 0x0065137F
		public const int k_iClientDeviceAuthCallbacks = 3000; // Metadata: 0x00651383
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100; // Metadata: 0x00651387
		public const int k_iClientMusicCallbacks = 3200; // Metadata: 0x0065138B
		public const int k_iClientRemoteClientManagerCallbacks = 3300; // Metadata: 0x0065138F
		public const int k_iClientUGCCallbacks = 3400; // Metadata: 0x00651393
		public const int k_iSteamStreamClientCallbacks = 3500; // Metadata: 0x00651397
		public const int k_IClientProductBuilderCallbacks = 3600; // Metadata: 0x0065139B
		public const int k_iClientShortcutsCallbacks = 3700; // Metadata: 0x0065139F
		public const int k_iClientRemoteControlManagerCallbacks = 3800; // Metadata: 0x006513A3
		public const int k_iSteamAppListCallbacks = 3900; // Metadata: 0x006513A7
		public const int k_iSteamMusicCallbacks = 4000; // Metadata: 0x006513AB
		public const int k_iSteamMusicRemoteCallbacks = 4100; // Metadata: 0x006513AF
		public const int k_iClientVRCallbacks = 4200; // Metadata: 0x006513B3
		public const int k_iClientGameNotificationCallbacks = 4300; // Metadata: 0x006513B7
		public const int k_iSteamGameNotificationCallbacks = 4400; // Metadata: 0x006513BB
		public const int k_iSteamHTMLSurfaceCallbacks = 4500; // Metadata: 0x006513BF
		public const int k_iClientVideoCallbacks = 4600; // Metadata: 0x006513C3
		public const int k_iClientInventoryCallbacks = 4700; // Metadata: 0x006513C7
		public const int k_iClientBluetoothManagerCallbacks = 4800; // Metadata: 0x006513CB
		public const int k_iClientSharedConnectionCallbacks = 4900; // Metadata: 0x006513CF
		public const int k_ISteamParentalSettingsCallbacks = 5000; // Metadata: 0x006513D3
		public const int k_iClientShaderCallbacks = 5100; // Metadata: 0x006513D7
		public const int k_iSteamGameSearchCallbacks = 5200; // Metadata: 0x006513DB
		public const int k_iSteamPartiesCallbacks = 5300; // Metadata: 0x006513DF
		public const int k_iClientPartiesCallbacks = 5400; // Metadata: 0x006513E3
		public const int k_iSteamSTARCallbacks = 5500; // Metadata: 0x006513E7
		public const int k_iClientSTARCallbacks = 5600; // Metadata: 0x006513EB
		public const int k_iSteamRemotePlayCallbacks = 5700; // Metadata: 0x006513EF
		public const int k_iClientCompatCallbacks = 5800; // Metadata: 0x006513F3
		public const int k_unSteamAccountIDMask = -1; // Metadata: 0x006513F7
		public const int k_unSteamAccountInstanceMask = 1048575; // Metadata: 0x006513FB
		public const int k_unSteamUserDefaultInstance = 1; // Metadata: 0x006513FF
		public const int k_cchGameExtraInfoMax = 64; // Metadata: 0x00651403
		public const int k_cbSteamDatagramMaxSerializedTicket = 512; // Metadata: 0x00651407
		public const int k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData = 2048; // Metadata: 0x0065140B
		public const int k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized = 4096; // Metadata: 0x0065140F
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32; // Metadata: 0x00651413
		public const int k_cchMaxSteamNetworkingErrMsg = 1024; // Metadata: 0x00651417
		public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128; // Metadata: 0x0065141B
		public const int k_cchSteamNetworkingMaxConnectionDescription = 128; // Metadata: 0x0065141F
		public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 524288; // Metadata: 0x00651423
		public const int k_nSteamNetworkingSend_Unreliable = 0; // Metadata: 0x00651427
		public const int k_nSteamNetworkingSend_NoNagle = 1; // Metadata: 0x0065142B
		public const int k_nSteamNetworkingSend_UnreliableNoNagle = 1; // Metadata: 0x0065142F
		public const int k_nSteamNetworkingSend_NoDelay = 4; // Metadata: 0x00651433
		public const int k_nSteamNetworkingSend_UnreliableNoDelay = 5; // Metadata: 0x00651437
		public const int k_nSteamNetworkingSend_Reliable = 8; // Metadata: 0x0065143B
		public const int k_nSteamNetworkingSend_ReliableNoNagle = 9; // Metadata: 0x0065143F
		public const int k_nSteamNetworkingSend_UseCurrentThread = 16; // Metadata: 0x00651443
		public const int k_cchMaxSteamNetworkingPingLocationString = 1024; // Metadata: 0x00651447
		public const int k_nSteamNetworkingPing_Failed = -1; // Metadata: 0x0065144B
		public const int k_nSteamNetworkingPing_Unknown = -2; // Metadata: 0x0065144F
		public const int k_cubSaltSize = 8; // Metadata: 0x00651453
		public const ulong k_GIDNil = 18446744073709551615; // Metadata: 0x00651457
		public const ulong k_TxnIDNil = 18446744073709551615; // Metadata: 0x0065145F
		public const ulong k_TxnIDUnknown = 0; // Metadata: 0x00651467
		public const int k_uPackageIdInvalid = -1; // Metadata: 0x0065146F
		public const ulong k_ulAssetClassIdInvalid = 0; // Metadata: 0x00651473
		public const int k_uPhysicalItemIdInvalid = 0; // Metadata: 0x0065147B
		public const int k_uCellIDInvalid = -1; // Metadata: 0x0065147F
		public const int k_uPartnerIdInvalid = 0; // Metadata: 0x00651483
		public const ulong k_ulPartyBeaconIdInvalid = 0; // Metadata: 0x00651487
		public const int STEAM_CONTROLLER_MAX_COUNT = 16; // Metadata: 0x0065148F
		public const int STEAM_CONTROLLER_MAX_ANALOG_ACTIONS = 16; // Metadata: 0x00651493
		public const int STEAM_CONTROLLER_MAX_DIGITAL_ACTIONS = 128; // Metadata: 0x00651497
		public const int STEAM_CONTROLLER_MAX_ORIGINS = 8; // Metadata: 0x0065149B
		public const int STEAM_CONTROLLER_MAX_ACTIVE_LAYERS = 16; // Metadata: 0x0065149F
		public const ulong STEAM_CONTROLLER_HANDLE_ALL_CONTROLLERS = 18446744073709551615; // Metadata: 0x006514A3
		public const float STEAM_CONTROLLER_MIN_ANALOG_ACTION_DATA = -1f; // Metadata: 0x006514AB
		public const float STEAM_CONTROLLER_MAX_ANALOG_ACTION_DATA = 1f; // Metadata: 0x006514AF
		public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = 65535; // Metadata: 0x006514B3
		public const int INVALID_HTTPREQUEST_HANDLE = 0; // Metadata: 0x006514B5
		public const int STEAM_INPUT_MAX_COUNT = 16; // Metadata: 0x006514B9
		public const int STEAM_INPUT_MAX_ANALOG_ACTIONS = 16; // Metadata: 0x006514BD
		public const int STEAM_INPUT_MAX_DIGITAL_ACTIONS = 128; // Metadata: 0x006514C1
		public const int STEAM_INPUT_MAX_ORIGINS = 8; // Metadata: 0x006514C5
		public const int STEAM_INPUT_MAX_ACTIVE_LAYERS = 16; // Metadata: 0x006514C9
		public const ulong STEAM_INPUT_HANDLE_ALL_CONTROLLERS = 18446744073709551615; // Metadata: 0x006514CD
		public const float STEAM_INPUT_MIN_ANALOG_ACTION_DATA = -1f; // Metadata: 0x006514D5
		public const float STEAM_INPUT_MAX_ANALOG_ACTION_DATA = 1f; // Metadata: 0x006514D9
		public const byte k_nMaxLobbyKeyLength = 255; // Metadata: 0x006514DD
		public const int k_SteamMusicNameMaxLength = 255; // Metadata: 0x006514DE
		public const int k_SteamMusicPNGMaxLength = 65535; // Metadata: 0x006514E2
		public const int QUERY_PORT_NOT_INITIALIZED = 65535; // Metadata: 0x006514E6
		public const int QUERY_PORT_ERROR = 65534; // Metadata: 0x006514EA
	}
}