using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000146 RID: 326
	[Serializable]
	public class ValueType : Object
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00088F48 File Offset: 0x00087148
		// Note: this type is marked as 'beforefieldinit'.
		static ValueType()
		{
			Il2CppClassPointerStore<ValueType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueType>.NativeClassPtr);
			ValueType.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667141);
			ValueType.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667142);
			ValueType.NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667143);
			ValueType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667144);
			ValueType.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667145);
			ValueType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667146);
			ValueType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667147);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00089004 File Offset: 0x00087204
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00089040 File Offset: 0x00087240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309402, XrefRangeEnd = 309403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalEquals(Object o1, Object o2, out Il2CppReferenceArray<Object> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fields = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000890B8 File Offset: 0x000872B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309404, RefRangeEnd = 309406, XrefRangeStart = 309403, XrefRangeEnd = 309404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DefaultEquals(Object o1, Object o2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0008910C File Offset: 0x0008730C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 282509, RefRangeEnd = 282519, XrefRangeStart = 282509, XrefRangeEnd = 282519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00089164 File Offset: 0x00087364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309406, XrefRangeEnd = 309407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalGetHashCode(Object o, out Il2CppReferenceArray<Object> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fields = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000891C8 File Offset: 0x000873C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 309409, RefRangeEnd = 309415, XrefRangeStart = 309407, XrefRangeEnd = 309409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00089210 File Offset: 0x00087410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309415, XrefRangeEnd = 309417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00008185 File Offset: 0x00006385
		public ValueType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
