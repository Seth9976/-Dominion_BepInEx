using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001EE RID: 494
	public sealed class OcclusionPortal : Component
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00011332 File Offset: 0x0000F532
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00011344 File Offset: 0x0000F544
		public bool open
		{
			get
			{
				return OcclusionPortal.get_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OcclusionPortal.set_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400177D RID: 6013
		private static readonly OcclusionPortal.get_openDelegate get_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.get_openDelegate>("UnityEngine.OcclusionPortal::get_open");

		// Token: 0x0400177E RID: 6014
		private static readonly OcclusionPortal.set_openDelegate set_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.set_openDelegate>("UnityEngine.OcclusionPortal::set_open");

		// Token: 0x02000B98 RID: 2968
		// (Invoke) Token: 0x0600352E RID: 13614
		private delegate bool get_openDelegate(IntPtr @this);

		// Token: 0x02000B99 RID: 2969
		// (Invoke) Token: 0x06003530 RID: 13616
		private delegate void set_openDelegate(IntPtr @this, bool value);
	}
}
