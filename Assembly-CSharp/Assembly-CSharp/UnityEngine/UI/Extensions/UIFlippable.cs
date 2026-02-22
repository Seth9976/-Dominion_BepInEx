using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000127 RID: 295
	public class UIFlippable : MonoBehaviour
	{
		// Token: 0x06002114 RID: 8468 RVA: 0x0007E848 File Offset: 0x0007CA48
		// Note: this type is marked as 'beforefieldinit'.
		static UIFlippable()
		{
			Il2CppClassPointerStore<UIFlippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIFlippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr);
			UIFlippable.NativeFieldInfoPtr_m_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, "m_Horizontal");
			UIFlippable.NativeFieldInfoPtr_m_Veritical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, "m_Veritical");
			UIFlippable.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665989);
			UIFlippable.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665990);
			UIFlippable.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665991);
			UIFlippable.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665992);
			UIFlippable.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665993);
			UIFlippable.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665994);
			UIFlippable.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665995);
			UIFlippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr, 100665996);
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0007E940 File Offset: 0x0007CB40
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x0007E97C File Offset: 0x0007CB7C
		public unsafe bool horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0007E9BC File Offset: 0x0007CBBC
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x0007E9F8 File Offset: 0x0007CBF8
		public unsafe bool vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0007EA38 File Offset: 0x0007CC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258183, XrefRangeEnd = 258187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258187, XrefRangeEnd = 258200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyMesh(VertexHelper verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_VertexHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0007EAF4 File Offset: 0x0007CCF4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFlippable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFlippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFlippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0001480D File Offset: 0x00012A0D
		public UIFlippable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0007EB30 File Offset: 0x0007CD30
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00014816 File Offset: 0x00012A16
		public unsafe bool m_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFlippable.NativeFieldInfoPtr_m_Horizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFlippable.NativeFieldInfoPtr_m_Horizontal)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0007EB58 File Offset: 0x0007CD58
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x00014831 File Offset: 0x00012A31
		public unsafe bool m_Veritical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFlippable.NativeFieldInfoPtr_m_Veritical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFlippable.NativeFieldInfoPtr_m_Veritical)) = value;
			}
		}

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr_m_Horizontal;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeFieldInfoPtr_m_Veritical;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_VertexHelper_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Final_New_Void_Mesh_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
