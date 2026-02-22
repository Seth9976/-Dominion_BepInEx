using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F7 RID: 759
	[Serializable]
	[StructLayout(2)]
	public struct RemotePlaySessionID_t
	{
		// Token: 0x06002BD8 RID: 11224 RVA: 0x000BBA08 File Offset: 0x000B9C08
		// Note: this type is marked as 'beforefieldinit'.
		static RemotePlaySessionID_t()
		{
			Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemotePlaySessionID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr);
			RemotePlaySessionID_t.NativeFieldInfoPtr_m_RemotePlaySessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, "m_RemotePlaySessionID");
			RemotePlaySessionID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668966);
			RemotePlaySessionID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668967);
			RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668968);
			RemotePlaySessionID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668969);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668970);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668971);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_RemotePlaySessionID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668972);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668973);
			RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668974);
			RemotePlaySessionID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100668975);
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000BBB14 File Offset: 0x000B9D14
		[CallerCount(0)]
		public unsafe RemotePlaySessionID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000BBB48 File Offset: 0x000B9D48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000BBB74 File Offset: 0x000B9D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211006, XrefRangeEnd = 211009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000BBBB8 File Offset: 0x000B9DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000BBBE8 File Offset: 0x000B9DE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000BBC34 File Offset: 0x000B9E34
		[CallerCount(0)]
		public unsafe static bool operator !=(RemotePlaySessionID_t x, RemotePlaySessionID_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000BBC80 File Offset: 0x000B9E80
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator RemotePlaySessionID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_RemotePlaySessionID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000BBCC0 File Offset: 0x000B9EC0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(RemotePlaySessionID_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000BBD00 File Offset: 0x000B9F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RemotePlaySessionID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000BBD40 File Offset: 0x000B9F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RemotePlaySessionID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000114D1 File Offset: 0x0000F6D1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeFieldInfoPtr_m_RemotePlaySessionID;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_RemotePlaySessionID_t_UInt32_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RemotePlaySessionID_t_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0;

		// Token: 0x04002A14 RID: 10772
		[FieldOffset(0)]
		public uint m_RemotePlaySessionID;
	}
}
