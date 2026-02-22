using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FD RID: 765
	[Serializable]
	[StructLayout(2)]
	public struct AccountID_t
	{
		// Token: 0x06002C2A RID: 11306 RVA: 0x000BCFC8 File Offset: 0x000BB1C8
		// Note: this type is marked as 'beforefieldinit'.
		static AccountID_t()
		{
			Il2CppClassPointerStore<AccountID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AccountID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr);
			AccountID_t.NativeFieldInfoPtr_m_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, "m_AccountID");
			AccountID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669031);
			AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669032);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669033);
			AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669034);
			AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669035);
			AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669036);
			AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669037);
			AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669038);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669039);
			AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100669040);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000BD0D4 File Offset: 0x000BB2D4
		[CallerCount(0)]
		public unsafe AccountID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000BD108 File Offset: 0x000BB308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000BD134 File Offset: 0x000BB334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211049, XrefRangeEnd = 211052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000BD178 File Offset: 0x000BB378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000BD1A8 File Offset: 0x000BB3A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(AccountID_t x, AccountID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000BD1F4 File Offset: 0x000BB3F4
		[CallerCount(0)]
		public unsafe static bool operator !=(AccountID_t x, AccountID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000BD240 File Offset: 0x000BB440
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator AccountID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000BD280 File Offset: 0x000BB480
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(AccountID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000BD2C0 File Offset: 0x000BB4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000BD300 File Offset: 0x000BB500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00011583 File Offset: 0x0000F783
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeFieldInfoPtr_m_AccountID;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AccountID_t_UInt32_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AccountID_t_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0;

		// Token: 0x04002A61 RID: 10849
		[FieldOffset(0)]
		public uint m_AccountID;
	}
}
