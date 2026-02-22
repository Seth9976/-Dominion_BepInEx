using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FF RID: 767
	[Serializable]
	[StructLayout(2)]
	public struct DepotId_t
	{
		// Token: 0x06002C44 RID: 11332 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
		// Note: this type is marked as 'beforefieldinit'.
		static DepotId_t()
		{
			Il2CppClassPointerStore<DepotId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DepotId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr);
			DepotId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, "Invalid");
			DepotId_t.NativeFieldInfoPtr_m_DepotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, "m_DepotId");
			DepotId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669052);
			DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669053);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669054);
			DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669055);
			DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669056);
			DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669057);
			DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669058);
			DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669059);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669060);
			DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100669061);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000BD808 File Offset: 0x000BBA08
		[CallerCount(0)]
		public unsafe DepotId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000BD83C File Offset: 0x000BBA3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000BD868 File Offset: 0x000BBA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211061, XrefRangeEnd = 211066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000BD8AC File Offset: 0x000BBAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000BD8DC File Offset: 0x000BBADC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DepotId_t x, DepotId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000BD928 File Offset: 0x000BBB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211066, XrefRangeEnd = 211069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DepotId_t x, DepotId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000BD974 File Offset: 0x000BBB74
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DepotId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000BD9B4 File Offset: 0x000BBBB4
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(DepotId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000BD9F4 File Offset: 0x000BBBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DepotId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000BDA34 File Offset: 0x000BBC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DepotId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000115B5 File Offset: 0x0000F7B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000BDA74 File Offset: 0x000BBC74
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x000115C7 File Offset: 0x0000F7C7
		public unsafe static DepotId_t Invalid
		{
			get
			{
				DepotId_t depotId_t;
				IL2CPP.il2cpp_field_static_get_value(DepotId_t.NativeFieldInfoPtr_Invalid, (void*)(&depotId_t));
				return depotId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepotId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeFieldInfoPtr_m_DepotId;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DepotId_t_UInt32_0;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_DepotId_t_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0;

		// Token: 0x04002A7B RID: 10875
		[FieldOffset(0)]
		public uint m_DepotId;
	}
}
