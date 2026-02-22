using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E2 RID: 226
	public class CreateNotificationDialog : MonoBehaviour
	{
		// Token: 0x06001C0E RID: 7182 RVA: 0x0006DF68 File Offset: 0x0006C168
		// Note: this type is marked as 'beforefieldinit'.
		static CreateNotificationDialog()
		{
			Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "CreateNotificationDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr);
			CreateNotificationDialog.NativeFieldInfoPtr_DialogTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "DialogTitle");
			CreateNotificationDialog.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "Title");
			CreateNotificationDialog.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "Text");
			CreateNotificationDialog.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "ID");
			CreateNotificationDialog.NativeFieldInfoPtr_NotificationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "NotificationProfile");
			CreateNotificationDialog.NativeFieldInfoPtr_Badge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "Badge");
			CreateNotificationDialog.NativeFieldInfoPtr_HasImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "HasImage");
			CreateNotificationDialog.NativeFieldInfoPtr_HasButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "HasButtons");
			CreateNotificationDialog.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "onComplete");
			CreateNotificationDialog.NativeMethodInfoPtr_Show_Public_Void_String_Boolean_Boolean_OnComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, 100665495);
			CreateNotificationDialog.NativeMethodInfoPtr_OK_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, 100665496);
			CreateNotificationDialog.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, 100665497);
			CreateNotificationDialog.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, 100665498);
			CreateNotificationDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, 100665499);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253445, RefRangeEnd = 253449, XrefRangeStart = 253425, XrefRangeEnd = 253445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(string dialogTitle, bool showHasImage, bool showHasButtons, CreateNotificationDialog.OnComplete onComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogTitle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showHasImage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showHasButtons;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.NativeMethodInfoPtr_Show_Public_Void_String_Boolean_Boolean_OnComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0006E124 File Offset: 0x0006C324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253449, XrefRangeEnd = 253459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.NativeMethodInfoPtr_OK_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0006E158 File Offset: 0x0006C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253459, XrefRangeEnd = 253462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0006E18C File Offset: 0x0006C38C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateNotificationDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000120D7 File Offset: 0x000102D7
		public CreateNotificationDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0006E1FC File Offset: 0x0006C3FC
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x000120E0 File Offset: 0x000102E0
		public unsafe Text DialogTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_DialogTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_DialogTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0006E22C File Offset: 0x0006C42C
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x000120FF File Offset: 0x000102FF
		public unsafe Text Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0006E25C File Offset: 0x0006C45C
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0001211E File Offset: 0x0001031E
		public unsafe Text Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0006E28C File Offset: 0x0006C48C
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x0001213D File Offset: 0x0001033D
		public unsafe Text ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_ID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_ID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0006E2BC File Offset: 0x0006C4BC
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x0001215C File Offset: 0x0001035C
		public unsafe Text NotificationProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_NotificationProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_NotificationProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0006E2EC File Offset: 0x0006C4EC
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x0001217B File Offset: 0x0001037B
		public unsafe Text Badge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Badge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_Badge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0006E31C File Offset: 0x0006C51C
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x0001219A File Offset: 0x0001039A
		public unsafe Toggle HasImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_HasImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_HasImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0006E34C File Offset: 0x0006C54C
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x000121B9 File Offset: 0x000103B9
		public unsafe Toggle HasButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_HasButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_HasButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0006E37C File Offset: 0x0006C57C
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x000121D8 File Offset: 0x000103D8
		public unsafe CreateNotificationDialog.OnComplete onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateNotificationDialog.OnComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateNotificationDialog.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeFieldInfoPtr_DialogTitle;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_NotificationProfile;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_Badge;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_HasImage;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_HasButtons;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_String_Boolean_Boolean_OnComplete_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_OK_Public_Void_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000208 RID: 520
		public sealed class OnComplete : MulticastDelegate
		{
			// Token: 0x06002942 RID: 10562 RVA: 0x00094B78 File Offset: 0x00092D78
			// Note: this type is marked as 'beforefieldinit'.
			static OnComplete()
			{
				Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateNotificationDialog>.NativeClassPtr, "OnComplete");
				CreateNotificationDialog.OnComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr, 100666540);
				CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr, 100666541);
				CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Int32_String_Int32_Boolean_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr, 100666542);
				CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr, 100666543);
			}

			// Token: 0x06002943 RID: 10563 RVA: 0x00094BEC File Offset: 0x00092DEC
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnComplete(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateNotificationDialog.OnComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.OnComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002944 RID: 10564 RVA: 0x00094C48 File Offset: 0x00092E48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 253413, RefRangeEnd = 253414, XrefRangeStart = 253395, XrefRangeEnd = 253413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Int32_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002945 RID: 10565 RVA: 0x00094CE8 File Offset: 0x00092EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253414, XrefRangeEnd = 253425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Int32_String_Int32_Boolean_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002946 RID: 10566 RVA: 0x00094DBC File Offset: 0x00092FBC
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateNotificationDialog.OnComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002947 RID: 10567 RVA: 0x00019682 File Offset: 0x00017882
			public OnComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002948 RID: 10568 RVA: 0x0001968B File Offset: 0x0001788B
			public static implicit operator CreateNotificationDialog.OnComplete(Action<string, string, int, string, int, bool, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<CreateNotificationDialog.OnComplete>(A_0);
			}

			// Token: 0x06002949 RID: 10569 RVA: 0x00019693 File Offset: 0x00017893
			public static CreateNotificationDialog.OnComplete operator +(CreateNotificationDialog.OnComplete A_0, CreateNotificationDialog.OnComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CreateNotificationDialog.OnComplete>();
			}

			// Token: 0x0600294A RID: 10570 RVA: 0x000196A1 File Offset: 0x000178A1
			public static CreateNotificationDialog.OnComplete operator -(CreateNotificationDialog.OnComplete A_0, CreateNotificationDialog.OnComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CreateNotificationDialog.OnComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001C4A RID: 7242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C4B RID: 7243
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Int32_String_Int32_Boolean_Boolean_0;

			// Token: 0x04001C4C RID: 7244
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Int32_String_Int32_Boolean_Boolean_AsyncCallback_Object_0;

			// Token: 0x04001C4D RID: 7245
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
