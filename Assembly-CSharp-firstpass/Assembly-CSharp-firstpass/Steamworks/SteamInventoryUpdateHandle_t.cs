using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	[StructLayout(2)]
	public struct SteamInventoryUpdateHandle_t
	{
		// Token: 0x06002AD4 RID: 10964 RVA: 0x000B7B54 File Offset: 0x000B5D54
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryUpdateHandle_t()
		{
			Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr);
			SteamInventoryUpdateHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, "Invalid");
			SteamInventoryUpdateHandle_t.NativeFieldInfoPtr_m_SteamInventoryUpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, "m_SteamInventoryUpdateHandle");
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668803);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668804);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668805);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668806);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668807);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668808);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668809);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668810);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668811);
			SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, 100668812);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000B7C74 File Offset: 0x000B5E74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamInventoryUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000B7CD4 File Offset: 0x000B5ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210833, XrefRangeEnd = 210838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000B7D18 File Offset: 0x000B5F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000B7D48 File Offset: 0x000B5F48
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000B7D94 File Offset: 0x000B5F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210838, XrefRangeEnd = 210841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000B7DE0 File Offset: 0x000B5FE0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000B7E20 File Offset: 0x000B6020
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamInventoryUpdateHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000B7E60 File Offset: 0x000B6060
		[CallerCount(0)]
		public unsafe bool Equals(SteamInventoryUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000B7EA0 File Offset: 0x000B60A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0001104F File Offset: 0x0000F24F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x000B7EE0 File Offset: 0x000B60E0
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x00011061 File Offset: 0x0000F261
		public unsafe static SteamInventoryUpdateHandle_t Invalid
		{
			get
			{
				SteamInventoryUpdateHandle_t steamInventoryUpdateHandle_t;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&steamInventoryUpdateHandle_t));
				return steamInventoryUpdateHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamInventoryUpdateHandle;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryUpdateHandle_t_UInt64_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryUpdateHandle_t_0;

		// Token: 0x0400293F RID: 10559
		[FieldOffset(0)]
		public ulong m_SteamInventoryUpdateHandle;
	}
}
