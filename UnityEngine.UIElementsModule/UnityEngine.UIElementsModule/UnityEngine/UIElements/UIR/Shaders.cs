using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D5 RID: 213
	public static class Shaders : Object
	{
		// Token: 0x06000C0E RID: 3086 RVA: 0x00031354 File Offset: 0x0002F554
		// Note: this type is marked as 'beforefieldinit'.
		static Shaders()
		{
			Il2CppClassPointerStore<Shaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Shaders");
			Shaders.NativeFieldInfoPtr_k_AtlasBlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shaders>.NativeClassPtr, "k_AtlasBlit");
			Shaders.NativeFieldInfoPtr_k_Editor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shaders>.NativeClassPtr, "k_Editor");
			Shaders.NativeFieldInfoPtr_k_Runtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shaders>.NativeClassPtr, "k_Runtime");
			Shaders.NativeFieldInfoPtr_k_RuntimeWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shaders>.NativeClassPtr, "k_RuntimeWorld");
			Shaders.NativeFieldInfoPtr_k_GraphView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shaders>.NativeClassPtr, "k_GraphView");
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000079F3 File Offset: 0x00005BF3
		public Shaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000313E0 File Offset: 0x0002F5E0
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x000079FC File Offset: 0x00005BFC
		public unsafe static string k_AtlasBlit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Shaders.NativeFieldInfoPtr_k_AtlasBlit, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shaders.NativeFieldInfoPtr_k_AtlasBlit, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00031400 File Offset: 0x0002F600
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00007A0E File Offset: 0x00005C0E
		public unsafe static string k_Editor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Shaders.NativeFieldInfoPtr_k_Editor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shaders.NativeFieldInfoPtr_k_Editor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00031420 File Offset: 0x0002F620
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00007A20 File Offset: 0x00005C20
		public unsafe static string k_Runtime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Shaders.NativeFieldInfoPtr_k_Runtime, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shaders.NativeFieldInfoPtr_k_Runtime, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00031440 File Offset: 0x0002F640
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00007A32 File Offset: 0x00005C32
		public unsafe static string k_RuntimeWorld
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Shaders.NativeFieldInfoPtr_k_RuntimeWorld, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shaders.NativeFieldInfoPtr_k_RuntimeWorld, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00031460 File Offset: 0x0002F660
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00007A44 File Offset: 0x00005C44
		public unsafe static string k_GraphView
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Shaders.NativeFieldInfoPtr_k_GraphView, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shaders.NativeFieldInfoPtr_k_GraphView, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_k_AtlasBlit;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_k_Editor;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_k_Runtime;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_k_RuntimeWorld;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_k_GraphView;
	}
}
