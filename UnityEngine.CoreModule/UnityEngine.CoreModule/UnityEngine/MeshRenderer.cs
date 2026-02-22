using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200006D RID: 109
	public class MeshRenderer : Renderer
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x0002A080 File Offset: 0x00028280
		// Note: this type is marked as 'beforefieldinit'.
		static MeshRenderer()
		{
			Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr);
			MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100663712);
			MeshRenderer.get_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::get_additionalVertexStreams");
			MeshRenderer.set_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::set_additionalVertexStreams");
			MeshRenderer.get_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::get_enlightenVertexStream");
			MeshRenderer.set_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::set_enlightenVertexStream");
			MeshRenderer.get_subMeshStartIndexDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_subMeshStartIndexDelegate>("UnityEngine.MeshRenderer::get_subMeshStartIndex");
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002A110 File Offset: 0x00028310
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00007587 File Offset: 0x00005787
		public MeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002A144 File Offset: 0x00028344
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00007590 File Offset: 0x00005790
		public Mesh additionalVertexStreams
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002A170 File Offset: 0x00028370
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x000075A8 File Offset: 0x000057A8
		public Mesh enlightenVertexStream
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000075C0 File Offset: 0x000057C0
		public int subMeshStartIndex
		{
			get
			{
				return MeshRenderer.get_subMeshStartIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0;

		// Token: 0x04000671 RID: 1649
		private static readonly MeshRenderer.get_additionalVertexStreamsDelegate get_additionalVertexStreamsDelegateField;

		// Token: 0x04000672 RID: 1650
		private static readonly MeshRenderer.set_additionalVertexStreamsDelegate set_additionalVertexStreamsDelegateField;

		// Token: 0x04000673 RID: 1651
		private static readonly MeshRenderer.get_enlightenVertexStreamDelegate get_enlightenVertexStreamDelegateField;

		// Token: 0x04000674 RID: 1652
		private static readonly MeshRenderer.set_enlightenVertexStreamDelegate set_enlightenVertexStreamDelegateField;

		// Token: 0x04000675 RID: 1653
		private static readonly MeshRenderer.get_subMeshStartIndexDelegate get_subMeshStartIndexDelegateField;

		// Token: 0x02000619 RID: 1561
		// (Invoke) Token: 0x06002A01 RID: 10753
		private delegate IntPtr get_additionalVertexStreamsDelegate(IntPtr @this);

		// Token: 0x0200061A RID: 1562
		// (Invoke) Token: 0x06002A03 RID: 10755
		private delegate void set_additionalVertexStreamsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200061B RID: 1563
		// (Invoke) Token: 0x06002A05 RID: 10757
		private delegate IntPtr get_enlightenVertexStreamDelegate(IntPtr @this);

		// Token: 0x0200061C RID: 1564
		// (Invoke) Token: 0x06002A07 RID: 10759
		private delegate void set_enlightenVertexStreamDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200061D RID: 1565
		// (Invoke) Token: 0x06002A09 RID: 10761
		private delegate int get_subMeshStartIndexDelegate(IntPtr @this);
	}
}
