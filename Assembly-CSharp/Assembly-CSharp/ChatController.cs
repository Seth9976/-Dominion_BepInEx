using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000DF RID: 223
public class ChatController : MonoBehaviour
{
	// Token: 0x06001BE8 RID: 7144 RVA: 0x0006D908 File Offset: 0x0006BB08
	// Note: this type is marked as 'beforefieldinit'.
	static ChatController()
	{
		Il2CppClassPointerStore<ChatController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChatController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatController>.NativeClassPtr);
		ChatController.NativeFieldInfoPtr_TMP_ChatInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatController>.NativeClassPtr, "TMP_ChatInput");
		ChatController.NativeFieldInfoPtr_TMP_ChatOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatController>.NativeClassPtr, "TMP_ChatOutput");
		ChatController.NativeFieldInfoPtr_ChatScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatController>.NativeClassPtr, "ChatScrollbar");
		ChatController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatController>.NativeClassPtr, 100665485);
		ChatController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatController>.NativeClassPtr, 100665486);
		ChatController.NativeMethodInfoPtr_AddToChatOutput_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatController>.NativeClassPtr, 100665487);
		ChatController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatController>.NativeClassPtr, 100665488);
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x0006D9C4 File Offset: 0x0006BBC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253291, XrefRangeEnd = 253303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253303, XrefRangeEnd = 253315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x0006DA2C File Offset: 0x0006BC2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253315, XrefRangeEnd = 253362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToChatOutput(string newText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatController.NativeMethodInfoPtr_AddToChatOutput_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x0006DA70 File Offset: 0x0006BC70
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x00011F77 File Offset: 0x00010177
	public ChatController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0006DAAC File Offset: 0x0006BCAC
	// (set) Token: 0x06001BEF RID: 7151 RVA: 0x00011F80 File Offset: 0x00010180
	public unsafe TMP_InputField TMP_ChatInput
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_TMP_ChatInput);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_TMP_ChatInput), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0006DADC File Offset: 0x0006BCDC
	// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00011F9F File Offset: 0x0001019F
	public unsafe TMP_Text TMP_ChatOutput
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_TMP_ChatOutput);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_TMP_ChatOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008F9 RID: 2297
	// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0006DB0C File Offset: 0x0006BD0C
	// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00011FBE File Offset: 0x000101BE
	public unsafe Scrollbar ChatScrollbar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_ChatScrollbar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatController.NativeFieldInfoPtr_ChatScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040012D6 RID: 4822
	private static readonly IntPtr NativeFieldInfoPtr_TMP_ChatInput;

	// Token: 0x040012D7 RID: 4823
	private static readonly IntPtr NativeFieldInfoPtr_TMP_ChatOutput;

	// Token: 0x040012D8 RID: 4824
	private static readonly IntPtr NativeFieldInfoPtr_ChatScrollbar;

	// Token: 0x040012D9 RID: 4825
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040012DA RID: 4826
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040012DB RID: 4827
	private static readonly IntPtr NativeMethodInfoPtr_AddToChatOutput_Private_Void_String_0;

	// Token: 0x040012DC RID: 4828
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
