using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002C RID: 44
	public static class UnsafeUtility : Object
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00019904 File Offset: 0x00017B04
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeUtility()
		{
			Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
			UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663347);
			UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663348);
			UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663349);
			UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663350);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663351);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663352);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663353);
			UnsafeUtility.GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
			UnsafeUtility.GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
			UnsafeUtility.PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
			UnsafeUtility.PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
			UnsafeUtility.ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
			UnsafeUtility.CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
			UnsafeUtility.MemCpyReplicateDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
			UnsafeUtility.MemCpyStrideDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyStrideDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyStride");
			UnsafeUtility.MemMoveDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemMoveDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemMove");
			UnsafeUtility.MemSetDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemSetDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet");
			UnsafeUtility.MemCmpDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCmpDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCmp");
			UnsafeUtility.SizeOfDelegateField = IL2CPP.ResolveICall<UnsafeUtility.SizeOfDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf");
			UnsafeUtility.IsBlittableDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsBlittableDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsBlittable");
			UnsafeUtility.IsUnmanagedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
			UnsafeUtility.IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
			UnsafeUtility.LogErrorDelegateField = IL2CPP.ResolveICall<UnsafeUtility.LogErrorDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00019AB0 File Offset: 0x00017CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59120, RefRangeEnd = 59121, XrefRangeStart = 59118, XrefRangeEnd = 59120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00019B00 File Offset: 0x00017D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59123, RefRangeEnd = 59124, XrefRangeStart = 59121, XrefRangeEnd = 59123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = memory;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00019B40 File Offset: 0x00017D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59126, RefRangeEnd = 59128, XrefRangeStart = 59124, XrefRangeEnd = 59126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00019B8C File Offset: 0x00017D8C
		[CallerCount(0)]
		public unsafe static int AlignOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00019BBC File Offset: 0x00017DBC
		[CallerCount(0)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00019C04 File Offset: 0x00017E04
		[CallerCount(0)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00019C8C File Offset: 0x00017E8C
		[CallerCount(0)]
		public unsafe static int SizeOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002CCA File Offset: 0x00000ECA
		public UnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002CD3 File Offset: 0x00000ED3
		public static int GetFieldOffsetInStruct(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public static int GetFieldOffsetInClass(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00019CBC File Offset: 0x00017EBC
		public static int GetFieldOffset(FieldInfo field)
		{
			bool isValueType = field.DeclaringType.IsValueType;
			int num;
			if (isValueType)
			{
				num = UnsafeUtility.GetFieldOffsetInStruct(field);
			}
			else
			{
				bool isClass = field.DeclaringType.IsClass;
				if (isClass)
				{
					num = UnsafeUtility.GetFieldOffsetInClass(field);
				}
				else
				{
					num = -1;
				}
			}
			return num;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00019D00 File Offset: 0x00017F00
		public unsafe static void* PinGCObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddress(target, out gcHandle);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00019D1C File Offset: 0x00017F1C
		public unsafe static void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddress(target, out gcHandle);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002CF7 File Offset: 0x00000EF7
		public unsafe static void* PinSystemArrayAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002D0A File Offset: 0x00000F0A
		public unsafe static void* PinSystemObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002D1D File Offset: 0x00000F1D
		public static void ReleaseGCObject(ulong gcHandle)
		{
			UnsafeUtility.ReleaseGCObjectDelegateField(gcHandle);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe static void CopyObjectAddressToPtr(Object target, void* dstPtr)
		{
			UnsafeUtility.CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), dstPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00019D38 File Offset: 0x00017F38
		public static bool IsBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00019D5C File Offset: 0x00017F5C
		public static bool IsValidAllocator(Allocator allocator)
		{
			return allocator > Allocator.None;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002D3D File Offset: 0x00000F3D
		public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
		{
			UnsafeUtility.MemCpyReplicateDelegateField(destination, source, size, count);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002D4D File Offset: 0x00000F4D
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
			UnsafeUtility.MemCpyStrideDelegateField(destination, destinationStride, source, sourceStride, elementSize, count);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002D61 File Offset: 0x00000F61
		public unsafe static void MemMove(void* destination, void* source, long size)
		{
			UnsafeUtility.MemMoveDelegateField(destination, source, size);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002D70 File Offset: 0x00000F70
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
			UnsafeUtility.MemSetDelegateField(destination, value, size);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002D7F File Offset: 0x00000F7F
		public unsafe static void MemClear(void* destination, long size)
		{
			UnsafeUtility.MemSet(destination, 0, size);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002D8B File Offset: 0x00000F8B
		public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
		{
			return UnsafeUtility.MemCmpDelegateField(ptr1, ptr2, size);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002D9A File Offset: 0x00000F9A
		public static int SizeOf(Type type)
		{
			return UnsafeUtility.SizeOfDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002DAC File Offset: 0x00000FAC
		public static bool IsBlittable(Type type)
		{
			return UnsafeUtility.IsBlittableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002DBE File Offset: 0x00000FBE
		public static bool IsUnmanaged(Type type)
		{
			return UnsafeUtility.IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public static bool IsValidNativeContainerElementType(Type type)
		{
			return UnsafeUtility.IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002DE2 File Offset: 0x00000FE2
		public static void LogError(string msg, string filename, int linenumber)
		{
			UnsafeUtility.LogErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(msg), IL2CPP.ManagedStringToIl2Cpp(filename), linenumber);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00019D74 File Offset: 0x00017F74
		public static bool IsBlittableValueType(Type t)
		{
			return t.IsValueType && UnsafeUtility.IsBlittable(t);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002DFB File Offset: 0x00000FFB
		public static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00019D98 File Offset: 0x00017F98
		public static bool IsArrayBlittable(Array arr)
		{
			return UnsafeUtility.IsBlittableValueType(arr.GetType().GetElementType());
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00019DBC File Offset: 0x00017FBC
		public static bool IsGenericListBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable<T>();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00019DD4 File Offset: 0x00017FD4
		public static string GetReasonForArrayNonBlittable(Array arr)
		{
			Type elementType = arr.GetType().GetElementType();
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(elementType, elementType.Name);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00019E00 File Offset: 0x00018000
		public static string GetReasonForGenericListNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00019E2C File Offset: 0x0001802C
		public static string GetReasonForTypeNonBlittable(Type t)
		{
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(t, t.Name);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00019E4C File Offset: 0x0001804C
		public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002E08 File Offset: 0x00001008
		public static bool IsUnmanaged<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002E15 File Offset: 0x00001015
		public static bool IsValidNativeContainerElementType<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002E22 File Offset: 0x00001022
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			UnsafeUtility.InternalCopyPtrToStructure<T>(ptr, out output);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002E2D File Offset: 0x0000102D
		public unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : struct
		{
			output = *(T*)ptr;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002E3B File Offset: 0x0000103B
		public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			UnsafeUtility.InternalCopyStructureToPtr<T>(ref input, ptr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002E46 File Offset: 0x00001046
		public unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : struct
		{
			*(T*)ptr = input;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002E54 File Offset: 0x00001054
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			return *(T*)((byte*)source + (long)index * (long)stride);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002E63 File Offset: 0x00001063
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
			*(T*)((byte*)destination + (long)index * (long)stride) = value;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002E73 File Offset: 0x00001073
		public unsafe static void* AddressOf<T>(ref T output) where T : struct
		{
			return (void*)(&output);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002E76 File Offset: 0x00001076
		public static ref T As<U, T>(ref U from)
		{
			return ref from;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002E79 File Offset: 0x00001079
		public unsafe static ref T AsRef<T>(void* ptr) where T : struct
		{
			return ref *(T*)ptr;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002E7C File Offset: 0x0000107C
		public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : struct
		{
			return ref *(T*)((byte*)ptr + (long)index * (long)sizeof(T));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00019E78 File Offset: 0x00018078
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			int num = 0;
			UnsafeUtility.InternalEnumToInt<T>(ref enumValue, ref num);
			return num;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002E8B File Offset: 0x0000108B
		public static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
			intValue = enumValue;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002E91 File Offset: 0x00001091
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return lhs == rhs;
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly UnsafeUtility.GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly UnsafeUtility.GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly UnsafeUtility.PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly UnsafeUtility.PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly UnsafeUtility.ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly UnsafeUtility.CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly UnsafeUtility.MemCpyReplicateDelegate MemCpyReplicateDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly UnsafeUtility.MemCpyStrideDelegate MemCpyStrideDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly UnsafeUtility.MemMoveDelegate MemMoveDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly UnsafeUtility.MemSetDelegate MemSetDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly UnsafeUtility.MemCmpDelegate MemCmpDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly UnsafeUtility.SizeOfDelegate SizeOfDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly UnsafeUtility.IsBlittableDelegate IsBlittableDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly UnsafeUtility.IsUnmanagedDelegate IsUnmanagedDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly UnsafeUtility.IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly UnsafeUtility.LogErrorDelegate LogErrorDelegateField;

		// Token: 0x020002FD RID: 765
		public sealed class AlignOfHelper<T> : ValueType where T : new()
		{
			// Token: 0x060023B4 RID: 9140 RVA: 0x0006B1BC File Offset: 0x000693BC
			// Note: this type is marked as 'beforefieldinit'.
			static AlignOfHelper()
			{
				Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr);
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "dummy");
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "data");
			}

			// Token: 0x060023B5 RID: 9141 RVA: 0x0001500D File Offset: 0x0001320D
			public AlignOfHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023B6 RID: 9142 RVA: 0x00015016 File Offset: 0x00013216
			public AlignOfHelper()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0006B24C File Offset: 0x0006944C
			// (set) Token: 0x060023B8 RID: 9144 RVA: 0x00015028 File Offset: 0x00013228
			public unsafe byte dummy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy)) = value;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0006B274 File Offset: 0x00069474
			// (set) Token: 0x060023BA RID: 9146 RVA: 0x0006B29C File Offset: 0x0006949C
			public unsafe T data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001C20 RID: 7200
			private static readonly IntPtr NativeFieldInfoPtr_dummy;

			// Token: 0x04001C21 RID: 7201
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x020002FE RID: 766
		private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04001C22 RID: 7202
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002FF RID: 767
		private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04001C23 RID: 7203
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000300 RID: 768
		private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
		{
			// Token: 0x04001C24 RID: 7204
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000301 RID: 769
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04001C25 RID: 7205
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000302 RID: 770
		// (Invoke) Token: 0x060023C0 RID: 9152
		private delegate int GetFieldOffsetInStructDelegate(IntPtr field);

		// Token: 0x02000303 RID: 771
		// (Invoke) Token: 0x060023C2 RID: 9154
		private delegate int GetFieldOffsetInClassDelegate(IntPtr field);

		// Token: 0x02000304 RID: 772
		// (Invoke) Token: 0x060023C4 RID: 9156
		private delegate IntPtr PinSystemArrayAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x02000305 RID: 773
		// (Invoke) Token: 0x060023C6 RID: 9158
		private delegate IntPtr PinSystemObjectAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x02000306 RID: 774
		// (Invoke) Token: 0x060023C8 RID: 9160
		private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

		// Token: 0x02000307 RID: 775
		// (Invoke) Token: 0x060023CA RID: 9162
		private delegate void CopyObjectAddressToPtrDelegate(IntPtr target, IntPtr dstPtr);

		// Token: 0x02000308 RID: 776
		// (Invoke) Token: 0x060023CC RID: 9164
		private delegate void MemCpyReplicateDelegate(IntPtr destination, IntPtr source, int size, int count);

		// Token: 0x02000309 RID: 777
		// (Invoke) Token: 0x060023CE RID: 9166
		private delegate void MemCpyStrideDelegate(IntPtr destination, int destinationStride, IntPtr source, int sourceStride, int elementSize, int count);

		// Token: 0x0200030A RID: 778
		// (Invoke) Token: 0x060023D0 RID: 9168
		private delegate void MemMoveDelegate(IntPtr destination, IntPtr source, long size);

		// Token: 0x0200030B RID: 779
		// (Invoke) Token: 0x060023D2 RID: 9170
		private delegate void MemSetDelegate(IntPtr destination, byte value, long size);

		// Token: 0x0200030C RID: 780
		// (Invoke) Token: 0x060023D4 RID: 9172
		private delegate int MemCmpDelegate(IntPtr ptr1, IntPtr ptr2, long size);

		// Token: 0x0200030D RID: 781
		// (Invoke) Token: 0x060023D6 RID: 9174
		private delegate int SizeOfDelegate(IntPtr type);

		// Token: 0x0200030E RID: 782
		// (Invoke) Token: 0x060023D8 RID: 9176
		private delegate bool IsBlittableDelegate(IntPtr type);

		// Token: 0x0200030F RID: 783
		// (Invoke) Token: 0x060023DA RID: 9178
		private delegate bool IsUnmanagedDelegate(IntPtr type);

		// Token: 0x02000310 RID: 784
		// (Invoke) Token: 0x060023DC RID: 9180
		private delegate bool IsValidNativeContainerElementTypeDelegate(IntPtr type);

		// Token: 0x02000311 RID: 785
		// (Invoke) Token: 0x060023DE RID: 9182
		private delegate void LogErrorDelegate(IntPtr msg, IntPtr filename, int linenumber);
	}
}
