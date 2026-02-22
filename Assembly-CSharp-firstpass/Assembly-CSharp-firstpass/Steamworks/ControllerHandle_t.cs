using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D7 RID: 727
	[Serializable]
	[StructLayout(2)]
	public struct ControllerHandle_t
	{
		// Token: 0x06002A32 RID: 10802 RVA: 0x000B53D0 File Offset: 0x000B35D0
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerHandle_t()
		{
			Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr);
			ControllerHandle_t.NativeFieldInfoPtr_m_ControllerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, "m_ControllerHandle");
			ControllerHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668696);
			ControllerHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668697);
			ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668698);
			ControllerHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668699);
			ControllerHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668700);
			ControllerHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668701);
			ControllerHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668702);
			ControllerHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668703);
			ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668704);
			ControllerHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100668705);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000B54DC File Offset: 0x000B36DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000B5510 File Offset: 0x000B3710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000B553C File Offset: 0x000B373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210756, XrefRangeEnd = 210759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000B5580 File Offset: 0x000B3780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000B55B0 File Offset: 0x000B37B0
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ControllerHandle_t x, ControllerHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000B55FC File Offset: 0x000B37FC
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerHandle_t x, ControllerHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000B5648 File Offset: 0x000B3848
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ControllerHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000B5688 File Offset: 0x000B3888
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ControllerHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000B56C8 File Offset: 0x000B38C8
		[CallerCount(0)]
		public unsafe bool Equals(ControllerHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000B5708 File Offset: 0x000B3908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ControllerHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00010DA7 File Offset: 0x0000EFA7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeFieldInfoPtr_m_ControllerHandle;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerHandle_t_UInt64_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerHandle_t_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0;

		// Token: 0x040028B3 RID: 10419
		[FieldOffset(0)]
		public ulong m_ControllerHandle;
	}
}
