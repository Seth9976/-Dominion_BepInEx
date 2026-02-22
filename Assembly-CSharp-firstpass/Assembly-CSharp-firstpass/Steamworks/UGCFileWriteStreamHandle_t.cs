using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FA RID: 762
	[Serializable]
	[StructLayout(2)]
	public struct UGCFileWriteStreamHandle_t
	{
		// Token: 0x06002C00 RID: 11264 RVA: 0x000BC4D0 File Offset: 0x000BA6D0
		// Note: this type is marked as 'beforefieldinit'.
		static UGCFileWriteStreamHandle_t()
		{
			Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCFileWriteStreamHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr);
			UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, "Invalid");
			UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_m_UGCFileWriteStreamHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, "m_UGCFileWriteStreamHandle");
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100668998);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100668999);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669000);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669001);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669002);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669003);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669004);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669005);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669006);
			UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, 100669007);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000BC5F0 File Offset: 0x000BA7F0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCFileWriteStreamHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000BC624 File Offset: 0x000BA824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000BC650 File Offset: 0x000BA850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211025, XrefRangeEnd = 211030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000BC694 File Offset: 0x000BA894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000BC6C4 File Offset: 0x000BA8C4
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000BC710 File Offset: 0x000BA910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211030, XrefRangeEnd = 211033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000BC75C File Offset: 0x000BA95C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000BC79C File Offset: 0x000BA99C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000BC7DC File Offset: 0x000BA9DC
		[CallerCount(0)]
		public unsafe bool Equals(UGCFileWriteStreamHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000BC81C File Offset: 0x000BAA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCFileWriteStreamHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00011523 File Offset: 0x0000F723
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCFileWriteStreamHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x000BC85C File Offset: 0x000BAA5C
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x00011535 File Offset: 0x0000F735
		public unsafe static UGCFileWriteStreamHandle_t Invalid
		{
			get
			{
				UGCFileWriteStreamHandle_t ugcfileWriteStreamHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcfileWriteStreamHandle_t));
				return ugcfileWriteStreamHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCFileWriteStreamHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCFileWriteStreamHandle;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCFileWriteStreamHandle_t_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCFileWriteStreamHandle_t_UInt64_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCFileWriteStreamHandle_t_0;

		// Token: 0x04002A3B RID: 10811
		[FieldOffset(0)]
		public ulong m_UGCFileWriteStreamHandle;
	}
}
