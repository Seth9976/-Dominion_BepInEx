using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000004 RID: 4
	public class AtlasBase : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020D4 File Offset: 0x000002D4
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasBase()
		{
			Il2CppClassPointerStore<AtlasBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AtlasBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr);
			AtlasBase.NativeFieldInfoPtr_textureRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasBase>.NativeClassPtr, "textureRegistry");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000210D File Offset: 0x0000030D
		public AtlasBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000CE48 File Offset: 0x0000B048
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002116 File Offset: 0x00000316
		public unsafe TextureRegistry textureRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasBase.NativeFieldInfoPtr_textureRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtlasBase.NativeFieldInfoPtr_textureRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000CE78 File Offset: 0x0000B078
		public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			atlas = TextureId.invalid;
			atlasRect = default(RectInt);
			return false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002135 File Offset: 0x00000335
		public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002138 File Offset: 0x00000338
		public virtual void Reset()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000213B File Offset: 0x0000033B
		public virtual void OnAssignedToPanel(IPanel panel)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000213E File Offset: 0x0000033E
		public virtual void OnRemovedFromPanel(IPanel panel)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002141 File Offset: 0x00000341
		public virtual void OnUpdateDynamicTextures(IPanel panel)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002144 File Offset: 0x00000344
		public void InvokeAssignedToPanel(IPanel panel)
		{
			this.OnAssignedToPanel(panel);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000214F File Offset: 0x0000034F
		public void InvokeRemovedFromPanel(IPanel panel)
		{
			this.OnRemovedFromPanel(panel);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000215A File Offset: 0x0000035A
		public void InvokeUpdateDynamicTextures(IPanel panel)
		{
			this.OnUpdateDynamicTextures(panel);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002165 File Offset: 0x00000365
		public static void RepaintTexturedElements(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		public TextureId AllocateDynamicTexture()
		{
			return this.textureRegistry.AllocAndAcquireDynamic();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002172 File Offset: 0x00000372
		public void FreeDynamicTexture(TextureId id)
		{
			this.textureRegistry.Release(id);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002182 File Offset: 0x00000382
		public void SetDynamicTexture(TextureId id, Texture texture)
		{
			this.textureRegistry.UpdateDynamic(id, texture);
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_textureRegistry;
	}
}
