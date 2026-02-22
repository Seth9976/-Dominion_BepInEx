using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B8 RID: 696
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x000140E7 File Offset: 0x000122E7
		public static int invalidSortingGroupID
		{
			get
			{
				return SortingGroup.get_invalidSortingGroupIDDelegateField();
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000140F3 File Offset: 0x000122F3
		public static void UpdateAllSortingGroups()
		{
			SortingGroup.UpdateAllSortingGroupsDelegateField();
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00069A98 File Offset: 0x00067C98
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x000140FF File Offset: 0x000122FF
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = SortingGroup.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				SortingGroup.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00014117 File Offset: 0x00012317
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00014129 File Offset: 0x00012329
		public int sortingLayerID
		{
			get
			{
				return SortingGroup.get_sortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SortingGroup.set_sortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0001413C File Offset: 0x0001233C
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0001414E File Offset: 0x0001234E
		public int sortingOrder
		{
			get
			{
				return SortingGroup.get_sortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SortingGroup.set_sortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00014161 File Offset: 0x00012361
		public int sortingGroupID
		{
			get
			{
				return SortingGroup.get_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00014173 File Offset: 0x00012373
		public int sortingGroupOrder
		{
			get
			{
				return SortingGroup.get_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00014185 File Offset: 0x00012385
		public int index
		{
			get
			{
				return SortingGroup.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04001B99 RID: 7065
		private static readonly SortingGroup.get_invalidSortingGroupIDDelegate get_invalidSortingGroupIDDelegateField = IL2CPP.ResolveICall<SortingGroup.get_invalidSortingGroupIDDelegate>("UnityEngine.Rendering.SortingGroup::get_invalidSortingGroupID");

		// Token: 0x04001B9A RID: 7066
		private static readonly SortingGroup.UpdateAllSortingGroupsDelegate UpdateAllSortingGroupsDelegateField = IL2CPP.ResolveICall<SortingGroup.UpdateAllSortingGroupsDelegate>("UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups");

		// Token: 0x04001B9B RID: 7067
		private static readonly SortingGroup.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerName");

		// Token: 0x04001B9C RID: 7068
		private static readonly SortingGroup.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerName");

		// Token: 0x04001B9D RID: 7069
		private static readonly SortingGroup.get_sortingLayerIDDelegate get_sortingLayerIDDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingLayerIDDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerID");

		// Token: 0x04001B9E RID: 7070
		private static readonly SortingGroup.set_sortingLayerIDDelegate set_sortingLayerIDDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerIDDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerID");

		// Token: 0x04001B9F RID: 7071
		private static readonly SortingGroup.get_sortingOrderDelegate get_sortingOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingOrderDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingOrder");

		// Token: 0x04001BA0 RID: 7072
		private static readonly SortingGroup.set_sortingOrderDelegate set_sortingOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingOrderDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingOrder");

		// Token: 0x04001BA1 RID: 7073
		private static readonly SortingGroup.get_sortingGroupIDDelegate get_sortingGroupIDDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupIDDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupID");

		// Token: 0x04001BA2 RID: 7074
		private static readonly SortingGroup.get_sortingGroupOrderDelegate get_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupOrderDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder");

		// Token: 0x04001BA3 RID: 7075
		private static readonly SortingGroup.get_indexDelegate get_indexDelegateField = IL2CPP.ResolveICall<SortingGroup.get_indexDelegate>("UnityEngine.Rendering.SortingGroup::get_index");

		// Token: 0x02000D01 RID: 3329
		// (Invoke) Token: 0x060037E6 RID: 14310
		private delegate int get_invalidSortingGroupIDDelegate();

		// Token: 0x02000D02 RID: 3330
		// (Invoke) Token: 0x060037E8 RID: 14312
		private delegate void UpdateAllSortingGroupsDelegate();

		// Token: 0x02000D03 RID: 3331
		// (Invoke) Token: 0x060037EA RID: 14314
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x02000D04 RID: 3332
		// (Invoke) Token: 0x060037EC RID: 14316
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000D05 RID: 3333
		// (Invoke) Token: 0x060037EE RID: 14318
		private delegate int get_sortingLayerIDDelegate(IntPtr @this);

		// Token: 0x02000D06 RID: 3334
		// (Invoke) Token: 0x060037F0 RID: 14320
		private delegate void set_sortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x02000D07 RID: 3335
		// (Invoke) Token: 0x060037F2 RID: 14322
		private delegate int get_sortingOrderDelegate(IntPtr @this);

		// Token: 0x02000D08 RID: 3336
		// (Invoke) Token: 0x060037F4 RID: 14324
		private delegate void set_sortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x02000D09 RID: 3337
		// (Invoke) Token: 0x060037F6 RID: 14326
		private delegate int get_sortingGroupIDDelegate(IntPtr @this);

		// Token: 0x02000D0A RID: 3338
		// (Invoke) Token: 0x060037F8 RID: 14328
		private delegate int get_sortingGroupOrderDelegate(IntPtr @this);

		// Token: 0x02000D0B RID: 3339
		// (Invoke) Token: 0x060037FA RID: 14330
		private delegate int get_indexDelegate(IntPtr @this);
	}
}
