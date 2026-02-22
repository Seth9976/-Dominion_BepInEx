using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B2 RID: 690
	public sealed class MatchMakingKeyValuePair_t : ValueType
	{
		// Token: 0x0600278D RID: 10125 RVA: 0x000ACB00 File Offset: 0x000AAD00
		// Note: this type is marked as 'beforefieldinit'.
		static MatchMakingKeyValuePair_t()
		{
			Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MatchMakingKeyValuePair_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr);
			MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, "m_szKey_");
			MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, "m_szValue_");
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr__ctor_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100668389);
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr_get_m_szKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100668390);
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr_set_m_szKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100668391);
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr_get_m_szValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100668392);
			MatchMakingKeyValuePair_t.NativeMethodInfoPtr_set_m_szValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr, 100668393);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000ACBBC File Offset: 0x000AADBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206890, XrefRangeEnd = 206892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchMakingKeyValuePair_t(string strKey, string strValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr__ctor_Private_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000ACC20 File Offset: 0x000AAE20
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x000ACC5C File Offset: 0x000AAE5C
		public unsafe string m_szKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr_get_m_szKey_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr_set_m_szKey_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000ACCA4 File Offset: 0x000AAEA4
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
		public unsafe string m_szValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr_get_m_szValue_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair_t.NativeMethodInfoPtr_set_m_szValue_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x0000FE13 File Offset: 0x0000E013
		public MatchMakingKeyValuePair_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x0000FE1C File Offset: 0x0000E01C
		public MatchMakingKeyValuePair_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchMakingKeyValuePair_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000ACD28 File Offset: 0x000AAF28
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x0000FE2E File Offset: 0x0000E02E
		public unsafe Il2CppStructArray<byte> m_szKey_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szKey_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x000ACD58 File Offset: 0x000AAF58
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x0000FE4D File Offset: 0x0000E04D
		public unsafe Il2CppStructArray<byte> m_szValue_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair_t.NativeFieldInfoPtr_m_szValue_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeFieldInfoPtr_m_szKey_;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeFieldInfoPtr_m_szValue_;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szKey_Public_get_String_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szKey_Public_set_Void_String_0;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szValue_Public_get_String_0;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szValue_Public_set_Void_String_0;
	}
}
