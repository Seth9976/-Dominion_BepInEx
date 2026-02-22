using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000339 RID: 825
	public class ObjectHolderListEnumerator : Object
	{
		// Token: 0x06003553 RID: 13651 RVA: 0x00104468 File Offset: 0x00102668
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderListEnumerator()
		{
			Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderListEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr);
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_isFixupEnumerator");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_list");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_startingVersion");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_currPos");
			ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671548);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671549);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671550);
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00104524 File Offset: 0x00102724
		[CallerCount(0)]
		public unsafe ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixupEnumerator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00104580 File Offset: 0x00102780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343378, RefRangeEnd = 343379, XrefRangeStart = 343378, XrefRangeEnd = 343378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x001045BC File Offset: 0x001027BC
		public unsafe ObjectHolder Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 343379, RefRangeEnd = 343380, XrefRangeStart = 343379, XrefRangeEnd = 343379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000130E7 File Offset: 0x000112E7
		public ObjectHolderListEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x001045FC File Offset: 0x001027FC
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x000130F0 File Offset: 0x000112F0
		public unsafe bool m_isFixupEnumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator)) = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x00104624 File Offset: 0x00102824
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x0001310B File Offset: 0x0001130B
		public unsafe ObjectHolderList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x00104654 File Offset: 0x00102854
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x0001312A File Offset: 0x0001132A
		public unsafe int m_startingVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion)) = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0010467C File Offset: 0x0010287C
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x00013145 File Offset: 0x00011345
		public unsafe int m_currPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos)) = value;
			}
		}

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeFieldInfoPtr_m_isFixupEnumerator;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeFieldInfoPtr_m_startingVersion;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeFieldInfoPtr_m_currPos;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0;
	}
}
