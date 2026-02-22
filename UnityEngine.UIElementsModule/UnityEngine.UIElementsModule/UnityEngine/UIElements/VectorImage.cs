using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class VectorImage : ScriptableObject
	{
		// Token: 0x06000B8B RID: 2955 RVA: 0x00030114 File Offset: 0x0002E314
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImage()
		{
			Il2CppClassPointerStore<VectorImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VectorImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImage>.NativeClassPtr);
			VectorImage.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "atlas");
			VectorImage.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "vertices");
			VectorImage.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "indices");
			VectorImage.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "settings");
			VectorImage.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "size");
			VectorImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, 100664267);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000301BC File Offset: 0x0002E3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97233, XrefRangeEnd = 97237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000073C4 File Offset: 0x000055C4
		public VectorImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x000301F8 File Offset: 0x0002E3F8
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000073CD File Offset: 0x000055CD
		public unsafe Texture2D atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00030228 File Offset: 0x0002E428
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000073EC File Offset: 0x000055EC
		public unsafe Il2CppStructArray<VectorImageVertex> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<VectorImageVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00030258 File Offset: 0x0002E458
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0000740B File Offset: 0x0000560B
		public unsafe Il2CppStructArray<ushort> indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00030288 File Offset: 0x0002E488
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0000742A File Offset: 0x0000562A
		public unsafe Il2CppStructArray<GradientSettings> settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000302B8 File Offset: 0x0002E4B8
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00007449 File Offset: 0x00005649
		public unsafe Vector2 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_atlas;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
