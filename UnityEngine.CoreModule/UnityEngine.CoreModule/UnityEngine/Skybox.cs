using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020001F4 RID: 500
	public sealed class Skybox : Behaviour
	{
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00064800 File Offset: 0x00062A00
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x000115E5 File Offset: 0x0000F7E5
		public Material material
		{
			get
			{
				IntPtr intPtr = Skybox.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Skybox.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017A0 RID: 6048
		private static readonly Skybox.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Skybox.get_materialDelegate>("UnityEngine.Skybox::get_material");

		// Token: 0x040017A1 RID: 6049
		private static readonly Skybox.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Skybox.set_materialDelegate>("UnityEngine.Skybox::set_material");

		// Token: 0x02000BB7 RID: 2999
		// (Invoke) Token: 0x0600356C RID: 13676
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000BB8 RID: 3000
		// (Invoke) Token: 0x0600356E RID: 13678
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
