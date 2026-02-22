using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D6 RID: 726
	[Serializable]
	[StructLayout(2)]
	public struct ControllerDigitalActionHandle_t
	{
		// Token: 0x06002A26 RID: 10790 RVA: 0x000B5058 File Offset: 0x000B3258
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerDigitalActionHandle_t()
		{
			Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerDigitalActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr);
			ControllerDigitalActionHandle_t.NativeFieldInfoPtr_m_ControllerDigitalActionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, "m_ControllerDigitalActionHandle");
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668686);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668687);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668688);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668689);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668690);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668691);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerDigitalActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668692);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668693);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668694);
			ControllerDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, 100668695);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000B5164 File Offset: 0x000B3364
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerDigitalActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000B5198 File Offset: 0x000B3398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000B51C4 File Offset: 0x000B33C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210753, XrefRangeEnd = 210756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000B5208 File Offset: 0x000B3408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000B5238 File Offset: 0x000B3438
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000B5284 File Offset: 0x000B3484
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000B52D0 File Offset: 0x000B34D0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerDigitalActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000B5310 File Offset: 0x000B3510
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ControllerDigitalActionHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000B5350 File Offset: 0x000B3550
		[CallerCount(0)]
		public unsafe bool Equals(ControllerDigitalActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000B5390 File Offset: 0x000B3590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ControllerDigitalActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00010D95 File Offset: 0x0000EF95
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerDigitalActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeFieldInfoPtr_m_ControllerDigitalActionHandle;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerDigitalActionHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerDigitalActionHandle_t_UInt64_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerDigitalActionHandle_t_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerDigitalActionHandle_t_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerDigitalActionHandle_t_0;

		// Token: 0x040028A7 RID: 10407
		[FieldOffset(0)]
		public ulong m_ControllerDigitalActionHandle;
	}
}
