using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000336 RID: 822
	[Serializable]
	public class FixupHolderList : Object
	{
		// Token: 0x06003529 RID: 13609 RVA: 0x00103B5C File Offset: 0x00101D5C
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolderList()
		{
			Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr);
			FixupHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_values");
			FixupHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, "m_count");
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671528);
			FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671529);
			FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671530);
			FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr, 100671531);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00103C04 File Offset: 0x00101E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343319, RefRangeEnd = 343321, XrefRangeStart = 343315, XrefRangeEnd = 343319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00103C40 File Offset: 0x00101E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343321, XrefRangeEnd = 343325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00103C88 File Offset: 0x00101E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343325, XrefRangeEnd = 343330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(FixupHolder fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FixupHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00103CD8 File Offset: 0x00101ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343330, XrefRangeEnd = 343334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00012FE8 File Offset: 0x000111E8
		public FixupHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x00103D0C File Offset: 0x00101F0C
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x00012FF1 File Offset: 0x000111F1
		public unsafe Il2CppReferenceArray<FixupHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FixupHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x00103D3C File Offset: 0x00101F3C
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x00013010 File Offset: 0x00011210
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_FixupHolder_0;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
