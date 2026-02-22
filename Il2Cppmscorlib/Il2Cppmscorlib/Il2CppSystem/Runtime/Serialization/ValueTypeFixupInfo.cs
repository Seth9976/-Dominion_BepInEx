using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034E RID: 846
	public class ValueTypeFixupInfo : Object
	{
		// Token: 0x06003650 RID: 13904 RVA: 0x00107E2C File Offset: 0x0010602C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeFixupInfo()
		{
			Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ValueTypeFixupInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr);
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_containerID");
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_parentField");
			ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, "m_parentIndex");
			ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671661);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671662);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671663);
			ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr, 100671664);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00107EE8 File Offset: 0x001060E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344828, RefRangeEnd = 344831, XrefRangeStart = 344823, XrefRangeEnd = 344828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTypeFixupInfo(long containerID, FieldInfo member, Il2CppStructArray<int> parentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTypeFixupInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref containerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x00107F54 File Offset: 0x00106154
		public unsafe long ContainerID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x00107F90 File Offset: 0x00106190
		public unsafe FieldInfo ParentField
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x00107FD0 File Offset: 0x001061D0
		public unsafe Il2CppStructArray<int> ParentIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeFixupInfo.NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00013875 File Offset: 0x00011A75
		public ValueTypeFixupInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x00108010 File Offset: 0x00106210
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x0001387E File Offset: 0x00011A7E
		public unsafe long m_containerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_containerID)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x00108038 File Offset: 0x00106238
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x00013899 File Offset: 0x00011A99
		public unsafe FieldInfo m_parentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x00108068 File Offset: 0x00106268
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x000138B8 File Offset: 0x00011AB8
		public unsafe Il2CppStructArray<int> m_parentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTypeFixupInfo.NativeFieldInfoPtr_m_parentIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeFieldInfoPtr_m_containerID;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeFieldInfoPtr_m_parentField;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeFieldInfoPtr_m_parentIndex;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Public_get_Int64_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentField_Public_get_FieldInfo_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Il2CppStructArray_1_Int32_0;
	}
}
