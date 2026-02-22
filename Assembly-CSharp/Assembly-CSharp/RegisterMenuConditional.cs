using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000A9 RID: 169
public class RegisterMenuConditional : RegisterMenu
{
	// Token: 0x060013CF RID: 5071 RVA: 0x00055F94 File Offset: 0x00054194
	// Note: this type is marked as 'beforefieldinit'.
	static RegisterMenuConditional()
	{
		Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RegisterMenuConditional");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr);
		RegisterMenuConditional.NativeFieldInfoPtr_m_themeVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, "m_themeVariableName");
		RegisterMenuConditional.NativeFieldInfoPtr_m_themes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, "m_themes");
		RegisterMenuConditional.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, 100664876);
		RegisterMenuConditional.NativeMethodInfoPtr_SetTheme_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, 100664877);
		RegisterMenuConditional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, 100664878);
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00056028 File Offset: 0x00054228
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244898, XrefRangeEnd = 244954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterMenuConditional.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00056064 File Offset: 0x00054264
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244954, XrefRangeEnd = 244958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTheme(int themeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref themeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenuConditional.NativeMethodInfoPtr_SetTheme_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x000560A4 File Offset: 0x000542A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegisterMenuConditional()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterMenuConditional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0000CF50 File Offset: 0x0000B150
	public RegisterMenuConditional(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000560E0 File Offset: 0x000542E0
	// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0000CF59 File Offset: 0x0000B159
	public unsafe string m_themeVariableName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.NativeFieldInfoPtr_m_themeVariableName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.NativeFieldInfoPtr_m_themeVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00056108 File Offset: 0x00054308
	// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0000CF78 File Offset: 0x0000B178
	public unsafe Il2CppReferenceArray<RegisterMenuConditional.Theme> m_themes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.NativeFieldInfoPtr_m_themes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RegisterMenuConditional.Theme>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.NativeFieldInfoPtr_m_themes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000DD2 RID: 3538
	private static readonly IntPtr NativeFieldInfoPtr_m_themeVariableName;

	// Token: 0x04000DD3 RID: 3539
	private static readonly IntPtr NativeFieldInfoPtr_m_themes;

	// Token: 0x04000DD4 RID: 3540
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

	// Token: 0x04000DD5 RID: 3541
	private static readonly IntPtr NativeMethodInfoPtr_SetTheme_Public_Void_Int32_0;

	// Token: 0x04000DD6 RID: 3542
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001AE RID: 430
	[Serializable]
	public sealed class Theme : ValueType
	{
		// Token: 0x06002558 RID: 9560 RVA: 0x00089E48 File Offset: 0x00088048
		// Note: this type is marked as 'beforefieldinit'.
		static Theme()
		{
			Il2CppClassPointerStore<RegisterMenuConditional.Theme>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterMenuConditional>.NativeClassPtr, "Theme");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterMenuConditional.Theme>.NativeClassPtr);
			RegisterMenuConditional.Theme.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenuConditional.Theme>.NativeClassPtr, "animator");
			RegisterMenuConditional.Theme.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterMenuConditional.Theme>.NativeClassPtr, "nodes");
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00017351 File Offset: 0x00015551
		public Theme(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0001735A File Offset: 0x0001555A
		public Theme()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterMenuConditional.Theme>.NativeClassPtr))
		{
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x00089E9C File Offset: 0x0008809C
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x0001736C File Offset: 0x0001556C
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.Theme.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.Theme.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x00089ECC File Offset: 0x000880CC
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x0001738B File Offset: 0x0001558B
		public unsafe Il2CppReferenceArray<GameObject> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.Theme.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterMenuConditional.Theme.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_nodes;
	}
}
