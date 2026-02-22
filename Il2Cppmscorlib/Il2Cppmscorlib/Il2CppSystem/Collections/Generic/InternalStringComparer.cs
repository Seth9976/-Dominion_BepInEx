using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A6 RID: 1190
	[Serializable]
	public sealed class InternalStringComparer : EqualityComparer<string>
	{
		// Token: 0x060046B1 RID: 18097 RVA: 0x00144CD8 File Offset: 0x00142ED8
		// Note: this type is marked as 'beforefieldinit'.
		static InternalStringComparer()
		{
			Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "InternalStringComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr);
			InternalStringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100673778);
			InternalStringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100673779);
			InternalStringComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100673780);
			InternalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100673781);
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00144D58 File Offset: 0x00142F58
		[CallerCount(0)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00144DA8 File Offset: 0x00142FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364040, XrefRangeEnd = 364041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00144E08 File Offset: 0x00143008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364041, XrefRangeEnd = 364042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOf(Il2CppStringArray array, string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00144E84 File Offset: 0x00143084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364042, XrefRangeEnd = 364045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalStringComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0001AC0E File Offset: 0x00018E0E
		public InternalStringComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003964 RID: 14692
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0;

		// Token: 0x04003965 RID: 14693
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04003966 RID: 14694
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0;

		// Token: 0x04003967 RID: 14695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
