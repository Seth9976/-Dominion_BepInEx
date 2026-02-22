using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

// Token: 0x020000CA RID: 202
public class UI_ConfirmPopup : MonoBehaviour
{
	// Token: 0x0600185A RID: 6234 RVA: 0x000635FC File Offset: 0x000617FC
	// Note: this type is marked as 'beforefieldinit'.
	static UI_ConfirmPopup()
	{
		Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_ConfirmPopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr);
		UI_ConfirmPopup.NativeFieldInfoPtr_m_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, "m_MessageText");
		UI_ConfirmPopup.NativeFieldInfoPtr_m_twoButtonBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, "m_twoButtonBar");
		UI_ConfirmPopup.NativeFieldInfoPtr_m_oneButtonBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, "m_oneButtonBar");
		UI_ConfirmPopup.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, "m_Callback");
		UI_ConfirmPopup.NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_String_ButtonFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, 100665231);
		UI_ConfirmPopup.NativeMethodInfoPtr_OnButtonPress_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, 100665232);
		UI_ConfirmPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, 100665233);
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x000636B8 File Offset: 0x000618B8
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 249344, RefRangeEnd = 249352, XrefRangeStart = 249339, XrefRangeEnd = 249344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(UI_ConfirmPopup.ClickCallback callback, string message, UI_ConfirmPopup.ButtonFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_String_ButtonFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x0006371C File Offset: 0x0006191C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249352, XrefRangeEnd = 249361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonPress(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.NativeMethodInfoPtr_OnButtonPress_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x0006375C File Offset: 0x0006195C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_ConfirmPopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x0000FB15 File Offset: 0x0000DD15
	public UI_ConfirmPopup(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x0600185F RID: 6239 RVA: 0x00063798 File Offset: 0x00061998
	// (set) Token: 0x06001860 RID: 6240 RVA: 0x0000FB1E File Offset: 0x0000DD1E
	public unsafe TextMeshProUGUI m_MessageText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_MessageText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_MessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x06001861 RID: 6241 RVA: 0x000637C8 File Offset: 0x000619C8
	// (set) Token: 0x06001862 RID: 6242 RVA: 0x0000FB3D File Offset: 0x0000DD3D
	public unsafe GameObject m_twoButtonBar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_twoButtonBar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_twoButtonBar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x06001863 RID: 6243 RVA: 0x000637F8 File Offset: 0x000619F8
	// (set) Token: 0x06001864 RID: 6244 RVA: 0x0000FB5C File Offset: 0x0000DD5C
	public unsafe GameObject m_oneButtonBar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_oneButtonBar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_oneButtonBar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x06001865 RID: 6245 RVA: 0x00063828 File Offset: 0x00061A28
	// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000FB7B File Offset: 0x0000DD7B
	public unsafe UI_ConfirmPopup.ClickCallback m_Callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_Callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_ConfirmPopup.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ConfirmPopup.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040010A5 RID: 4261
	private static readonly IntPtr NativeFieldInfoPtr_m_MessageText;

	// Token: 0x040010A6 RID: 4262
	private static readonly IntPtr NativeFieldInfoPtr_m_twoButtonBar;

	// Token: 0x040010A7 RID: 4263
	private static readonly IntPtr NativeFieldInfoPtr_m_oneButtonBar;

	// Token: 0x040010A8 RID: 4264
	private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

	// Token: 0x040010A9 RID: 4265
	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_ClickCallback_String_ButtonFormat_0;

	// Token: 0x040010AA RID: 4266
	private static readonly IntPtr NativeMethodInfoPtr_OnButtonPress_Public_Void_Boolean_0;

	// Token: 0x040010AB RID: 4267
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001ED RID: 493
	public enum ButtonFormat
	{
		// Token: 0x04001B5B RID: 7003
		NoButtons,
		// Token: 0x04001B5C RID: 7004
		OneButton,
		// Token: 0x04001B5D RID: 7005
		TwoButtons
	}

	// Token: 0x020001EE RID: 494
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x060027A3 RID: 10147 RVA: 0x000903F4 File Offset: 0x0008E5F4
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_ConfirmPopup>.NativeClassPtr, "ClickCallback");
			UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr, 100666422);
			UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr, 100666423);
			UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr, 100666424);
			UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr, 100666425);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00090468 File Offset: 0x0008E668
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_ConfirmPopup.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000904C4 File Offset: 0x0008E6C4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 80701, RefRangeEnd = 80719, XrefRangeStart = 80701, XrefRangeEnd = 80719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(bool bConfirm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bConfirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00090504 File Offset: 0x0008E704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249335, XrefRangeEnd = 249339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(bool bConfirm, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bConfirm;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00090574 File Offset: 0x0008E774
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ConfirmPopup.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0001879B File Offset: 0x0001699B
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000187A4 File Offset: 0x000169A4
		public static implicit operator UI_ConfirmPopup.ClickCallback(Action<bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<UI_ConfirmPopup.ClickCallback>(A_0);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000187AC File Offset: 0x000169AC
		public static UI_ConfirmPopup.ClickCallback operator +(UI_ConfirmPopup.ClickCallback A_0, UI_ConfirmPopup.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UI_ConfirmPopup.ClickCallback>();
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000187BA File Offset: 0x000169BA
		public static UI_ConfirmPopup.ClickCallback operator -(UI_ConfirmPopup.ClickCallback A_0, UI_ConfirmPopup.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UI_ConfirmPopup.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
