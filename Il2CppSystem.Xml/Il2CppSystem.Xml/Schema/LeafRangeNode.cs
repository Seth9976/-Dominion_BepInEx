using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000082 RID: 130
	public sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x0003054C File Offset: 0x0002E74C
		// Note: this type is marked as 'beforefieldinit'.
		static LeafRangeNode()
		{
			Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "LeafRangeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr);
			LeafRangeNode.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "min");
			LeafRangeNode.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "max");
			LeafRangeNode.NativeFieldInfoPtr_nextIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "nextIteration");
			LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100664772);
			LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100664773);
			LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100664774);
			LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100664775);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00030608 File Offset: 0x0002E808
		public unsafe Decimal Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00030644 File Offset: 0x0002E844
		public unsafe Decimal Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00030680 File Offset: 0x0002E880
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000306C0 File Offset: 0x0002E8C0
		public unsafe BitSet NextIteration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00004EAD File Offset: 0x000030AD
		public LeafRangeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00030704 File Offset: 0x0002E904
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00004EB6 File Offset: 0x000030B6
		public unsafe Decimal min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0003072C File Offset: 0x0002E92C
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00004ED1 File Offset: 0x000030D1
		public unsafe Decimal max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00030754 File Offset: 0x0002E954
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00004EEC File Offset: 0x000030EC
		public unsafe BitSet nextIteration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_nextIteration;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Decimal_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Decimal_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0;
	}
}
