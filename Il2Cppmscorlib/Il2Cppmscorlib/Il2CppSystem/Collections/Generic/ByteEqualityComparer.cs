using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A1 RID: 1185
	[Serializable]
	public class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x0600468C RID: 18060 RVA: 0x00143E1C File Offset: 0x0014201C
		// Note: this type is marked as 'beforefieldinit'.
		static ByteEqualityComparer()
		{
			Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ByteEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr);
			ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673751);
			ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673752);
			ByteEqualityComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673753);
			ByteEqualityComparer.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673754);
			ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673755);
			ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673756);
			ByteEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100673757);
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00143ED8 File Offset: 0x001420D8
		[CallerCount(0)]
		public unsafe override bool Equals(byte x, byte y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x00143F3C File Offset: 0x0014213C
		[CallerCount(0)]
		public unsafe override int GetHashCode(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x00143F90 File Offset: 0x00142190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364004, XrefRangeEnd = 364005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOf(Il2CppStructArray<byte> array, byte value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x00144014 File Offset: 0x00142214
		[CallerCount(0)]
		public unsafe override int LastIndexOf(Il2CppStructArray<byte> array, byte value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00144098 File Offset: 0x00142298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364005, XrefRangeEnd = 364006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x001440F0 File Offset: 0x001422F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364006, XrefRangeEnd = 364008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00144138 File Offset: 0x00142338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364008, XrefRangeEnd = 364011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x0001ABE1 File Offset: 0x00018DE1
		public ByteEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003949 RID: 14665
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0;

		// Token: 0x0400394A RID: 14666
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0;

		// Token: 0x0400394B RID: 14667
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0;

		// Token: 0x0400394C RID: 14668
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0;

		// Token: 0x0400394D RID: 14669
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400394E RID: 14670
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
