using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public class CompatibleComparer : Object
	{
		// Token: 0x06004417 RID: 17431 RVA: 0x001377D8 File Offset: 0x001359D8
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibleComparer()
		{
			Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CompatibleComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr);
			CompatibleComparer.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_comparer");
			CompatibleComparer.NativeFieldInfoPtr__hcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_hcp");
			CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673180);
			CompatibleComparer.NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673181);
			CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673182);
			CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673183);
			CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673184);
			CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100673185);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x001378A8 File Offset: 0x00135AA8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashCodeProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00137908 File Offset: 0x00135B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359602, XrefRangeEnd = 359611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00137968 File Offset: 0x00135B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359611, XrefRangeEnd = 359624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object a, Object b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x001379C8 File Offset: 0x00135BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359624, XrefRangeEnd = 359633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600441C RID: 17436 RVA: 0x00137A18 File Offset: 0x00135C18
		public unsafe IComparer Comparer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x00137A58 File Offset: 0x00135C58
		public unsafe IHashCodeProvider HashCodeProvider
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x0001A1D8 File Offset: 0x000183D8
		public CompatibleComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x00137A98 File Offset: 0x00135C98
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x0001A1E1 File Offset: 0x000183E1
		public unsafe IComparer _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x00137AC8 File Offset: 0x00135CC8
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x0001A200 File Offset: 0x00018400
		public unsafe IHashCodeProvider _hcp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr__hcp;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Int32_Object_Object_0;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Internal_get_IComparer_0;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCodeProvider_Internal_get_IHashCodeProvider_0;
	}
}
