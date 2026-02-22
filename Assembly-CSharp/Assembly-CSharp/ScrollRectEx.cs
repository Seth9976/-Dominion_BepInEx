using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000AC RID: 172
public class ScrollRectEx : ScrollRect
{
	// Token: 0x06001440 RID: 5184 RVA: 0x00057734 File Offset: 0x00055934
	// Note: this type is marked as 'beforefieldinit'.
	static ScrollRectEx()
	{
		Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScrollRectEx");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr);
		ScrollRectEx.NativeFieldInfoPtr_routeToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, "routeToParent");
		ScrollRectEx.NativeMethodInfoPtr_DoForParents_Private_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664922);
		ScrollRectEx.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664923);
		ScrollRectEx.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664924);
		ScrollRectEx.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664925);
		ScrollRectEx.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664926);
		ScrollRectEx.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, 100664927);
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x000577F0 File Offset: 0x000559F0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 245705, RefRangeEnd = 245709, XrefRangeStart = 245686, XrefRangeEnd = 245705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoForParents<T>(Action<T> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.MethodInfoStoreGeneric_DoForParents_Private_Void_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00057834 File Offset: 0x00055A34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245709, XrefRangeEnd = 245726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnInitializePotentialDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRectEx.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00057884 File Offset: 0x00055A84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245726, XrefRangeEnd = 245743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRectEx.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x000578D4 File Offset: 0x00055AD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245743, XrefRangeEnd = 245765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBeginDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRectEx.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00057924 File Offset: 0x00055B24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245765, XrefRangeEnd = 245782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEndDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRectEx.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00057974 File Offset: 0x00055B74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245782, XrefRangeEnd = 245783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollRectEx()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x0000D2EC File Offset: 0x0000B4EC
	public ScrollRectEx(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x06001448 RID: 5192 RVA: 0x000579B0 File Offset: 0x00055BB0
	// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000D2F5 File Offset: 0x0000B4F5
	public unsafe bool routeToParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.NativeFieldInfoPtr_routeToParent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.NativeFieldInfoPtr_routeToParent)) = value;
		}
	}

	// Token: 0x04000E1E RID: 3614
	private static readonly IntPtr NativeFieldInfoPtr_routeToParent;

	// Token: 0x04000E1F RID: 3615
	private static readonly IntPtr NativeMethodInfoPtr_DoForParents_Private_Void_Action_1_T_0;

	// Token: 0x04000E20 RID: 3616
	private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0;

	// Token: 0x04000E21 RID: 3617
	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0;

	// Token: 0x04000E22 RID: 3618
	private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0;

	// Token: 0x04000E23 RID: 3619
	private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0;

	// Token: 0x04000E24 RID: 3620
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001B5 RID: 437
	[ObfuscatedName("ScrollRectEx+<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : Object
	{
		// Token: 0x060025B7 RID: 9655 RVA: 0x0008AF5C File Offset: 0x0008915C
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr);
			ScrollRectEx.__c__DisplayClass2_0.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr, "eventData");
			ScrollRectEx.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr, 100666276);
			ScrollRectEx.__c__DisplayClass2_0.NativeMethodInfoPtr__OnInitializePotentialDrag_b__0_Internal_Void_IInitializePotentialDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr, 100666277);
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0008AFC4 File Offset: 0x000891C4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass2_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x0008B000 File Offset: 0x00089200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245665, XrefRangeEnd = 245669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitializePotentialDrag_b__0(IInitializePotentialDragHandler parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass2_0.NativeMethodInfoPtr__OnInitializePotentialDrag_b__0_Internal_Void_IInitializePotentialDragHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00017697 File Offset: 0x00015897
		public __c__DisplayClass2_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0008B044 File Offset: 0x00089244
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x000176A0 File Offset: 0x000158A0
		public unsafe PointerEventData eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass2_0.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass2_0.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr__OnInitializePotentialDrag_b__0_Internal_Void_IInitializePotentialDragHandler_0;
	}

	// Token: 0x020001B6 RID: 438
	[ObfuscatedName("ScrollRectEx+<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Object
	{
		// Token: 0x060025BD RID: 9661 RVA: 0x0008B074 File Offset: 0x00089274
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr);
			ScrollRectEx.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr, "eventData");
			ScrollRectEx.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr, 100666278);
			ScrollRectEx.__c__DisplayClass3_0.NativeMethodInfoPtr__OnDrag_b__0_Internal_Void_IDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr, 100666279);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0008B0DC File Offset: 0x000892DC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass3_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0008B118 File Offset: 0x00089318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245669, XrefRangeEnd = 245673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnDrag_b__0(IDragHandler parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass3_0.NativeMethodInfoPtr__OnDrag_b__0_Internal_Void_IDragHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000176BF File Offset: 0x000158BF
		public __c__DisplayClass3_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0008B15C File Offset: 0x0008935C
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x000176C8 File Offset: 0x000158C8
		public unsafe PointerEventData eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass3_0.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr__OnDrag_b__0_Internal_Void_IDragHandler_0;
	}

	// Token: 0x020001B7 RID: 439
	[ObfuscatedName("ScrollRectEx+<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Object
	{
		// Token: 0x060025C3 RID: 9667 RVA: 0x0008B18C File Offset: 0x0008938C
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr);
			ScrollRectEx.__c__DisplayClass4_0.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr, "eventData");
			ScrollRectEx.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr, 100666280);
			ScrollRectEx.__c__DisplayClass4_0.NativeMethodInfoPtr__OnBeginDrag_b__0_Internal_Void_IBeginDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr, 100666281);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0008B1F4 File Offset: 0x000893F4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass4_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0008B230 File Offset: 0x00089430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245673, XrefRangeEnd = 245677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBeginDrag_b__0(IBeginDragHandler parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass4_0.NativeMethodInfoPtr__OnBeginDrag_b__0_Internal_Void_IBeginDragHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000176E7 File Offset: 0x000158E7
		public __c__DisplayClass4_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0008B274 File Offset: 0x00089474
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x000176F0 File Offset: 0x000158F0
		public unsafe PointerEventData eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass4_0.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass4_0.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr__OnBeginDrag_b__0_Internal_Void_IBeginDragHandler_0;
	}

	// Token: 0x020001B8 RID: 440
	[ObfuscatedName("ScrollRectEx+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Object
	{
		// Token: 0x060025C9 RID: 9673 RVA: 0x0008B2A4 File Offset: 0x000894A4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr);
			ScrollRectEx.__c__DisplayClass5_0.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr, "eventData");
			ScrollRectEx.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr, 100666282);
			ScrollRectEx.__c__DisplayClass5_0.NativeMethodInfoPtr__OnEndDrag_b__0_Internal_Void_IEndDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr, 100666283);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0008B30C File Offset: 0x0008950C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectEx.__c__DisplayClass5_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0008B348 File Offset: 0x00089548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245677, XrefRangeEnd = 245686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEndDrag_b__0(IEndDragHandler parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectEx.__c__DisplayClass5_0.NativeMethodInfoPtr__OnEndDrag_b__0_Internal_Void_IEndDragHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x0001770F File Offset: 0x0001590F
		public __c__DisplayClass5_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x0008B38C File Offset: 0x0008958C
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x00017718 File Offset: 0x00015918
		public unsafe PointerEventData eventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass5_0.NativeFieldInfoPtr_eventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectEx.__c__DisplayClass5_0.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_eventData;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr__OnEndDrag_b__0_Internal_Void_IEndDragHandler_0;
	}

	// Token: 0x020001B9 RID: 441
	private sealed class MethodInfoStoreGeneric_DoForParents_Private_Void_Action_1_T_0<T>
	{
		// Token: 0x04001A1D RID: 6685
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScrollRectEx.NativeMethodInfoPtr_DoForParents_Private_Void_Action_1_T_0, Il2CppClassPointerStore<ScrollRectEx>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
