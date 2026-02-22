using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000156 RID: 342
	public class SpriteRendererGroup : Object
	{
		// Token: 0x06001A76 RID: 6774 RVA: 0x0005E4A4 File Offset: 0x0005C6A4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRendererGroup()
		{
			Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
			SpriteRendererGroup.AddRenderersDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
			SpriteRendererGroup.ClearDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000EB13 File Offset: 0x0000CD13
		public SpriteRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		public static void AddRenderers(Unity.Collections.NativeArray<SpriteIntermediateRendererInfo> renderers)
		{
			SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), renderers.Length);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000EB34 File Offset: 0x0000CD34
		public unsafe static void AddRenderers(void* renderers, int count)
		{
			SpriteRendererGroup.AddRenderersDelegateField(renderers, count);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0000EB42 File Offset: 0x0000CD42
		public static void Clear()
		{
			SpriteRendererGroup.ClearDelegateField();
		}

		// Token: 0x0400134E RID: 4942
		private static readonly SpriteRendererGroup.AddRenderersDelegate AddRenderersDelegateField;

		// Token: 0x0400134F RID: 4943
		private static readonly SpriteRendererGroup.ClearDelegate ClearDelegateField;

		// Token: 0x02000A03 RID: 2563
		// (Invoke) Token: 0x06003225 RID: 12837
		private delegate void AddRenderersDelegate(IntPtr renderers, int count);

		// Token: 0x02000A04 RID: 2564
		// (Invoke) Token: 0x06003227 RID: 12839
		private delegate void ClearDelegate();
	}
}
