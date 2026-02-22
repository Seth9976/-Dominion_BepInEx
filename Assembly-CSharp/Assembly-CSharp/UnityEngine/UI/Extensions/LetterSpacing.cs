using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200011D RID: 285
	public class LetterSpacing : BaseMeshEffect
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x0007CCF0 File Offset: 0x0007AEF0
		// Note: this type is marked as 'beforefieldinit'.
		static LetterSpacing()
		{
			Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "LetterSpacing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr);
			LetterSpacing.NativeFieldInfoPtr_m_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr, "m_spacing");
			LetterSpacing.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr, 100665940);
			LetterSpacing.NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr, 100665941);
			LetterSpacing.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr, 100665942);
			LetterSpacing.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr, 100665943);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x0007CD84 File Offset: 0x0007AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LetterSpacing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LetterSpacing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LetterSpacing.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0007CDC0 File Offset: 0x0007AFC0
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0007CDFC File Offset: 0x0007AFFC
		public unsafe float spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LetterSpacing.NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257537, XrefRangeEnd = 257543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LetterSpacing.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0007CE3C File Offset: 0x0007B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257543, XrefRangeEnd = 257598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LetterSpacing.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0001433B File Offset: 0x0001253B
		public LetterSpacing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0007CE8C File Offset: 0x0007B08C
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00014344 File Offset: 0x00012544
		public unsafe float m_spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LetterSpacing.NativeFieldInfoPtr_m_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LetterSpacing.NativeFieldInfoPtr_m_spacing)) = value;
			}
		}

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeFieldInfoPtr_m_spacing;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
