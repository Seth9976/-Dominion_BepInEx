using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	public class PlayerConnectionInternal : Object
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnectionInternal()
		{
			Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerConnectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664224);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664225);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664226);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664227);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664228);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664229);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664230);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664231);
			PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664232);
			PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664233);
			PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664234);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664235);
			PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664236);
			PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664237);
			PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664238);
			PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664239);
			PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100664240);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003EB44 File Offset: 0x0003CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67526, XrefRangeEnd = 67536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0003EBA4 File Offset: 0x0003CDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67536, XrefRangeEnd = 67546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0003EC10 File Offset: 0x0003CE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67546, XrefRangeEnd = 67548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0003EC44 File Offset: 0x0003CE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67548, XrefRangeEnd = 67553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0003EC84 File Offset: 0x0003CE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67553, XrefRangeEnd = 67558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67558, XrefRangeEnd = 67560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67560, XrefRangeEnd = 67562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0003ED34 File Offset: 0x0003CF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67562, XrefRangeEnd = 67564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0003ED68 File Offset: 0x0003CF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConnected()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0003ED98 File Offset: 0x0003CF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67564, XrefRangeEnd = 67566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternal(string messageId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67566, XrefRangeEnd = 67568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterInternal(string messageId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0003EE30 File Offset: 0x0003D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67568, XrefRangeEnd = 67570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0003EE88 File Offset: 0x0003D088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67570, XrefRangeEnd = 67572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0003EEEC File Offset: 0x0003D0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PollInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0003EF14 File Offset: 0x0003D114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0003EF3C File Offset: 0x0003D13C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00009959 File Offset: 0x00007B59
		public PlayerConnectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_PollInternal_Private_Static_Void_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000759 RID: 1881
		public enum MulticastFlags
		{
			// Token: 0x04001C79 RID: 7289
			kRequestImmediateConnect = 1,
			// Token: 0x04001C7A RID: 7290
			kSupportsProfile,
			// Token: 0x04001C7B RID: 7291
			kCustomMessage = 4,
			// Token: 0x04001C7C RID: 7292
			kUseAlternateIP = 8
		}
	}
}
