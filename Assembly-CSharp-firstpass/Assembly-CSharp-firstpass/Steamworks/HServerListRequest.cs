using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E6 RID: 742
	[Serializable]
	[StructLayout(2)]
	public struct HServerListRequest
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x000B861C File Offset: 0x000B681C
		// Note: this type is marked as 'beforefieldinit'.
		static HServerListRequest()
		{
			Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HServerListRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr);
			HServerListRequest.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, "Invalid");
			HServerListRequest.NativeFieldInfoPtr_m_HServerListRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, "m_HServerListRequest");
			HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668836);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668837);
			HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668838);
			HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668839);
			HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668840);
			HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668841);
			HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668842);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100668843);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000B8714 File Offset: 0x000B6914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210852, XrefRangeEnd = 210856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000B8740 File Offset: 0x000B6940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210856, XrefRangeEnd = 210862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000B8784 File Offset: 0x000B6984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000B87B4 File Offset: 0x000B69B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210863, RefRangeEnd = 210865, XrefRangeStart = 210862, XrefRangeEnd = 210863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000B8800 File Offset: 0x000B6A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210865, XrefRangeEnd = 210869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000B884C File Offset: 0x000B6A4C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HServerListRequest(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000B888C File Offset: 0x000B6A8C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(HServerListRequest that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000B88CC File Offset: 0x000B6ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210869, XrefRangeEnd = 210870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HServerListRequest other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000110A1 File Offset: 0x0000F2A1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x000B890C File Offset: 0x000B6B0C
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x000110B3 File Offset: 0x0000F2B3
		public unsafe static HServerListRequest Invalid
		{
			get
			{
				HServerListRequest hserverListRequest;
				IL2CPP.il2cpp_field_static_get_value(HServerListRequest.NativeFieldInfoPtr_Invalid, (void*)(&hserverListRequest));
				return hserverListRequest;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HServerListRequest.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeFieldInfoPtr_m_HServerListRequest;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HServerListRequest_IntPtr_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_HServerListRequest_0;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0;

		// Token: 0x04002963 RID: 10595
		[FieldOffset(0)]
		public IntPtr m_HServerListRequest;
	}
}
