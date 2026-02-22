using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A8 RID: 168
	public class MeshGenerationContext : Object
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x00005A9D File Offset: 0x00003C9D
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerationContext()
		{
			Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshGenerationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr);
			MeshGenerationContext.NativeFieldInfoPtr_painter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationContext>.NativeClassPtr, "painter");
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00005AD6 File Offset: 0x00003CD6
		public MeshGenerationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00028C40 File Offset: 0x00026E40
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00005ADF File Offset: 0x00003CDF
		public unsafe IStylePainter painter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_painter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStylePainter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationContext.NativeFieldInfoPtr_painter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00028C70 File Offset: 0x00026E70
		public VisualElement visualElement
		{
			get
			{
				return this.painter.visualElement;
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00028C90 File Offset: 0x00026E90
		public MeshWriteData Allocate(int vertexCount, int indexCount, [Optional] Texture texture)
		{
			return this.painter.DrawMesh(vertexCount, indexCount, texture, null, MeshGenerationContext.MeshFlags.None);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public MeshWriteData Allocate(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
		{
			return this.painter.DrawMesh(vertexCount, indexCount, texture, material, flags);
		}

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_painter;

		// Token: 0x0200021C RID: 540
		public enum MeshFlags
		{
			// Token: 0x040008CD RID: 2253
			None,
			// Token: 0x040008CE RID: 2254
			UVisDisplacement,
			// Token: 0x040008CF RID: 2255
			SkipDynamicAtlas
		}
	}
}
