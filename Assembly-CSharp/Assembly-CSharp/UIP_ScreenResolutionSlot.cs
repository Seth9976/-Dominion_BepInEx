using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

// Token: 0x020000BC RID: 188
public class UIP_ScreenResolutionSlot : MonoBehaviour
{
	// Token: 0x060016D1 RID: 5841 RVA: 0x0005EF30 File Offset: 0x0005D130
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_ScreenResolutionSlot()
	{
		Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_ScreenResolutionSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr);
		UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_colorizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, "m_colorizer");
		UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_clickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, "m_clickCallback");
		UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, "m_resolutionText");
		UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, "m_resolutionIndex");
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_get_ResolutionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665116);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_set_ResolutionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665117);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_get_ResolutionTextString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665118);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_set_ResolutionTextString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665119);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665120);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr_OnSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665121);
		UIP_ScreenResolutionSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, 100665122);
	}

	// Token: 0x17000747 RID: 1863
	// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0005F03C File Offset: 0x0005D23C
	// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0005F078 File Offset: 0x0005D278
	public unsafe int ResolutionIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_get_ResolutionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_set_ResolutionIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000748 RID: 1864
	// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
	// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0005F0F0 File Offset: 0x0005D2F0
	public unsafe string ResolutionTextString
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247901, XrefRangeEnd = 247902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_get_ResolutionTextString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247902, XrefRangeEnd = 247903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_set_ResolutionTextString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x0005F134 File Offset: 0x0005D334
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetClickListener(UIP_ScreenResolutionSlot.ClickCallback cb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x0005F178 File Offset: 0x0005D378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247903, XrefRangeEnd = 247904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr_OnSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0005F1AC File Offset: 0x0005D3AC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_ScreenResolutionSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0000EC48 File Offset: 0x0000CE48
	public UIP_ScreenResolutionSlot(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x060016DA RID: 5850 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
	// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000EC51 File Offset: 0x0000CE51
	public unsafe ColorByFaction m_colorizer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_colorizer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorByFaction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_colorizer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x060016DC RID: 5852 RVA: 0x0005F218 File Offset: 0x0005D418
	// (set) Token: 0x060016DD RID: 5853 RVA: 0x0000EC70 File Offset: 0x0000CE70
	public unsafe UIP_ScreenResolutionSlot.ClickCallback m_clickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_clickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_ScreenResolutionSlot.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_clickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x060016DE RID: 5854 RVA: 0x0005F248 File Offset: 0x0005D448
	// (set) Token: 0x060016DF RID: 5855 RVA: 0x0000EC8F File Offset: 0x0000CE8F
	public unsafe TextMeshProUGUI m_resolutionText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0005F278 File Offset: 0x0005D478
	// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000ECAE File Offset: 0x0000CEAE
	public unsafe int m_resolutionIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ScreenResolutionSlot.NativeFieldInfoPtr_m_resolutionIndex)) = value;
		}
	}

	// Token: 0x04000FB6 RID: 4022
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizer;

	// Token: 0x04000FB7 RID: 4023
	private static readonly IntPtr NativeFieldInfoPtr_m_clickCallback;

	// Token: 0x04000FB8 RID: 4024
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionText;

	// Token: 0x04000FB9 RID: 4025
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionIndex;

	// Token: 0x04000FBA RID: 4026
	private static readonly IntPtr NativeMethodInfoPtr_get_ResolutionIndex_Public_get_Int32_0;

	// Token: 0x04000FBB RID: 4027
	private static readonly IntPtr NativeMethodInfoPtr_set_ResolutionIndex_Public_set_Void_Int32_0;

	// Token: 0x04000FBC RID: 4028
	private static readonly IntPtr NativeMethodInfoPtr_get_ResolutionTextString_Public_get_String_0;

	// Token: 0x04000FBD RID: 4029
	private static readonly IntPtr NativeMethodInfoPtr_set_ResolutionTextString_Public_set_Void_String_0;

	// Token: 0x04000FBE RID: 4030
	private static readonly IntPtr NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0;

	// Token: 0x04000FBF RID: 4031
	private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Void_0;

	// Token: 0x04000FC0 RID: 4032
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001D6 RID: 470
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x0008E510 File Offset: 0x0008C710
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_ScreenResolutionSlot>.NativeClassPtr, "ClickCallback");
			UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr, 100666374);
			UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_ScreenResolutionSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr, 100666375);
			UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_ScreenResolutionSlot_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr, 100666376);
			UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr, 100666377);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0008E584 File Offset: 0x0008C784
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_ScreenResolutionSlot.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0008E5E0 File Offset: 0x0008C7E0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_ScreenResolutionSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_ScreenResolutionSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0008E624 File Offset: 0x0008C824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_ScreenResolutionSlot slot, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_ScreenResolutionSlot_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0008E698 File Offset: 0x0008C898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ScreenResolutionSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00017FBB File Offset: 0x000161BB
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00017FC4 File Offset: 0x000161C4
		public static implicit operator UIP_ScreenResolutionSlot.ClickCallback(Action<UIP_ScreenResolutionSlot> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIP_ScreenResolutionSlot.ClickCallback>(A_0);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00017FCC File Offset: 0x000161CC
		public static UIP_ScreenResolutionSlot.ClickCallback operator +(UIP_ScreenResolutionSlot.ClickCallback A_0, UIP_ScreenResolutionSlot.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIP_ScreenResolutionSlot.ClickCallback>();
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00017FDA File Offset: 0x000161DA
		public static UIP_ScreenResolutionSlot.ClickCallback operator -(UIP_ScreenResolutionSlot.ClickCallback A_0, UIP_ScreenResolutionSlot.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIP_ScreenResolutionSlot.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_ScreenResolutionSlot_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_ScreenResolutionSlot_AsyncCallback_Object_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
