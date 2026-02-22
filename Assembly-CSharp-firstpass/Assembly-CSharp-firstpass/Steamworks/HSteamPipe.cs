using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200030A RID: 778
	[Serializable]
	[StructLayout(2)]
	public struct HSteamPipe
	{
		// Token: 0x06002CD1 RID: 11473 RVA: 0x000BFCB0 File Offset: 0x000BDEB0
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamPipe()
		{
			Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HSteamPipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr);
			HSteamPipe.NativeFieldInfoPtr_m_HSteamPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, "m_HSteamPipe");
			HSteamPipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669164);
			HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669165);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669166);
			HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669167);
			HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669168);
			HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669169);
			HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669170);
			HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669171);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669172);
			HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100669173);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000BFDBC File Offset: 0x000BDFBC
		[CallerCount(0)]
		public unsafe HSteamPipe(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000BFDF0 File Offset: 0x000BDFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000BFE1C File Offset: 0x000BE01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211153, XrefRangeEnd = 211156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000BFE60 File Offset: 0x000BE060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000BFE90 File Offset: 0x000BE090
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000BFEDC File Offset: 0x000BE0DC
		[CallerCount(0)]
		public unsafe static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000BFF28 File Offset: 0x000BE128
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HSteamPipe(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000BFF68 File Offset: 0x000BE168
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(HSteamPipe that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000BFFA8 File Offset: 0x000BE1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HSteamPipe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000BFFE8 File Offset: 0x000BE1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamPipe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000116DD File Offset: 0x0000F8DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, ref this));
		}

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeFieldInfoPtr_m_HSteamPipe;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HSteamPipe_Int32_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HSteamPipe_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0;

		// Token: 0x04002B04 RID: 11012
		[FieldOffset(0)]
		public int m_HSteamPipe;
	}
}
