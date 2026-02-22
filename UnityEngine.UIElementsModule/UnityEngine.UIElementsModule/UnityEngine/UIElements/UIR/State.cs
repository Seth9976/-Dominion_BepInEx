using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000DD RID: 221
	public sealed class State : ValueType
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x000322F4 File Offset: 0x000304F4
		// Note: this type is marked as 'beforefieldinit'.
		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			State.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "material");
			State.NativeFieldInfoPtr_custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "custom");
			State.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "font");
			State.NativeFieldInfoPtr_fontTexSDFScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "fontTexSDFScale");
			State.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "texture");
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00007D80 File Offset: 0x00005F80
		public State(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00007D89 File Offset: 0x00005F89
		public State()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<State>.NativeClassPtr))
		{
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00032388 File Offset: 0x00030588
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00007D9B File Offset: 0x00005F9B
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000323B8 File Offset: 0x000305B8
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00007DBA File Offset: 0x00005FBA
		public unsafe Texture custom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_custom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_custom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000323E8 File Offset: 0x000305E8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00007DD9 File Offset: 0x00005FD9
		public unsafe Texture font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00032418 File Offset: 0x00030618
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public unsafe float fontTexSDFScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_fontTexSDFScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_fontTexSDFScale)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00032440 File Offset: 0x00030640
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00007E13 File Offset: 0x00006013
		public unsafe TextureId texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_texture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_texture)) = value;
			}
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_custom;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_fontTexSDFScale;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_texture;
	}
}
