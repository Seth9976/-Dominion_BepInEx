using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002EF RID: 751
	[Serializable]
	[StructLayout(2)]
	public struct HSteamNetPollGroup
	{
		// Token: 0x06002B5B RID: 11099 RVA: 0x000B9EE4 File Offset: 0x000B80E4
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamNetPollGroup()
		{
			Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamNetPollGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr);
			HSteamNetPollGroup.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, "Invalid");
			HSteamNetPollGroup.NativeFieldInfoPtr_m_HSteamNetPollGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, "m_HSteamNetPollGroup");
			HSteamNetPollGroup.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668906);
			HSteamNetPollGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668907);
			HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668908);
			HSteamNetPollGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668909);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668910);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668911);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetPollGroup_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668912);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668913);
			HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668914);
			HSteamNetPollGroup.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100668915);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000BA004 File Offset: 0x000B8204
		[CallerCount(0)]
		public unsafe HSteamNetPollGroup(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000BA038 File Offset: 0x000B8238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000BA064 File Offset: 0x000B8264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210908, XrefRangeEnd = 210913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000BA0A8 File Offset: 0x000B82A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000BA0D8 File Offset: 0x000B82D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000BA124 File Offset: 0x000B8324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210913, XrefRangeEnd = 210916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamNetPollGroup x, HSteamNetPollGroup y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000BA170 File Offset: 0x000B8370
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HSteamNetPollGroup(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetPollGroup_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000BA1B0 File Offset: 0x000B83B0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HSteamNetPollGroup that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000BA1F0 File Offset: 0x000B83F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HSteamNetPollGroup other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000BA230 File Offset: 0x000B8430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamNetPollGroup other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00011199 File Offset: 0x0000F399
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, ref this));
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000BA270 File Offset: 0x000B8470
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x000111AB File Offset: 0x0000F3AB
		public unsafe static HSteamNetPollGroup Invalid
		{
			get
			{
				HSteamNetPollGroup hsteamNetPollGroup;
				IL2CPP.il2cpp_field_static_get_value(HSteamNetPollGroup.NativeFieldInfoPtr_Invalid, (void*)(&hsteamNetPollGroup));
				return hsteamNetPollGroup;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HSteamNetPollGroup.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamNetPollGroup;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamNetPollGroup_UInt32_0;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HSteamNetPollGroup_0;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0;

		// Token: 0x040029B7 RID: 10679
		[FieldOffset(0)]
		public uint m_HSteamNetPollGroup;
	}
}
