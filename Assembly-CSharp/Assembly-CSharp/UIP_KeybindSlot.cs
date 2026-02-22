using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B7 RID: 183
public class UIP_KeybindSlot : MonoBehaviour
{
	// Token: 0x0600161B RID: 5659 RVA: 0x0005CEBC File Offset: 0x0005B0BC
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_KeybindSlot()
	{
		Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_KeybindSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr);
		UIP_KeybindSlot.NativeFieldInfoPtr_m_displayNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "m_displayNameText");
		UIP_KeybindSlot.NativeFieldInfoPtr_m_keybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "m_keybindText");
		UIP_KeybindSlot.NativeFieldInfoPtr_m_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "m_button");
		UIP_KeybindSlot.NativeFieldInfoPtr_m_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "m_callback");
		UIP_KeybindSlot.NativeFieldInfoPtr_m_managerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "m_managerIndex");
		UIP_KeybindSlot.NativeMethodInfoPtr_Init_Public_Void_UInt32_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, 100665068);
		UIP_KeybindSlot.NativeMethodInfoPtr_UpdateText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, 100665069);
		UIP_KeybindSlot.NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, 100665070);
		UIP_KeybindSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, 100665071);
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247609, RefRangeEnd = 247610, XrefRangeStart = 247583, XrefRangeEnd = 247609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(uint index, UIP_KeybindSlot.ClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.NativeMethodInfoPtr_Init_Public_Void_UInt32_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247610, XrefRangeEnd = 247626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.NativeMethodInfoPtr_UpdateText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x0005D024 File Offset: 0x0005B224
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247626, XrefRangeEnd = 247627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x0005D058 File Offset: 0x0005B258
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_KeybindSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x0000E4B2 File Offset: 0x0000C6B2
	public UIP_KeybindSlot(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000705 RID: 1797
	// (get) Token: 0x06001621 RID: 5665 RVA: 0x0005D094 File Offset: 0x0005B294
	// (set) Token: 0x06001622 RID: 5666 RVA: 0x0000E4BB File Offset: 0x0000C6BB
	public unsafe TextMeshProUGUI m_displayNameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_displayNameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_displayNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x06001623 RID: 5667 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
	// (set) Token: 0x06001624 RID: 5668 RVA: 0x0000E4DA File Offset: 0x0000C6DA
	public unsafe TextMeshProUGUI m_keybindText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_keybindText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_keybindText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x06001625 RID: 5669 RVA: 0x0005D0F4 File Offset: 0x0005B2F4
	// (set) Token: 0x06001626 RID: 5670 RVA: 0x0000E4F9 File Offset: 0x0000C6F9
	public unsafe Button m_button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x06001627 RID: 5671 RVA: 0x0005D124 File Offset: 0x0005B324
	// (set) Token: 0x06001628 RID: 5672 RVA: 0x0000E518 File Offset: 0x0000C718
	public unsafe UIP_KeybindSlot.ClickCallback m_callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_KeybindSlot.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x06001629 RID: 5673 RVA: 0x0005D154 File Offset: 0x0005B354
	// (set) Token: 0x0600162A RID: 5674 RVA: 0x0000E537 File Offset: 0x0000C737
	public unsafe uint m_managerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_managerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_KeybindSlot.NativeFieldInfoPtr_m_managerIndex)) = value;
		}
	}

	// Token: 0x04000F48 RID: 3912
	private static readonly IntPtr NativeFieldInfoPtr_m_displayNameText;

	// Token: 0x04000F49 RID: 3913
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindText;

	// Token: 0x04000F4A RID: 3914
	private static readonly IntPtr NativeFieldInfoPtr_m_button;

	// Token: 0x04000F4B RID: 3915
	private static readonly IntPtr NativeFieldInfoPtr_m_callback;

	// Token: 0x04000F4C RID: 3916
	private static readonly IntPtr NativeFieldInfoPtr_m_managerIndex;

	// Token: 0x04000F4D RID: 3917
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_UInt32_ClickCallback_0;

	// Token: 0x04000F4E RID: 3918
	private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Public_Void_0;

	// Token: 0x04000F4F RID: 3919
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

	// Token: 0x04000F50 RID: 3920
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001D2 RID: 466
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x060026B6 RID: 9910 RVA: 0x0008DDB8 File Offset: 0x0008BFB8
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_KeybindSlot>.NativeClassPtr, "ClickCallback");
			UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr, 100666360);
			UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_KeybindSlot_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr, 100666361);
			UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_KeybindSlot_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr, 100666362);
			UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr, 100666363);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0008DE2C File Offset: 0x0008C02C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_KeybindSlot.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0008DE88 File Offset: 0x0008C088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90246, RefRangeEnd = 90249, XrefRangeStart = 90246, XrefRangeEnd = 90249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_KeybindSlot slot, uint managerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_KeybindSlot_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0008DED8 File Offset: 0x0008C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247579, XrefRangeEnd = 247583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_KeybindSlot slot, uint managerIndex, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managerIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_KeybindSlot_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0008DF5C File Offset: 0x0008C15C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_KeybindSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00017EA8 File Offset: 0x000160A8
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00017EB1 File Offset: 0x000160B1
		public static implicit operator UIP_KeybindSlot.ClickCallback(Action<UIP_KeybindSlot, uint> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIP_KeybindSlot.ClickCallback>(A_0);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00017EB9 File Offset: 0x000160B9
		public static UIP_KeybindSlot.ClickCallback operator +(UIP_KeybindSlot.ClickCallback A_0, UIP_KeybindSlot.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIP_KeybindSlot.ClickCallback>();
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00017EC7 File Offset: 0x000160C7
		public static UIP_KeybindSlot.ClickCallback operator -(UIP_KeybindSlot.ClickCallback A_0, UIP_KeybindSlot.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIP_KeybindSlot.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_KeybindSlot_UInt32_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_KeybindSlot_UInt32_AsyncCallback_Object_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
