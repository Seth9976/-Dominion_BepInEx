using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000104 RID: 260
public class PreviewScreenUtil : MonoBehaviour
{
	// Token: 0x060011D4 RID: 4564 RVA: 0x00055170 File Offset: 0x00053370
	// Note: this type is marked as 'beforefieldinit'.
	static PreviewScreenUtil()
	{
		Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PreviewScreenUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr);
		PreviewScreenUtil.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, "_instance");
		PreviewScreenUtil.NativeFieldInfoPtr_ActionScreenResized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, "ActionScreenResized");
		PreviewScreenUtil.NativeFieldInfoPtr_W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, "W");
		PreviewScreenUtil.NativeFieldInfoPtr_H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, "H");
		PreviewScreenUtil.NativeMethodInfoPtr_add_ActionScreenResized_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665459);
		PreviewScreenUtil.NativeMethodInfoPtr_remove_ActionScreenResized_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665460);
		PreviewScreenUtil.NativeMethodInfoPtr_isInScreenRect_Public_Static_Boolean_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665461);
		PreviewScreenUtil.NativeMethodInfoPtr_getObjectBounds_Public_Static_Rect_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665462);
		PreviewScreenUtil.NativeMethodInfoPtr_getRendererBounds_Public_Static_Rect_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665463);
		PreviewScreenUtil.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665464);
		PreviewScreenUtil.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665465);
		PreviewScreenUtil.NativeMethodInfoPtr_get_instance_Public_Static_get_PreviewScreenUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665466);
		PreviewScreenUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, 100665467);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x000552A4 File Offset: 0x000534A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182184, XrefRangeEnd = 182188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionScreenResized(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_add_ActionScreenResized_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x000552E8 File Offset: 0x000534E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182188, XrefRangeEnd = 182192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionScreenResized(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_remove_ActionScreenResized_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x0005532C File Offset: 0x0005352C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182192, XrefRangeEnd = 182194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isInScreenRect(Rect rect, Vector2 point)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rect;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_isInScreenRect_Public_Static_Boolean_Rect_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00055378 File Offset: 0x00053578
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 182221, RefRangeEnd = 182224, XrefRangeStart = 182194, XrefRangeEnd = 182221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect getObjectBounds(GameObject obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_getObjectBounds_Public_Static_Rect_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x000553BC File Offset: 0x000535BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182224, XrefRangeEnd = 182238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect getRendererBounds(Renderer renderer)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_getRendererBounds_Public_Static_Rect_Renderer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00055400 File Offset: 0x00053600
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182238, XrefRangeEnd = 182240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00055434 File Offset: 0x00053634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182240, XrefRangeEnd = 182245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x060011DC RID: 4572 RVA: 0x00055468 File Offset: 0x00053668
	public unsafe static PreviewScreenUtil instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182245, XrefRangeEnd = 182273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr_get_instance_Public_Static_get_PreviewScreenUtil_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreviewScreenUtil>(intPtr3) : null;
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x0005549C File Offset: 0x0005369C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182273, XrefRangeEnd = 182288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PreviewScreenUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00008E1D File Offset: 0x0000701D
	public PreviewScreenUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x060011DF RID: 4575 RVA: 0x000554D8 File Offset: 0x000536D8
	// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00008E26 File Offset: 0x00007026
	public unsafe static PreviewScreenUtil _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PreviewScreenUtil.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreviewScreenUtil>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PreviewScreenUtil.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00055500 File Offset: 0x00053700
	// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00008E38 File Offset: 0x00007038
	public unsafe Action ActionScreenResized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_ActionScreenResized);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_ActionScreenResized), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00055530 File Offset: 0x00053730
	// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00008E57 File Offset: 0x00007057
	public unsafe int W
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_W);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_W)) = value;
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00055558 File Offset: 0x00053758
	// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00008E72 File Offset: 0x00007072
	public unsafe int H
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_H);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreviewScreenUtil.NativeFieldInfoPtr_H)) = value;
		}
	}

	// Token: 0x04000DBF RID: 3519
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000DC0 RID: 3520
	private static readonly IntPtr NativeFieldInfoPtr_ActionScreenResized;

	// Token: 0x04000DC1 RID: 3521
	private static readonly IntPtr NativeFieldInfoPtr_W;

	// Token: 0x04000DC2 RID: 3522
	private static readonly IntPtr NativeFieldInfoPtr_H;

	// Token: 0x04000DC3 RID: 3523
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionScreenResized_Public_add_Void_Action_0;

	// Token: 0x04000DC4 RID: 3524
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionScreenResized_Public_rem_Void_Action_0;

	// Token: 0x04000DC5 RID: 3525
	private static readonly IntPtr NativeMethodInfoPtr_isInScreenRect_Public_Static_Boolean_Rect_Vector2_0;

	// Token: 0x04000DC6 RID: 3526
	private static readonly IntPtr NativeMethodInfoPtr_getObjectBounds_Public_Static_Rect_GameObject_0;

	// Token: 0x04000DC7 RID: 3527
	private static readonly IntPtr NativeMethodInfoPtr_getRendererBounds_Public_Static_Rect_Renderer_0;

	// Token: 0x04000DC8 RID: 3528
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DC9 RID: 3529
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000DCA RID: 3530
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PreviewScreenUtil_0;

	// Token: 0x04000DCB RID: 3531
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200039B RID: 923
	[ObfuscatedName("PreviewScreenUtil+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060036A4 RID: 13988 RVA: 0x000DFF10 File Offset: 0x000DE110
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreviewScreenUtil>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr);
			PreviewScreenUtil.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr, "<>9");
			PreviewScreenUtil.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr, "<>9__13_0");
			PreviewScreenUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr, 100670244);
			PreviewScreenUtil.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr, 100670245);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000DFF8C File Offset: 0x000DE18C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewScreenUtil.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000DFFC8 File Offset: 0x000DE1C8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreviewScreenUtil.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000152F0 File Offset: 0x000134F0
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x000DFFFC File Offset: 0x000DE1FC
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x000152F9 File Offset: 0x000134F9
		public unsafe static PreviewScreenUtil.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PreviewScreenUtil.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreviewScreenUtil.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PreviewScreenUtil.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x000E0024 File Offset: 0x000DE224
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x0001530B File Offset: 0x0001350B
		public unsafe static Action __9__13_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PreviewScreenUtil.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PreviewScreenUtil.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0;
	}
}
