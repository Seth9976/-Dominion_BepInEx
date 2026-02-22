using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000338 RID: 824
	public class ObjectHolderList : Object
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x0010416C File Offset: 0x0010236C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderList()
		{
			Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr);
			ObjectHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_values");
			ObjectHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_count");
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671541);
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671542);
			ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671543);
			ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671544);
			ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671545);
			ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671546);
			ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671547);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00104250 File Offset: 0x00102450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343360, XrefRangeEnd = 343363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0010428C File Offset: 0x0010248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343363, XrefRangeEnd = 343366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x001042D4 File Offset: 0x001024D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343366, XrefRangeEnd = 343371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(ObjectHolder value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00104324 File Offset: 0x00102524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343371, XrefRangeEnd = 343374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderListEnumerator GetFixupEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderListEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00104364 File Offset: 0x00102564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343374, XrefRangeEnd = 343378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x00104398 File Offset: 0x00102598
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x001043D4 File Offset: 0x001025D4
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000130A4 File Offset: 0x000112A4
		public ObjectHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x00104410 File Offset: 0x00102610
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x000130AD File Offset: 0x000112AD
		public unsafe Il2CppReferenceArray<ObjectHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x00104440 File Offset: 0x00102640
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x000130CC File Offset: 0x000112CC
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
	}
}
