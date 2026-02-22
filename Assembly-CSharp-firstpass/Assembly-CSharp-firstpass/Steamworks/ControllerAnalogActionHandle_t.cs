using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D5 RID: 725
	[Serializable]
	[StructLayout(2)]
	public struct ControllerAnalogActionHandle_t
	{
		// Token: 0x06002A1A RID: 10778 RVA: 0x000B4CE0 File Offset: 0x000B2EE0
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerAnalogActionHandle_t()
		{
			Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerAnalogActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr);
			ControllerAnalogActionHandle_t.NativeFieldInfoPtr_m_ControllerAnalogActionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, "m_ControllerAnalogActionHandle");
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668676);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668677);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668678);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668679);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668680);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668681);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668682);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668683);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668684);
			ControllerAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, 100668685);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000B4DEC File Offset: 0x000B2FEC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000B4E20 File Offset: 0x000B3020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000B4E4C File Offset: 0x000B304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210750, XrefRangeEnd = 210753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000B4E90 File Offset: 0x000B3090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000B4EC0 File Offset: 0x000B30C0
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000B4F0C File Offset: 0x000B310C
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000B4F58 File Offset: 0x000B3158
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000B4F98 File Offset: 0x000B3198
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000B4FD8 File Offset: 0x000B31D8
		[CallerCount(0)]
		public unsafe bool Equals(ControllerAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000B5018 File Offset: 0x000B3218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ControllerAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00010D83 File Offset: 0x0000EF83
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerAnalogActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeFieldInfoPtr_m_ControllerAnalogActionHandle;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerAnalogActionHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ControllerAnalogActionHandle_t_UInt64_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_ControllerAnalogActionHandle_t_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerAnalogActionHandle_t_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerAnalogActionHandle_t_0;

		// Token: 0x0400289B RID: 10395
		[FieldOffset(0)]
		public ulong m_ControllerAnalogActionHandle;
	}
}
