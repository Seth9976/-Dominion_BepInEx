using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E4 RID: 740
	[Serializable]
	[StructLayout(2)]
	public struct SteamItemDef_t
	{
		// Token: 0x06002AE2 RID: 10978 RVA: 0x000B7EFC File Offset: 0x000B60FC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemDef_t()
		{
			Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamItemDef_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr);
			SteamItemDef_t.NativeFieldInfoPtr_m_SteamItemDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, "m_SteamItemDef");
			SteamItemDef_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668814);
			SteamItemDef_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668815);
			SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668816);
			SteamItemDef_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668817);
			SteamItemDef_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668818);
			SteamItemDef_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668819);
			SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668820);
			SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668821);
			SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668822);
			SteamItemDef_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, 100668823);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000B8008 File Offset: 0x000B6208
		[CallerCount(0)]
		public unsafe SteamItemDef_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000B803C File Offset: 0x000B623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000B8068 File Offset: 0x000B6268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210841, XrefRangeEnd = 210844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000B80AC File Offset: 0x000B62AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000B80DC File Offset: 0x000B62DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000B8128 File Offset: 0x000B6328
		[CallerCount(0)]
		public unsafe static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000B8174 File Offset: 0x000B6374
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamItemDef_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000B81B4 File Offset: 0x000B63B4
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(SteamItemDef_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000B81F4 File Offset: 0x000B63F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SteamItemDef_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000B8234 File Offset: 0x000B6434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamItemDef_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamItemDef_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0001106F File Offset: 0x0000F26F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemDef_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamItemDef;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamItemDef_t_SteamItemDef_t_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamItemDef_t_Int32_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamItemDef_t_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamItemDef_t_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamItemDef_t_0;

		// Token: 0x0400294B RID: 10571
		[FieldOffset(0)]
		public int m_SteamItemDef;
	}
}
