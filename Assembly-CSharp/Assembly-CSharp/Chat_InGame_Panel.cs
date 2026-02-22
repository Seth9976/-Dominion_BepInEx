using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class Chat_InGame_Panel : MonoBehaviour
{
	// Token: 0x060008F1 RID: 2289 RVA: 0x0003440C File Offset: 0x0003260C
	// Note: this type is marked as 'beforefieldinit'.
	static Chat_InGame_Panel()
	{
		Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Chat_InGame_Panel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr);
		Chat_InGame_Panel.NativeFieldInfoPtr_InGame_Chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, "InGame_Chat");
		Chat_InGame_Panel.NativeFieldInfoPtr_m_ChatInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, "m_ChatInputField");
		Chat_InGame_Panel.NativeFieldInfoPtr_IsShowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, "IsShowing");
		Chat_InGame_Panel.NativeFieldInfoPtr_OnChatPanelOpenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, "OnChatPanelOpenCallback");
		Chat_InGame_Panel.NativeMethodInfoPtr_SetOnChatPanelOpenCallback_Public_Void_OnChatPanelOpen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, 100663897);
		Chat_InGame_Panel.NativeMethodInfoPtr_ButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, 100663898);
		Chat_InGame_Panel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, 100663899);
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000344C8 File Offset: 0x000326C8
	[CallerCount(0)]
	public unsafe void SetOnChatPanelOpenCallback(Chat_InGame_Panel.OnChatPanelOpen cb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.NativeMethodInfoPtr_SetOnChatPanelOpenCallback_Public_Void_OnChatPanelOpen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x0003450C File Offset: 0x0003270C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235316, XrefRangeEnd = 235318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.NativeMethodInfoPtr_ButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00034540 File Offset: 0x00032740
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chat_InGame_Panel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x000078EE File Offset: 0x00005AEE
	public Chat_InGame_Panel(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0003457C File Offset: 0x0003277C
	// (set) Token: 0x060008F7 RID: 2295 RVA: 0x000078F7 File Offset: 0x00005AF7
	public unsafe Animator InGame_Chat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_InGame_Chat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_InGame_Chat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000345AC File Offset: 0x000327AC
	// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00007916 File Offset: 0x00005B16
	public unsafe TMP_InputField m_ChatInputField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_m_ChatInputField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_m_ChatInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x060008FA RID: 2298 RVA: 0x000345DC File Offset: 0x000327DC
	// (set) Token: 0x060008FB RID: 2299 RVA: 0x00007935 File Offset: 0x00005B35
	public unsafe bool IsShowing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_IsShowing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_IsShowing)) = value;
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x060008FC RID: 2300 RVA: 0x00034604 File Offset: 0x00032804
	// (set) Token: 0x060008FD RID: 2301 RVA: 0x00007950 File Offset: 0x00005B50
	public unsafe Chat_InGame_Panel.OnChatPanelOpen OnChatPanelOpenCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_OnChatPanelOpenCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chat_InGame_Panel.OnChatPanelOpen>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chat_InGame_Panel.NativeFieldInfoPtr_OnChatPanelOpenCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400058F RID: 1423
	private static readonly IntPtr NativeFieldInfoPtr_InGame_Chat;

	// Token: 0x04000590 RID: 1424
	private static readonly IntPtr NativeFieldInfoPtr_m_ChatInputField;

	// Token: 0x04000591 RID: 1425
	private static readonly IntPtr NativeFieldInfoPtr_IsShowing;

	// Token: 0x04000592 RID: 1426
	private static readonly IntPtr NativeFieldInfoPtr_OnChatPanelOpenCallback;

	// Token: 0x04000593 RID: 1427
	private static readonly IntPtr NativeMethodInfoPtr_SetOnChatPanelOpenCallback_Public_Void_OnChatPanelOpen_0;

	// Token: 0x04000594 RID: 1428
	private static readonly IntPtr NativeMethodInfoPtr_ButtonPressed_Public_Void_0;

	// Token: 0x04000595 RID: 1429
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000178 RID: 376
	public sealed class OnChatPanelOpen : MulticastDelegate
	{
		// Token: 0x06002378 RID: 9080 RVA: 0x00084A38 File Offset: 0x00082C38
		// Note: this type is marked as 'beforefieldinit'.
		static OnChatPanelOpen()
		{
			Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chat_InGame_Panel>.NativeClassPtr, "OnChatPanelOpen");
			Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr, 100666108);
			Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr, 100666109);
			Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr, 100666110);
			Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr, 100666111);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00084AAC File Offset: 0x00082CAC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnChatPanelOpen(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chat_InGame_Panel.OnChatPanelOpen>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00084B08 File Offset: 0x00082D08
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00084B3C File Offset: 0x00082D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00084BA0 File Offset: 0x00082DA0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chat_InGame_Panel.OnChatPanelOpen.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000162FC File Offset: 0x000144FC
		public OnChatPanelOpen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00016305 File Offset: 0x00014505
		public static implicit operator Chat_InGame_Panel.OnChatPanelOpen(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<Chat_InGame_Panel.OnChatPanelOpen>(A_0);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0001630D File Offset: 0x0001450D
		public static Chat_InGame_Panel.OnChatPanelOpen operator +(Chat_InGame_Panel.OnChatPanelOpen A_0, Chat_InGame_Panel.OnChatPanelOpen A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Chat_InGame_Panel.OnChatPanelOpen>();
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0001631B File Offset: 0x0001451B
		public static Chat_InGame_Panel.OnChatPanelOpen operator -(Chat_InGame_Panel.OnChatPanelOpen A_0, Chat_InGame_Panel.OnChatPanelOpen A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Chat_InGame_Panel.OnChatPanelOpen>();
			}
			return delegate2;
		}

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
