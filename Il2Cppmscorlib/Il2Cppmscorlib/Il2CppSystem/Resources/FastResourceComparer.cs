using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017A RID: 378
	public sealed class FastResourceComparer : Object
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x000995E8 File Offset: 0x000977E8
		// Note: this type is marked as 'beforefieldinit'.
		static FastResourceComparer()
		{
			Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "FastResourceComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr);
			FastResourceComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, "Default");
			FastResourceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667740);
			FastResourceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667741);
			FastResourceComparer.NativeMethodInfoPtr_HashFunction_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667742);
			FastResourceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667743);
			FastResourceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667744);
			FastResourceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667745);
			FastResourceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667746);
			FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667747);
			FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667748);
			FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667749);
			FastResourceComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr, 100667750);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00099708 File Offset: 0x00097908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315358, XrefRangeEnd = 315365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCode(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00099758 File Offset: 0x00097958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315365, XrefRangeEnd = 315370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCode(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000997A8 File Offset: 0x000979A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315372, RefRangeEnd = 315373, XrefRangeStart = 315370, XrefRangeEnd = 315372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HashFunction(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_HashFunction_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000997EC File Offset: 0x000979EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315373, XrefRangeEnd = 315376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0009984C File Offset: 0x00097A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315376, XrefRangeEnd = 315377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string a, string b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000998AC File Offset: 0x00097AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315377, XrefRangeEnd = 315378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string a, string b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0009990C File Offset: 0x00097B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315378, XrefRangeEnd = 315381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0009996C File Offset: 0x00097B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315381, XrefRangeEnd = 315382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string a, Il2CppStructArray<byte> bytes, int bCharLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCharLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000999D0 File Offset: 0x00097BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315388, RefRangeEnd = 315389, XrefRangeStart = 315382, XrefRangeEnd = 315388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(Il2CppStructArray<byte> bytes, int aCharLength, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aCharLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00099A34 File Offset: 0x00097C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315389, XrefRangeEnd = 315390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(byte* a, int byteLen, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ptr_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00099A90 File Offset: 0x00097C90
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastResourceComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastResourceComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastResourceComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00008F89 File Offset: 0x00007189
		public FastResourceComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00099ACC File Offset: 0x00097CCC
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00008F92 File Offset: 0x00007192
		public unsafe static FastResourceComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastResourceComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastResourceComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastResourceComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_HashFunction_Internal_Static_Int32_String_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ptr_Byte_Int32_String_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
