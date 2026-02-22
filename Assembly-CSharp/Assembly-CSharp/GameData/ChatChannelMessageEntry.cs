using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000131 RID: 305
	public sealed class ChatChannelMessageEntry : ValueType
	{
		// Token: 0x060021C4 RID: 8644 RVA: 0x00080050 File Offset: 0x0007E250
		// Note: this type is marked as 'beforefieldinit'.
		static ChatChannelMessageEntry()
		{
			Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "ChatChannelMessageEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr);
			ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr, "chatMessageIndex");
			ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr, "chatUserID");
			ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr, "chatUserDisplayName");
			ChatChannelMessageEntry.NativeFieldInfoPtr_chatTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr, "chatTimestamp");
			ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr, "chatMessage");
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000150E0 File Offset: 0x000132E0
		public ChatChannelMessageEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000150E9 File Offset: 0x000132E9
		public ChatChannelMessageEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatChannelMessageEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000800E4 File Offset: 0x0007E2E4
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x000150FB File Offset: 0x000132FB
		public unsafe uint chatMessageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessageIndex)) = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0008010C File Offset: 0x0007E30C
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00015116 File Offset: 0x00013316
		public unsafe uint chatUserID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserID)) = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00080134 File Offset: 0x0007E334
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00015131 File Offset: 0x00013331
		public unsafe string chatUserDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatUserDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x0008015C File Offset: 0x0007E35C
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00015150 File Offset: 0x00013350
		public unsafe string chatTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatTimestamp);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatTimestamp), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00080184 File Offset: 0x0007E384
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0001516F File Offset: 0x0001336F
		public unsafe string chatMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatChannelMessageEntry.NativeFieldInfoPtr_chatMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr_chatMessageIndex;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_chatUserID;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_chatUserDisplayName;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_chatTimestamp;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_chatMessage;
	}
}
