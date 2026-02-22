using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D4 RID: 724
	[Serializable]
	[StructLayout(2)]
	public struct ControllerActionSetHandle_t
	{
		// Token: 0x06002A0E RID: 10766 RVA: 0x000B4968 File Offset: 0x000B2B68
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerActionSetHandle_t()
		{
			Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerActionSetHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr);
			ControllerActionSetHandle_t.NativeFieldInfoPtr_m_ControllerActionSetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, "m_ControllerActionSetHandle");
			ControllerActionSetHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668666);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668667);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668668);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668669);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668670);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668671);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerActionSetHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668672);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668673);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668674);
			ControllerActionSetHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, 100668675);
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000B4A74 File Offset: 0x000B2C74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerActionSetHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000B4AD4 File Offset: 0x000B2CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210747, XrefRangeEnd = 210750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000B4B18 File Offset: 0x000B2D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000B4B48 File Offset: 0x000B2D48
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000B4B94 File Offset: 0x000B2D94
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000B4BE0 File Offset: 0x000B2DE0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ControllerActionSetHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerActionSetHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000B4C20 File Offset: 0x000B2E20
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ControllerActionSetHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000B4C60 File Offset: 0x000B2E60
		[CallerCount(0)]
		public unsafe bool Equals(ControllerActionSetHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerActionSetHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000B4CA0 File Offset: 0x000B2EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ControllerActionSetHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerActionSetHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerActionSetHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00010D71 File Offset: 0x0000EF71
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerActionSetHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr_m_ControllerActionSetHandle;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerActionSetHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerActionSetHandle_t_UInt64_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerActionSetHandle_t_0;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerActionSetHandle_t_0;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerActionSetHandle_t_0;

		// Token: 0x0400288F RID: 10383
		[FieldOffset(0)]
		public ulong m_ControllerActionSetHandle;
	}
}
