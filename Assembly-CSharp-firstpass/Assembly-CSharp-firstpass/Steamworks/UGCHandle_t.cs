using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FB RID: 763
	[Serializable]
	[StructLayout(2)]
	public struct UGCHandle_t
	{
		// Token: 0x06002C0E RID: 11278 RVA: 0x000BC878 File Offset: 0x000BAA78
		// Note: this type is marked as 'beforefieldinit'.
		static UGCHandle_t()
		{
			Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr);
			UGCHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, "Invalid");
			UGCHandle_t.NativeFieldInfoPtr_m_UGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, "m_UGCHandle");
			UGCHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669009);
			UGCHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669010);
			UGCHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669011);
			UGCHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669012);
			UGCHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669013);
			UGCHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669014);
			UGCHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669015);
			UGCHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669016);
			UGCHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669017);
			UGCHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, 100669018);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000BC998 File Offset: 0x000BAB98
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000BC9CC File Offset: 0x000BABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000BC9F8 File Offset: 0x000BABF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211033, XrefRangeEnd = 211038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000BCA3C File Offset: 0x000BAC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000BCA6C File Offset: 0x000BAC6C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000BCAB8 File Offset: 0x000BACB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211038, XrefRangeEnd = 211041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000BCB04 File Offset: 0x000BAD04
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000BCB44 File Offset: 0x000BAD44
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000BCB84 File Offset: 0x000BAD84
		[CallerCount(0)]
		public unsafe bool Equals(UGCHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000BCBC4 File Offset: 0x000BADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(UGCHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00011543 File Offset: 0x0000F743
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000BCC04 File Offset: 0x000BAE04
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00011555 File Offset: 0x0000F755
		public unsafe static UGCHandle_t Invalid
		{
			get
			{
				UGCHandle_t ugchandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugchandle_t));
				return ugchandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCHandle;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCHandle_t_UGCHandle_t_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCHandle_t_UInt64_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCHandle_t_0;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCHandle_t_0;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCHandle_t_0;

		// Token: 0x04002A48 RID: 10824
		[FieldOffset(0)]
		public ulong m_UGCHandle;
	}
}
