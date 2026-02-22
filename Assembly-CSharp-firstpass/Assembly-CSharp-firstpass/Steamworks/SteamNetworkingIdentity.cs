using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F2 RID: 754
	[Serializable]
	public sealed class SteamNetworkingIdentity : ValueType
	{
		// Token: 0x06002B70 RID: 11120 RVA: 0x000BA328 File Offset: 0x000B8528
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingIdentity()
		{
			Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr);
			SteamNetworkingIdentity.NativeFieldInfoPtr_m_eType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "m_eType");
			SteamNetworkingIdentity.NativeFieldInfoPtr_m_cbSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "m_cbSize");
			SteamNetworkingIdentity.NativeFieldInfoPtr_m_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "m_reserved");
			SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "k_cchMaxString");
			SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxGenericString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "k_cchMaxGenericString");
			SteamNetworkingIdentity.NativeFieldInfoPtr_k_cbMaxGenericBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, "k_cbMaxGenericBytes");
			SteamNetworkingIdentity.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668917);
			SteamNetworkingIdentity.NativeMethodInfoPtr_IsInvalid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668918);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetSteamID_Public_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668919);
			SteamNetworkingIdentity.NativeMethodInfoPtr_GetSteamID_Public_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668920);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetSteamID64_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668921);
			SteamNetworkingIdentity.NativeMethodInfoPtr_GetSteamID64_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668922);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetIPAddr_Public_Void_SteamNetworkingIPAddr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668923);
			SteamNetworkingIdentity.NativeMethodInfoPtr_GetIPAddr_Public_SteamNetworkingIPAddr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668924);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetLocalHost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668925);
			SteamNetworkingIdentity.NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668926);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetGenericString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668927);
			SteamNetworkingIdentity.NativeMethodInfoPtr_GetGenericString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668928);
			SteamNetworkingIdentity.NativeMethodInfoPtr_SetGenericBytes_Public_Boolean_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668929);
			SteamNetworkingIdentity.NativeMethodInfoPtr_GetGenericBytes_Public_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668930);
			SteamNetworkingIdentity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668931);
			SteamNetworkingIdentity.NativeMethodInfoPtr_ToString_Public_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668932);
			SteamNetworkingIdentity.NativeMethodInfoPtr_ParseString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, 100668933);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000BA524 File Offset: 0x000B8724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210916, XrefRangeEnd = 210917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000BA55C File Offset: 0x000B875C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210917, XrefRangeEnd = 210918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_IsInvalid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000BA5A0 File Offset: 0x000B87A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210918, XrefRangeEnd = 210922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteamID(CSteamID steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetSteamID_Public_Void_CSteamID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000BA5E4 File Offset: 0x000B87E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210922, XrefRangeEnd = 210927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CSteamID GetSteamID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_GetSteamID_Public_CSteamID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000BA628 File Offset: 0x000B8828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210927, XrefRangeEnd = 210928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteamID64(ulong steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetSteamID64_Public_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000BA66C File Offset: 0x000B886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210928, XrefRangeEnd = 210929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetSteamID64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_GetSteamID64_Public_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000BA6B0 File Offset: 0x000B88B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210929, XrefRangeEnd = 210930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPAddr(SteamNetworkingIPAddr addr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(addr));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetIPAddr_Public_Void_SteamNetworkingIPAddr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000BA6FC File Offset: 0x000B88FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210930, XrefRangeEnd = 210935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamNetworkingIPAddr GetIPAddr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_GetIPAddr_Public_SteamNetworkingIPAddr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SteamNetworkingIPAddr(intPtr);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000BA738 File Offset: 0x000B8938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210935, XrefRangeEnd = 210936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetLocalHost_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000BA770 File Offset: 0x000B8970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210936, XrefRangeEnd = 210937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000BA7B4 File Offset: 0x000B89B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210937, XrefRangeEnd = 210946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGenericString(string pszString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetGenericString_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000BA808 File Offset: 0x000B8A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210946, XrefRangeEnd = 210948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGenericString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_GetGenericString_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000BA844 File Offset: 0x000B8A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210948, XrefRangeEnd = 210949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetGenericBytes(Il2CppStructArray<byte> data, uint cbLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_SetGenericBytes_Public_Boolean_Il2CppStructArray_1_Byte_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000BA8A4 File Offset: 0x000B8AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210949, XrefRangeEnd = 210954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetGenericBytes(out int cbLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cbLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_GetGenericBytes_Public_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000BA8F8 File Offset: 0x000B8AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210954, XrefRangeEnd = 210955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SteamNetworkingIdentity x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIdentity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000BA950 File Offset: 0x000B8B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210955, XrefRangeEnd = 210962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToString(out string buf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_ToString_Public_Void_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				buf = IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000BA9A0 File Offset: 0x000B8BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210962, XrefRangeEnd = 210971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseString(string pszStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszStr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIdentity.NativeMethodInfoPtr_ParseString_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0001123E File Offset: 0x0000F43E
		public SteamNetworkingIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00011247 File Offset: 0x0000F447
		public SteamNetworkingIdentity()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr))
		{
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000BA9F4 File Offset: 0x000B8BF4
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00011259 File Offset: 0x0000F459
		public unsafe ESteamNetworkingIdentityType m_eType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_eType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_eType)) = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000BAA1C File Offset: 0x000B8C1C
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00011274 File Offset: 0x0000F474
		public unsafe int m_cbSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_cbSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_cbSize)) = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000BAA44 File Offset: 0x000B8C44
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0001128F File Offset: 0x0000F48F
		public unsafe Il2CppStructArray<uint> m_reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_reserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIdentity.NativeFieldInfoPtr_m_reserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000BAA74 File Offset: 0x000B8C74
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x000112AE File Offset: 0x0000F4AE
		public unsafe static int k_cchMaxString
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxString, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxString, (void*)(&value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000BAA90 File Offset: 0x000B8C90
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x000112BC File Offset: 0x0000F4BC
		public unsafe static int k_cchMaxGenericString
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxGenericString, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cchMaxGenericString, (void*)(&value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000BAAAC File Offset: 0x000B8CAC
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x000112CA File Offset: 0x0000F4CA
		public unsafe static int k_cbMaxGenericBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cbMaxGenericBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingIdentity.NativeFieldInfoPtr_k_cbMaxGenericBytes, (void*)(&value));
			}
		}

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeFieldInfoPtr_m_eType;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeFieldInfoPtr_m_cbSize;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeFieldInfoPtr_m_reserved;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeFieldInfoPtr_k_cchMaxString;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeFieldInfoPtr_k_cchMaxGenericString;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeFieldInfoPtr_k_cbMaxGenericBytes;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalid_Public_Boolean_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeMethodInfoPtr_SetSteamID_Public_Void_CSteamID_0;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Public_CSteamID_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_SetSteamID64_Public_Void_UInt64_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID64_Public_UInt64_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_SetIPAddr_Public_Void_SteamNetworkingIPAddr_0;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeMethodInfoPtr_GetIPAddr_Public_SteamNetworkingIPAddr_0;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalHost_Public_Void_0;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_SetGenericString_Public_Boolean_String_0;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericString_Public_String_0;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_SetGenericBytes_Public_Boolean_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericBytes_Public_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIdentity_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Void_byref_String_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Public_Boolean_String_0;
	}
}
