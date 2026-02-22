using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001EF RID: 495
	public sealed class OcclusionArea : Component
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x000645D8 File Offset: 0x000627D8
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x00011395 File Offset: 0x0000F595
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000645F0 File Offset: 0x000627F0
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x0001139F File Offset: 0x0000F59F
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000113A9 File Offset: 0x0000F5A9
		public void get_center_Injected(out Vector3 ret)
		{
			OcclusionArea.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000113BC File Offset: 0x0000F5BC
		public void set_center_Injected(ref Vector3 value)
		{
			OcclusionArea.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000113CF File Offset: 0x0000F5CF
		public void get_size_Injected(out Vector3 ret)
		{
			OcclusionArea.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000113E2 File Offset: 0x0000F5E2
		public void set_size_Injected(ref Vector3 value)
		{
			OcclusionArea.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400177F RID: 6015
		private static readonly OcclusionArea.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_center_InjectedDelegate>("UnityEngine.OcclusionArea::get_center_Injected");

		// Token: 0x04001780 RID: 6016
		private static readonly OcclusionArea.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_center_InjectedDelegate>("UnityEngine.OcclusionArea::set_center_Injected");

		// Token: 0x04001781 RID: 6017
		private static readonly OcclusionArea.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_size_InjectedDelegate>("UnityEngine.OcclusionArea::get_size_Injected");

		// Token: 0x04001782 RID: 6018
		private static readonly OcclusionArea.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_size_InjectedDelegate>("UnityEngine.OcclusionArea::set_size_Injected");

		// Token: 0x02000B9A RID: 2970
		// (Invoke) Token: 0x06003532 RID: 13618
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B9B RID: 2971
		// (Invoke) Token: 0x06003534 RID: 13620
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B9C RID: 2972
		// (Invoke) Token: 0x06003536 RID: 13622
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B9D RID: 2973
		// (Invoke) Token: 0x06003538 RID: 13624
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
