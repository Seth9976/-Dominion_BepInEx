using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	[StructLayout(2)]
	public struct ValueTuple
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00035AA0 File Offset: 0x00033CA0
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueTuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr);
			ValueTuple.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664011);
			ValueTuple.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664012);
			ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664013);
			ValueTuple.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664014);
			ValueTuple.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664015);
			ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664016);
			ValueTuple.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664017);
			ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664018);
			ValueTuple.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664019);
			ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664020);
			ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664021);
			ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664022);
			ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, 100664023);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00035BD4 File Offset: 0x00033DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266579, XrefRangeEnd = 266581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00035C18 File Offset: 0x00033E18
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTuple other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00035C58 File Offset: 0x00033E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266581, XrefRangeEnd = 266583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00035CAC File Offset: 0x00033EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266583, XrefRangeEnd = 266585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00035CF0 File Offset: 0x00033EF0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ValueTuple other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00035D30 File Offset: 0x00033F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266585, XrefRangeEnd = 266587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00035D84 File Offset: 0x00033F84
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00035DB4 File Offset: 0x00033FB4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00035DF8 File Offset: 0x00033FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266587, XrefRangeEnd = 266589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00035E24 File Offset: 0x00034024
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266595, RefRangeEnd = 266598, XrefRangeStart = 266589, XrefRangeEnd = 266595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00035E70 File Offset: 0x00034070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266608, RefRangeEnd = 266610, XrefRangeStart = 266598, XrefRangeEnd = 266608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00035ECC File Offset: 0x000340CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266624, RefRangeEnd = 266626, XrefRangeStart = 266610, XrefRangeEnd = 266624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00035F34 File Offset: 0x00034134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266644, RefRangeEnd = 266646, XrefRangeStart = 266626, XrefRangeEnd = 266644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003E0B File Offset: 0x0000200B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, ref this));
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_Int32_0;
	}
}
