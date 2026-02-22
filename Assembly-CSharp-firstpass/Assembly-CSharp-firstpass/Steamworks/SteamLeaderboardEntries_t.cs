using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000308 RID: 776
	[Serializable]
	[StructLayout(2)]
	public struct SteamLeaderboardEntries_t
	{
		// Token: 0x06002CB9 RID: 11449 RVA: 0x000BF5C0 File Offset: 0x000BD7C0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLeaderboardEntries_t()
		{
			Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamLeaderboardEntries_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr);
			SteamLeaderboardEntries_t.NativeFieldInfoPtr_m_SteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, "m_SteamLeaderboardEntries");
			SteamLeaderboardEntries_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669144);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669145);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669146);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669147);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669148);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669149);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669150);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669151);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669152);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100669153);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000BF6CC File Offset: 0x000BD8CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamLeaderboardEntries_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000BF700 File Offset: 0x000BD900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x000BF72C File Offset: 0x000BD92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211147, XrefRangeEnd = 211150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000BF770 File Offset: 0x000BD970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000BF7A0 File Offset: 0x000BD9A0
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000BF7EC File Offset: 0x000BD9EC
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000BF838 File Offset: 0x000BDA38
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000BF878 File Offset: 0x000BDA78
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000BF8B8 File Offset: 0x000BDAB8
		[CallerCount(0)]
		public unsafe bool Equals(SteamLeaderboardEntries_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamLeaderboardEntries_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000116B9 File Offset: 0x0000F8B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamLeaderboardEntries;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0;

		// Token: 0x04002AEC RID: 10988
		[FieldOffset(0)]
		public ulong m_SteamLeaderboardEntries;
	}
}
